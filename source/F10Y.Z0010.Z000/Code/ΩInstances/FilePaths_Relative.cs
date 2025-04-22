using System;


namespace F10Y.Z0010.Z000
{
    public class FilePaths_Relative : IFilePaths_Relative
    {
        #region Infrastructure

        public static IFilePaths_Relative Instance { get; } = new FilePaths_Relative();


        private FilePaths_Relative()
        {
        }

        #endregion
    }
}
