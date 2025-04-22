using System;


namespace F10Y.Z0010.Z001
{
    public class ProjectFileXmlTexts : IProjectFileXmlTexts
    {
        #region Infrastructure

        public static IProjectFileXmlTexts Instance { get; } = new ProjectFileXmlTexts();


        private ProjectFileXmlTexts()
        {
        }

        #endregion
    }
}
