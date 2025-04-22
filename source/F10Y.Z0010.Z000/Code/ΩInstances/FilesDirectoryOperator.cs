using System;


namespace F10Y.Z0010.Z000
{
    public class FilesDirectoryOperator : IFilesDirectoryOperator
    {
        #region Infrastructure

        public static IFilesDirectoryOperator Instance { get; } = new FilesDirectoryOperator();


        private FilesDirectoryOperator()
        {
        }

        #endregion
    }
}
