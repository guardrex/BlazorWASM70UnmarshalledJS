export async function setMessage() {
  const { getAssemblyExports } = await globalThis.getDotnetRuntime(0);
  var exports = await getAssemblyExports("BlazorWASM70UnmarshalledJS.dll");

  document.getElementById("result").innerText = 
    exports.Interop2.GetMessageFromDotnet();
}
