using System;


namespace F10Y.Z0010.Z000
{
    public class SolutionFilePaths : ISolutionFilePaths
    {
        #region Infrastructure

        public static ISolutionFilePaths Instance { get; } = new SolutionFilePaths();


        private SolutionFilePaths()
        {
        }

        #endregion
    }
}
