# NVIDIA Founders Edition GPU Light Control

![](https://img.shields.io/github/license/xWTF/NvidiaFoundersLightControl)
![](https://img.shields.io/badge/It%20Works-On%20My%20Machine%E2%84%A2%EF%B8%8F-green)

Yet another way to control lights for NVIDIA Founders Edition GPUs. The LEDs become super annoying in certain desktop layouts ¯\\\_(ツ)\_\/¯

### How does it work?

The program calls [NvAPI_GPU_ClientIllumZonesGetControl](https://docs.nvidia.com/gameworks/content/gameworkslibrary/coresdk/nvapi/group__oglapi.html#gae7572cde22df80a79eada415407f86de) and [NvAPI_GPU_ClientIllumZonesSetControl](https://docs.nvidia.com/gameworks/content/gameworkslibrary/coresdk/nvapi/group__oglapi.html#ga3241cce9a8ea6dddbc5d261dcaedc1d7) to adjust brightness / colors.

It's using the amazing [NvApiWrapper](https://github.com/falahati/NvAPIWrapper) library to do that :)

### Compatibility

Tested cards:
- NVIDIA GeForce RTX 4090 Founders Edition

Although sliders may not work on every GPU, the `Just Light Off` button should always work as long as the card implements the standard APIs.

The save / load defaults buttons may or may not work, IDK ¯\\\_(ツ)\_\/¯
