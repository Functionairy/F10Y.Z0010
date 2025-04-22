using System;
using System.Threading.Tasks;


namespace F10Y.Z0010.Construction
{
    class Program
    {
#pragma warning disable IDE1006 // Naming Styles

        static async Task Main()
        {
            await _Demonstrations();
        }

        static async Task _Demonstrations()
        {
            await Demonstrations.Instance.Display_CopyToOutputDirectoryFilePath_UsingFilePath();
            //await Demonstrations.Instance.Display_CopyToOutputDirectoryFilePath_UsingFileName();
            //await Demonstrations.Instance.Display_CopyToOutputDirectoryFilePath_UsingRelativePath();
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}