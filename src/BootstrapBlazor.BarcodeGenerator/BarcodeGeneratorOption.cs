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
    /// 条码类型 / Barcode type
    /// </summary>
    [DisplayName("条码类型")]
    [JsonConverter(typeof(JsonStringEnumConverter)), JsonPropertyName("format")]
    public EnumBarcodeType Type { get; set; } = EnumBarcodeType.CODE128;

    /// <summary>
    /// 条码值 / Barcode value
    /// </summary>
    [DisplayName("条码值")]
    public string? Value { get; set; }

    /// <summary>
    /// 单个条形的宽度,默认值：2 / Width,default: 2
    /// </summary>
    [DisplayName("宽度")]
    [Range(1, 4)]
    public int Width { get; set; } = 2;

    /// <summary>
    /// 条形码的高度,默认值：100 / Height,default: 100
    /// </summary>
    [DisplayName("高度")]
    [Range(10, 150)]
    public int Height { get; set; } = 100;

    /// <summary>
    /// 显示文字,默认 true
    /// </summary>
    [DisplayName("显示文字")]
    [JsonPropertyName("displayValue")]
    public bool ShowText { get; set; } = true;

    /// <summary>
    /// 覆盖显示的文本/ Overide the text that is diplayed
    /// </summary>
    [DisplayName("覆盖显示的文本")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Text { get; set; }

    /// <summary>
    /// 字体式样
    /// </summary>
    [DisplayName("字体式样")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EnumBarcodeFontOption FontOption { get; set; }= EnumBarcodeFontOption.Normal;

    /// <summary>
    /// 文字对齐,默认值：“中心”
    /// </summary>
    [DisplayName("文字对齐")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EnumBarcodeTextAlign TextAlign { get; set; } = EnumBarcodeTextAlign.Center;

    /// <summary>
    /// 文字位置,默认值：“底部”
    /// </summary>
    [DisplayName("文字位置")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EnumTextPosition TextPosition { get; set; } = EnumTextPosition.Bottom;

    /// <summary>
    /// 文本边距,默认值：2
    /// </summary>
    [DisplayName("文字间距")]
    [Range(15, 40)]
    public int TextMargin { get; set; } = 0;

    /// <summary>
    /// 字体大小,默认值：20
    /// </summary>
    [DisplayName("字体大小")]
    [Range(8, 36)]
    public int FontSize { get; set; } = 20;

    /// <summary>
    /// 背景色,默认值：“#ffffff”
    /// </summary>
    [DisplayName("背景色")]
    public string Background { get; set; }= "#FFFFFF";

    /// <summary>
    /// 线条颜色,默认值：“#000000”
    /// </summary>
    [DisplayName("线条颜色")]
    public string LineColor { get; set; }= "#000000";

    /// <summary>
    /// 间距,默认值：10
    /// </summary>
    [DisplayName("间距")]
    [Range(0, 25)]
    public int Margin { get; set; } = 10;

    /// <summary>
    /// 顶部间距,默认值：undefined
    /// </summary>
    [DisplayName("顶部间距")]
    [Range(15, 40)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginTop { get; set; }

    /// <summary>
    /// 底部间距,默认值：undefined
    /// </summary>
    [DisplayName("底部间距")]
    [Range(15, 40)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginBottom { get; set; }

    /// <summary>
    /// 左边间距,默认值：undefined
    /// </summary>
    [DisplayName("左边间距")]
    [Range(15, 40)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginLeft { get; set; }

    /// <summary>
    /// 右边间距,默认值：undefined
    /// </summary>
    [DisplayName("右边间距")]
    [Range(15, 40)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginRight { get; set; }

    /// <summary>
    /// 字体,默认值："monospace"等宽 / default: "monospace"
    /// </summary>
    [DisplayName("字体")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EnumBarcodeFont Font { get; set; }= EnumBarcodeFont.Monospace;

    /// <summary>
    /// 仅适用于 EAN8/EAN13 / Only for EAN8/EAN13
    /// </summary>
    [DisplayName("显示文字")] 
    public bool Flat { get; set; } 


}
