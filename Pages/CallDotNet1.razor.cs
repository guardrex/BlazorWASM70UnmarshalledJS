using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorWASM70UnmarshalledJS.Pages
{
    [SupportedOSPlatform("browser")]
    public partial class CallDotNet1
    {
        [JSImport("setMessage", "CallDotNet1")]
        internal static partial void SetWelcomeMessage();

        [JSExport]
        internal static string GetMessageFromDotnet()
        {
            return "¡Hola desde Blazor!";
        }
    }
}
