import '/_content/BootstrapBlazor.BarcodeGenerator/JsBarcode.all.min.js';

export function Gen(instance, element, options) {
    var ele = element.querySelector("[data-action=barcode]");
    JsBarcode(ele, options.value, options);
    return ele.innerHTML// .toDataURL("image/jpeg", 0.8);
}
