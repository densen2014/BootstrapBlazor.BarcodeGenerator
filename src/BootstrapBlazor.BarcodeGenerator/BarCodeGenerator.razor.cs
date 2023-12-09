// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Diagnostics.CodeAnalysis;

namespace BootstrapBlazor.Components;

/// <summary>
/// 条码生成器 BarCodes
/// </summary>
public partial class BarCodeGenerator : IAsyncDisposable
{
    [Inject]
    [NotNull]
    private IJSRuntime? JS { get; set; }

    private IJSObjectReference? Module { get; set; }
    private DotNetObjectReference<BarCodeGenerator>? objRef;

    /// <summary>
    ///
    /// </summary>
    public ElementReference Element { get; set; }

    /// <summary>
    /// 条码类型/ Barcode type
    /// </summary>
    [Parameter]
    public EnumBarcodeType Type { get; set; } = EnumBarcodeType.CODE128;

    /// <summary>
    /// 条码值/ Barcode value
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// 选项
    /// </summary>
    [Parameter]
    public BarcodeGeneratorOption Options { get; set; } = new();

    /// <summary>
    /// 条码生成(svg)回调方法/ Barcode generated(svg) callback method
    /// </summary>
    [Parameter]
    public Func<string, Task>? OnResult { get; set; }

    /// <summary>
    /// 错误回调方法/Error callback method
    /// </summary>
    [Parameter]
    public Func<string, Task>? OnError { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        try
        {
            if (!firstRender) return;
            objRef = DotNetObjectReference.Create(this);
            Module = await JS.InvokeAsync<IJSObjectReference>("import", "./_content/BootstrapBlazor.BarcodeGenerator/BarCodeGenerator.razor.js" + "?v=" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
            await GenerateBarcode();

        }
        catch (Exception e)
        {
            if (OnError != null) await OnError.Invoke(e.Message);
        }

    }

    //protected override async Task OnParametersSetAsync()
    //{
    //}

    [JSInvokable]
    public async Task GetError(string err)
    {
        if (OnError != null) await OnError.Invoke(err);
    }

    /// <summary>
    /// 生成条码/ Generate barcode
    /// </summary>
    /// <param name="input"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public async Task GenerateBarcode(string? input = null, BarcodeGeneratorOption? options = null)
    {
        if (input != null)
            Value = input;
        if (options != null)
            Options = options;

        if (!string.IsNullOrWhiteSpace(Value))
        {
            try
            {
                Options.Type = Type;
                Options.Value = Value;
                var res = await Module!.InvokeAsync<string>("Gen", objRef, Element, Options);
                if (OnResult != null)
                    await OnResult.Invoke(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    [JSInvokable]
    public async Task GetResult(string err)
    {
        if (OnResult != null)
            await OnResult.Invoke(err);
    }

    async ValueTask IAsyncDisposable.DisposeAsync()
    {
        if (Module is not null)
        {
            await Module.DisposeAsync();
        }
        objRef?.Dispose();
    }

}
