// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BootstrapBlazor.Components;

/// <summary>
/// 条码生成器选项
/// </summary>
public class BarcodeGeneratorOption
{
    /// <summary>
    /// 条码类型/ Barcode type
    /// </summary>
    [DisplayName("条码类型")]
    [JsonConverter(typeof(JsonStringEnumConverter)), JsonPropertyName("format")]
    public EnumBarcodeType Type { get; set; } = EnumBarcodeType.CODE128;

    /// <summary>
    /// 条码值/ Barcode value
    /// </summary>
    [DisplayName("条码值")]
    public string? Value { get; set; }

    /// <summary>
    /// 宽度
    /// </summary>
    [DisplayName("宽度")]
    [Range(1, 4)]
    public int Width { get; set; } = 2;

    /// <summary>
    /// 高度
    /// </summary>
    [DisplayName("高度")]
    [Range(10, 150)]
    public int Height { get; set; } = 100;

    /// <summary>
    /// 间距
    /// </summary>
    [DisplayName("间距")]
    [Range(0, 25)]
    public int Margin { get; set; } = 10;

    /// <summary>
    /// 背景色
    /// </summary>
    [DisplayName("背景色")]
    public string Background { get; set; }= "#FFFFFF";

    /// <summary>
    /// 线条颜色
    /// </summary>
    [DisplayName("线条颜色")]
    public string LineColor { get; set; }= "#000000";

    /// <summary>
    /// 显示文字,默认 true
    /// </summary>
    [DisplayName("显示文字")]
    [JsonPropertyName("displayValue")]
    public bool ShowText { get; set; } = true;

    /// <summary>
    /// 文字对齐
    /// </summary>
    [DisplayName("文字对齐")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EnumBarcodeTextAlign TextAlign { get; set; } = EnumBarcodeTextAlign.Center;

    /// <summary>
    /// 字体
    /// </summary>
    [DisplayName("字体")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EnumBarcodeFont Font { get; set; }= EnumBarcodeFont.Monospace;


    /// <summary>
    /// 字体式样
    /// </summary>
    [DisplayName("字体式样")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EnumBarcodeFontOption FontOption { get; set; }= EnumBarcodeFontOption.Bold;

    /// <summary>
    /// 字体大小
    /// </summary>
    [DisplayName("字体大小")]
    [Range(8, 36)]
    public int FontSize { get; set; } = 20;

    /// <summary>
    /// 文字间距
    /// </summary>
    [DisplayName("文字间距")]
    [Range(15, 40)]
    public int TextMargin { get; set; } = 0;

    
}
