using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorWASM70UnmarshalledJS.JavaScriptInterop
{
    [SupportedOSPlatform("browser")]
    public partial class Interop
    {
        [JSImport("getMessage", "Interop")]
        internal static partial string GetWelcomeMessage();

        [JSImport("setMessage", "Interop")]
        internal static partial void SetWelcomeMessage();

        [JSExport]
        internal static string GetMessageFromDotnet()
        {
            return "Olá do Blazor!";
        }
    }
}
