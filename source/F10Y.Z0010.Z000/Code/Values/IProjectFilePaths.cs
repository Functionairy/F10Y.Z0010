using System;

using F10Y.T0003;


namespace F10Y.Z0010.Z000
{
    [ValuesMarker]
    public partial interface IProjectFilePaths
    {
        /// <inheritdoc cref="IFilePaths.Example_Console_csproj"/>
        public string Example_Console => Instances.FilePaths.Example_Console_csproj;

        /// <summary>
        /// <inheritdoc cref="IFileNames.Example_Library_csproj" path="descendant::value" />, in the Files output directory.
        /// </summary>
        public string Example_Library => Instances.FilesDirectoryOperator.Get_Path_FromFilesDirectoryRelativePath(Instances.FileNames.Example_Library_csproj);
    }
}
