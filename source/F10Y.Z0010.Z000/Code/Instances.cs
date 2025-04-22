using System;


namespace F10Y.Z0010.Z000
{
    public static class Instances
    {
        public static L0000.IExecutablePathOperator ExecutablePathOperator => L0000.ExecutablePathOperator.Instance;
        public static IFileNames FileNames => Z000.FileNames.Instance;
        public static IFilePaths FilePaths => Z000.FilePaths.Instance;
        public static IFilesDirectoryOperator FilesDirectoryOperator => Z000.FilesDirectoryOperator.Instance;
        public static IValues Values => Z000.Values.Instance;
    }
}