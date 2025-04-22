using System;


namespace F10Y.Z0010.Construction
{
    public static class Instances
    {
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.IExecutablePathOperator ExecutablePathOperator => L0000.ExecutablePathOperator.Instance;
        public static L0001.IFilesDirectoryOperator FilesDirectoryOperator => L0001.FilesDirectoryOperator.Instance;
        public static Z000.IFileNames FileNames => Z000.FileNames.Instance;
        public static L0000.IFileOperator FileOperator => L0000.FileOperator.Instance;
        public static IFilePaths FilePaths => Construction.FilePaths.Instance;
        public static L0000.IFileSystemOperator FileSystemOperator => L0000.FileSystemOperator.Instance;
        public static Z000.IFilePaths_Relative FilePaths_Relative => Z000.FilePaths_Relative.Instance;
        public static L0019.INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
        public static Z000.IValues Values => Z000.Values.Instance;
    }
}