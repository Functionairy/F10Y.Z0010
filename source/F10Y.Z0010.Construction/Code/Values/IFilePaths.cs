using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0010.Construction
{
    [ValuesMarker]
    public partial interface IFilePaths :
        L0004.IFilePaths,
        Z000.IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0004.IFilePaths _F10Y_L0004 => L0004.FilePaths.Instance;

        [Ignore]
        public Z000.IFilePaths _F10Y_Z0010_Z000 => Z000.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles



    }
}
