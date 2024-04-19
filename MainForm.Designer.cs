namespace NvidiaFoundersLightControl
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox_gpu = new ComboBox();
            trackBar_logo = new TrackBar();
            groupBox_logo = new GroupBox();
            groupBox_x = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            trackBar_x_brightness = new TrackBar();
            trackBar_x_blue = new TrackBar();
            trackBar_x_green = new TrackBar();
            trackBar_x_red = new TrackBar();
            button_light_off = new Button();
            button_set_default = new Button();
            button_load_default = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar_logo).BeginInit();
            groupBox_logo.SuspendLayout();
            groupBox_x.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_brightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_red).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 0;
            label1.Text = "GPU:";
            // 
            // comboBox_gpu
            // 
            comboBox_gpu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_gpu.FormattingEnabled = true;
            comboBox_gpu.Location = new Point(54, 12);
            comboBox_gpu.Name = "comboBox_gpu";
            comboBox_gpu.Size = new Size(597, 25);
            comboBox_gpu.TabIndex = 1;
            comboBox_gpu.SelectedIndexChanged += comboBox_gpu_SelectedIndexChanged;
            // 
            // trackBar_logo
            // 
            trackBar_logo.Location = new Point(6, 22);
            trackBar_logo.Maximum = 255;
            trackBar_logo.Name = "trackBar_logo";
            trackBar_logo.Size = new Size(627, 45);
            trackBar_logo.TabIndex = 3;
            trackBar_logo.TickFrequency = 10;
            trackBar_logo.TickStyle = TickStyle.Both;
            trackBar_logo.Scroll += trackBar_Scroll;
            // 
            // groupBox_logo
            // 
            groupBox_logo.Controls.Add(trackBar_logo);
            groupBox_logo.Location = new Point(12, 43);
            groupBox_logo.Name = "groupBox_logo";
            groupBox_logo.Size = new Size(639, 75);
            groupBox_logo.TabIndex = 4;
            groupBox_logo.TabStop = false;
            groupBox_logo.Text = "GEFORCE RTX Logo";
            // 
            // groupBox_x
            // 
            groupBox_x.Controls.Add(label4);
            groupBox_x.Controls.Add(label5);
            groupBox_x.Controls.Add(label3);
            groupBox_x.Controls.Add(label2);
            groupBox_x.Controls.Add(trackBar_x_brightness);
            groupBox_x.Controls.Add(trackBar_x_blue);
            groupBox_x.Controls.Add(trackBar_x_green);
            groupBox_x.Controls.Add(trackBar_x_red);
            groupBox_x.Location = new Point(12, 124);
            groupBox_x.Name = "groupBox_x";
            groupBox_x.Size = new Size(639, 232);
            groupBox_x.TabIndex = 4;
            groupBox_x.TabStop = false;
            groupBox_x.Text = "X Shaped Thing";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 4;
            label4.Text = "Blue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 189);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 4;
            label5.Text = "White";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 4;
            label3.Text = "Green";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 4;
            label2.Text = "Red";
            // 
            // trackBar_x_brightness
            // 
            trackBar_x_brightness.Location = new Point(53, 175);
            trackBar_x_brightness.Maximum = 100;
            trackBar_x_brightness.Name = "trackBar_x_brightness";
            trackBar_x_brightness.Size = new Size(580, 45);
            trackBar_x_brightness.TabIndex = 3;
            trackBar_x_brightness.TickFrequency = 10;
            trackBar_x_brightness.TickStyle = TickStyle.Both;
            trackBar_x_brightness.Scroll += trackBar_Scroll;
            // 
            // trackBar_x_blue
            // 
            trackBar_x_blue.Location = new Point(53, 124);
            trackBar_x_blue.Maximum = 255;
            trackBar_x_blue.Name = "trackBar_x_blue";
            trackBar_x_blue.Size = new Size(580, 45);
            trackBar_x_blue.TabIndex = 3;
            trackBar_x_blue.TickFrequency = 10;
            trackBar_x_blue.TickStyle = TickStyle.Both;
            trackBar_x_blue.Scroll += trackBar_Scroll;
            // 
            // trackBar_x_green
            // 
            trackBar_x_green.Location = new Point(53, 73);
            trackBar_x_green.Maximum = 255;
            trackBar_x_green.Name = "trackBar_x_green";
            trackBar_x_green.Size = new Size(580, 45);
            trackBar_x_green.TabIndex = 3;
            trackBar_x_green.TickFrequency = 10;
            trackBar_x_green.TickStyle = TickStyle.Both;
            trackBar_x_green.Scroll += trackBar_Scroll;
            // 
            // trackBar_x_red
            // 
            trackBar_x_red.Location = new Point(53, 22);
            trackBar_x_red.Maximum = 255;
            trackBar_x_red.Name = "trackBar_x_red";
            trackBar_x_red.Size = new Size(580, 45);
            trackBar_x_red.TabIndex = 3;
            trackBar_x_red.TickFrequency = 10;
            trackBar_x_red.TickStyle = TickStyle.Both;
            trackBar_x_red.Scroll += trackBar_Scroll;
            // 
            // button_light_off
            // 
            button_light_off.Location = new Point(499, 362);
            button_light_off.Name = "button_light_off";
            button_light_off.Size = new Size(152, 25);
            button_light_off.TabIndex = 5;
            button_light_off.Text = "Just Light Off ™️";
            button_light_off.UseVisualStyleBackColor = true;
            button_light_off.Click += button_light_off_Click;
            // 
            // button_set_default
            // 
            button_set_default.Location = new Point(375, 362);
            button_set_default.Name = "button_set_default";
            button_set_default.Size = new Size(118, 25);
            button_set_default.TabIndex = 5;
            button_set_default.Text = "Set as Default";
            button_set_default.UseVisualStyleBackColor = true;
            button_set_default.Click += button_set_default_Click;
            // 
            // button_load_default
            // 
            button_load_default.Location = new Point(251, 362);
            button_load_default.Name = "button_load_default";
            button_load_default.Size = new Size(118, 25);
            button_load_default.TabIndex = 5;
            button_load_default.Text = "Load Default";
            button_load_default.UseVisualStyleBackColor = true;
            button_load_default.Click += button_load_default_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 399);
            Controls.Add(button_load_default);
            Controls.Add(button_set_default);
            Controls.Add(button_light_off);
            Controls.Add(groupBox_x);
            Controls.Add(groupBox_logo);
            Controls.Add(comboBox_gpu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Nvidia Founders Edition Light Control";
            ((System.ComponentModel.ISupportInitialize)trackBar_logo).EndInit();
            groupBox_logo.ResumeLayout(false);
            groupBox_logo.PerformLayout();
            groupBox_x.ResumeLayout(false);
            groupBox_x.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_brightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_green).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_red).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox_gpu;
        private TrackBar trackBar_logo;
        private GroupBox groupBox_logo;
        private GroupBox groupBox_x;
        private TrackBar trackBar_x_red;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TrackBar trackBar_x_brightness;
        private TrackBar trackBar_x_blue;
        private TrackBar trackBar_x_green;
        private Button button_light_off;
        private Button button_set_default;
        private Button button_load_default;
    }
}
