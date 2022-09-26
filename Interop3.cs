using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

[SupportedOSPlatform("browser")]
public partial class Interop3
{
    [JSImport("getMessage", "Interop3")]
    internal static partial string GetWelcomeMessage();

    [JSImport("setMessage", "Interop3")]
    internal static partial void SetWelcomeMessage();

    [JSExport]
    internal static string GetMessageFromDotnet()
    {
        return "¡Hola desde Blazor!";
    }
}
