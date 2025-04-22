using System;


namespace F10Y.Z0010.Z000
{
    public class ProjectFilePaths : IProjectFilePaths
    {
        #region Infrastructure

        public static IProjectFilePaths Instance { get; } = new ProjectFilePaths();


        private ProjectFilePaths()
        {
        }

        #endregion
    }
}
