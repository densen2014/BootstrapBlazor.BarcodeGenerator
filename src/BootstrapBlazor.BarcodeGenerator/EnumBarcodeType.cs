// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using System.ComponentModel;

namespace BootstrapBlazor.Components;

/// <summary>
/// 条码类型
/// </summary>
public enum EnumBarcodeType
{
    CODE128,
    CODE128A,
    CODE128B,
    CODE128C,
    EAN13,
    EAN8,
    EAN5,
    EAN2,
    UPC,
    CODE39,
    ITF14,
    ITF,
    MSI,
    MSI10,
    MSI11,
    MSI1010,
    MSI1110,
    pharmacode,
}

public enum EnumBarcodeTextAlign
{
    Left,
    Center,
    Right,
}

public enum EnumBarcodeFont
{
    Monospace,
    SansSerif,
    Serif,
    Fantasy,
    Cursive,
}

public enum EnumBarcodeFontOption
{
    Bold,
    Italic,
}
