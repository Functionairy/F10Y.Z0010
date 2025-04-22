using System;

using F10Y.T0003;


namespace F10Y.Z0010.Z000
{
    /// <summary>
    /// Prefer use of <see cref="IFilePaths"/>, with <see cref="IFileNames"/> and <see cref="IFilesDirectoryOperator.Get_Path_FromFilesDirectoryRelativePath(string)"/>.
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths_Relative
    {
        /// <summary>
        /// <para><value>Files\F10Y.Z0010.Z000\Example_Console.csproj</value></para>
        /// </summary>
        public string Example_Console_RelativeToExecutableDirectory => @"Files\F10Y.Z0010.Z000\Example_Console.csproj";
    }
}
