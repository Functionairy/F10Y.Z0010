using System;


namespace F10Y.Z0010.Z001
{
    public class SolutionFileTexts : ISolutionFileTexts
    {
        #region Infrastructure

        public static ISolutionFileTexts Instance { get; } = new SolutionFileTexts();


        private SolutionFileTexts()
        {
        }

        #endregion
    }
}
