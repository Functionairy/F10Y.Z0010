using System;

using F10Y.T0003;


namespace F10Y.Z0010.Z001
{
    [ValuesMarker]
    public partial interface ISolutionFileTexts
    {
        public string Example =>
@"
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.32002.261
MinimumVisualStudioVersion = 10.0.40219.1
Global
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {87F5C35A-2103-4408-870A-230870B62966}
	EndGlobalSection
EndGlobal
";
    }
}
