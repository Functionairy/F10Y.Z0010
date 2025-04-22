using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0010
{
    [ValuesMarker]
    public partial interface IProjectFileXmlTexts :
        Z001.IProjectFileXmlTexts,
        Z002.IProjectFileXmlTexts
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z001.IProjectFileXmlTexts _Z001 => Z001.ProjectFileXmlTexts.Instance;

        [Ignore]
        public Z002.IProjectFileXmlTexts _Z002 => Z002.ProjectFileXmlTexts.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
