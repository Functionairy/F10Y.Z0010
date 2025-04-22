using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.Z0010.Z000
{
    [FunctionsMarker]
    public partial interface IFilesDirectoryOperator :
        L0001.IFilesDirectoryOperator
    {

#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0001.IFilesDirectoryOperator _F10Y_L0001 => L0001.FilesDirectoryOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public string Get_Path_FromFilesDirectoryRelativePath(string path_FilesDirectoryRelative)
        {
            var output = this.Get_Path_FromFilesDirectoryRelativePath(
                Instances.Values.ProjectName,
                path_FilesDirectoryRelative);

            return output;
        }
    }
}
