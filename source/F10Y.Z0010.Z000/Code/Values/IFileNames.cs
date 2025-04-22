using System;

using F10Y.T0003;


namespace F10Y.Z0010.Z000
{
    [ValuesMarker]
    public partial interface IFileNames
    {
        /// <summary>
        /// <para><value>Example_Console.csproj</value></para>
        /// </summary>
        public string Example_Console_csproj => "Example_Console.csproj";

        /// <summary>
        /// <para><value>Example_Library.csproj</value></para>
        /// </summary>
        public string Example_Library_csproj => "Example_Library.csproj";
    }
}
