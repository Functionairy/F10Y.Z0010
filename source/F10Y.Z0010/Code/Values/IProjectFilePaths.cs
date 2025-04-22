using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0010
{
    [ValuesMarker]
    public partial interface IProjectFilePaths :
        Z000.IProjectFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z000.IProjectFilePaths _Z000 => Z000.ProjectFilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
