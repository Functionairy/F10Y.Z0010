using System;

using F10Y.T0003;


namespace F10Y.Z0010.Z002
{
    [ValuesMarker]
    public partial interface IProjectFileXmlTexts
    {
#pragma warning disable IDE1006 // Naming Styles

        private static Z0000.IXmlTexts _XmlTexts => Z0000.XmlTexts.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <inheritdoc cref="Z0000.IXmlTexts.Example_01"/>
        public string Example => _XmlTexts.Example_01;

        /// <inheritdoc cref="Z0000.IXmlTexts.Example_02"/>
        public string Example_WithNonStandardFormatting => _XmlTexts.Example_02;
    }
}
