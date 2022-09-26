using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

[SupportedOSPlatform("browser")]
public partial class Interop2
{
    [JSImport("setMessage", "Interop2")]
    internal static partial void SetWelcomeMessage();

    [JSExport]
    internal static string GetMessageFromDotnet()
    {
        return "¡Hola desde Blazor!";
    }
}
