using System;

using F10Y.T0003;


namespace F10Y.Z0010.Z000
{
    /// <summary>
    /// Prefer use of <see cref="IProjectFilePaths"/> and <see cref="ISolutionFilePaths"/>.
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths
    {
        /// <summary>
        /// <inheritdoc cref="IFileNames.Example_Console_csproj" path="descendant::value" />, in the Files output directory.
        /// </summary>
        public string Example_Console_csproj => Instances.FilesDirectoryOperator.Get_Path_FromFilesDirectoryRelativePath(Instances.FileNames.Example_Console_csproj);
    }
}
