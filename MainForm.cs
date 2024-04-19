using NvAPIWrapper.GPU;
using NvAPIWrapper.Native;
using NvAPIWrapper.Native.GPU;
using NvAPIWrapper.Native.GPU.Structures;

namespace NvidiaFoundersLightControl
{
    public partial class MainForm : Form
    {
        PhysicalGPU[] physicalGPUs;

        PhysicalGPU? currentGPU;
        IlluminationZoneControlV1[]? currentZones;

        public MainForm()
        {
            InitializeComponent();

            physicalGPUs = PhysicalGPU.GetPhysicalGPUs();
            if (physicalGPUs.Length == 0)
            {
                MessageBox.Show("No NVIDIA GPU found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            for (var i = 0; i < physicalGPUs.Length; i++)
            {
                var gpu = physicalGPUs[i];
                comboBox_gpu.Items.Add($"#{i} {gpu.FullName} [{gpu.Bios.VersionString}]");
            }
            comboBox_gpu.SelectedIndex = 0;
        }

        private void comboBox_gpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentGPU = null;
            var gpu = physicalGPUs[comboBox_gpu.SelectedIndex];

            currentZones = GPUApi.ClientIlluminationZonesGetControl(gpu.Handle, IlluminationZoneControlValuesType.CurrentlyActive).ZoneControls;

            var zoneInfo = GPUApi.ClientIlluminationZonesGetInfo(gpu.Handle).Zones;
            for (int i = 0; i < currentZones.Length; i++)
            {
                var zone = currentZones[i].AsRGBData().AsManual().Parameters;
                switch (zoneInfo[i].ZoneLocation)
                {
                case IlluminationZoneLocation.GPUTop:
                    groupBox_logo.Enabled = true;
                    groupBox_logo.Tag = i;

                    trackBar_logo.Value = zone.Red;
                    break;
                case (IlluminationZoneLocation)8: // NV_GPU_CLIENT_ILLUM_ZONE_LOCATION_GPU_FRONT_0
                    groupBox_x.Enabled = true;
                    groupBox_x.Tag = i;

                    trackBar_x_red.Value = zone.Red;
                    trackBar_x_green.Value = zone.Green;
                    trackBar_x_blue.Value = zone.Blue;
                    trackBar_x_brightness.Value = zone.BrightnessInPercentage;
                    break;
                case (IlluminationZoneLocation)0x0C: // NV_GPU_CLIENT_ILLUM_ZONE_LOCATION_GPU_BACK_0
                case IlluminationZoneLocation.SLITop:
                    break;
                }
            }
            currentGPU = gpu;
        }

        private void trackBar_Scroll(object sender, EventArgs e) => updateZones();

        private void button_light_off_Click(object sender, EventArgs e)
        {
            if (currentGPU == null || currentZones == null) return;

            trackBar_logo.Value = trackBar_x_red.Value = trackBar_x_green.Value = trackBar_x_blue.Value = trackBar_x_brightness.Value = 0;

            for (var i = 0; i < currentZones.Length; i++)
            {
                currentZones[i] = createRgbControl();
            }
            updateZones();
        }

        private void button_set_default_Click(object sender, EventArgs e) => updateZones(IlluminationZoneControlValuesType.Default);

        private void button_load_default_Click(object sender, EventArgs e)
        {
            if (currentGPU == null || currentZones == null) return;

            GPUApi.ClientIlluminationZonesSetControl(currentGPU.Handle, new IlluminationZoneControlParametersV1(IlluminationZoneControlValuesType.CurrentlyActive, GPUApi.ClientIlluminationZonesGetControl(currentGPU.Handle, IlluminationZoneControlValuesType.Default).ZoneControls));
            Thread.Sleep(100);

            comboBox_gpu_SelectedIndexChanged(sender, e);
        }

        private IlluminationZoneControlV1 createRgbControl(int red = 0, int green = 0, int blue = 0, int brightness = 0) => new(IlluminationZoneControlMode.ManualRGB, new IlluminationZoneControlDataRGB(new IlluminationZoneControlDataManualRGB(new IlluminationZoneControlDataManualRGBParameters((byte)red, (byte)green, (byte)blue, (byte)brightness))));

        private void updateZones(IlluminationZoneControlValuesType type = IlluminationZoneControlValuesType.CurrentlyActive)
        {
            if (currentGPU == null || currentZones == null) return;

            if (groupBox_logo.Enabled)
            {
                currentZones[(int)groupBox_logo.Tag!] = createRgbControl(trackBar_logo.Value);
            }
            if (groupBox_x.Enabled)
            {
                currentZones[(int)groupBox_x.Tag!] = createRgbControl(trackBar_x_red.Value, trackBar_x_green.Value, trackBar_x_blue.Value, trackBar_x_brightness.Value);
            }

            GPUApi.ClientIlluminationZonesSetControl(currentGPU.Handle, new IlluminationZoneControlParametersV1(type, currentZones));
            Thread.Sleep(30);
        }
    }
}
