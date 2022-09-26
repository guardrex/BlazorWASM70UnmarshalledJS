using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

[SupportedOSPlatform("browser")]
public partial class Interop1
{

    [JSImport("getMessage", "Interop1")]
    internal static partial string GetWelcomeMessage();
}
