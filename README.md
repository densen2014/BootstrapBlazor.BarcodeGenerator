# Blazor BarcodeGenerator 条码生成器 组件  

基于[JsBarcode]([https://github.com/fengyuanchen/cropperjs](https://github.com/lindell/JsBarcode))的Blazor组件

示例:

https://www.blazor.zone/BarcodeGenerators

https://blazor.app1.es/BarcodeGenerators

使用方法:

1.nuget包

```BootstrapBlazor.BarcodeGenerator```

2._Imports.razor 文件 或者页面添加 添加组件库引用

```@using BootstrapBlazor.Components```


3.razor页面
```
<BarCodeGenerator Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.CODE128" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.EAN13" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.EAN8" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.EAN5" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.EAN2" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.UPC" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.CODE39" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.ITF14" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.MSI" Value="@value"/>
<BarCodeGenerator Type="EnumBarcodeType.pharmacode" Value="@value"/>
```

4.参数说明

|  类型   |  参数   | 说明  | 默认值  | 
|  ----  |  ----  | ----  | ----  | 
| [EnumBarcodeType](https://github.com/densen2014/BootstrapBlazor.BarcodeGenerator/blob/master/src/BootstrapBlazor.BarcodeGenerator/EnumBarcodeType.cs) | Type  | 条码类型/ Barcode type |  | 
| string | Value  | 条码值/ Barcode value |  | 
| [BarcodeGeneratorOption](https://github.com/densen2014/BootstrapBlazor.BarcodeGenerator/blob/master/src/BootstrapBlazor.BarcodeGenerator/BarcodeGeneratorOption.cs) | Options  | 选项/Options |  | 
| Task  | GenerateBarcode | 条码生成/ Barcode generated | | 
| Func<Stream, Task>  | OnResult | 条码生成(svg)回调方法/ Barcode generated(svg) callback method | | 
| Func&lt;string, Task&gt;? |  OnError | 错误回调 |

[EnumBarcodeType](https://github.com/densen2014/BootstrapBlazor.BarcodeGenerator/blob/master/src/BootstrapBlazor.BarcodeGenerator/EnumBarcodeType.cs)

[BarcodeGeneratorOption](https://github.com/densen2014/BootstrapBlazor.BarcodeGenerator/blob/master/src/BootstrapBlazor.BarcodeGenerator/BarcodeGeneratorOption.cs)

#### 更新历史


---
#### Blazor 组件

[条码扫描 ZXingBlazor](https://www.nuget.org/packages/ZXingBlazor#readme-body-tab)
[![nuget](https://img.shields.io/nuget/v/ZXingBlazor.svg?style=flat-square)](https://www.nuget.org/packages/ZXingBlazor) 
[![stats](https://img.shields.io/nuget/dt/ZXingBlazor.svg?style=flat-square)](https://www.nuget.org/stats/packages/ZXingBlazor?groupby=Version)

[图片浏览器 Viewer](https://www.nuget.org/packages/BootstrapBlazor.Viewer#readme-body-tab)

[手写签名 SignaturePad](https://www.nuget.org/packages/BootstrapBlazor.SignaturePad#readme-body-tab)

[定位/持续定位 Geolocation](https://www.nuget.org/packages/BootstrapBlazor.Geolocation#readme-body-tab)

[屏幕键盘 OnScreenKeyboard](https://www.nuget.org/packages/BootstrapBlazor.OnScreenKeyboard#readme-body-tab)

[百度地图 BaiduMap](https://www.nuget.org/packages/BootstrapBlazor.BaiduMap#readme-body-tab)

[谷歌地图 GoogleMap](https://www.nuget.org/packages/BootstrapBlazor.Maps#readme-body-tab)

[蓝牙和打印 Bluetooth](https://www.nuget.org/packages/BootstrapBlazor.Bluetooth#readme-body-tab)

[PDF阅读器 PdfReader](https://www.nuget.org/packages/BootstrapBlazor.PdfReader#readme-body-tab)

[文件系统访问 FileSystem](https://www.nuget.org/packages/BootstrapBlazor.FileSystem#readme-body-tab)

[光学字符识别 OCR](https://www.nuget.org/packages/BootstrapBlazor.OCR#readme-body-tab)

[电池信息/网络信息 WebAPI](https://www.nuget.org/packages/BootstrapBlazor.WebAPI#readme-body-tab)

[文件预览 FileViewer](https://www.nuget.org/packages/BootstrapBlazor.FileViewer#readme-body-tab)

[视频播放器 VideoPlayer](https://www.nuget.org/packages/BootstrapBlazor.VideoPlayer#readme-body-tab)

[图像裁剪 ImageCropper](https://www.nuget.org/packages/BootstrapBlazor.ImageCropper#readme-body-tab)

[视频播放器 BarcodeGenerator](https://www.nuget.org/packages/BootstrapBlazor.BarcodeGenerator#readme-body-tab)

#### AlexChow

[今日头条](https://www.toutiao.com/c/user/token/MS4wLjABAAAAGMBzlmgJx0rytwH08AEEY8F0wIVXB2soJXXdUP3ohAE/?) | [博客园](https://www.cnblogs.com/densen2014) | [知乎](https://www.zhihu.com/people/alex-chow-54) | [Gitee](https://gitee.com/densen2014) | [GitHub](https://github.com/densen2014)

