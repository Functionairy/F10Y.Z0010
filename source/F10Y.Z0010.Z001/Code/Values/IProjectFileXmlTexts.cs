using System;

using F10Y.T0003;


namespace F10Y.Z0010.Z001
{
    [ValuesMarker]
    public partial interface IProjectFileXmlTexts
    {
        /// <summary>
        /// A simple console file.
        /// </summary>
        public string Example_Console =>
@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>

</Project>";
    }
}
