using System;
using System.Linq;
using System.Threading.Tasks;

using F10Y.T0006;


namespace F10Y.Z0010.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations
    {
        public async Task Display_CopyToOutputDirectoryFilePath_UsingFilePath()
        {
            /// Inputs.
            var output_TextFilePath =
                Instances.FilePaths.Output_TextFilePath
                ;


            /// Outputs.
            var filePath = Instances.FilePaths.Example_Console_csproj;

            var file_Exists = Instances.FileSystemOperator.Exists_File(filePath);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{filePath}\n\t: output file path")
                .Append($"{file_Exists}\n\t: file exists")
                ;

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }

        public async Task Display_CopyToOutputDirectoryFilePath_UsingFileName()
        {
            /// Inputs.
            var output_TextFilePath =
                Instances.FilePaths.Output_TextFilePath
                ;


            /// Outputs.
            var filePath = Instances.FilesDirectoryOperator.Get_Path_FromFilesDirectoryRelativePath(
                Instances.Values.ProjectName,
                Instances.FileNames.Example_Console_csproj);

            var file_Exists = Instances.FileSystemOperator.Exists_File(filePath);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{filePath}\n\t: output file path")
                .Append($"{file_Exists}\n\t: file exists")
                ;

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }

        public async Task Display_CopyToOutputDirectoryFilePath_UsingRelativePath()
        {
            /// Inputs.
            var output_TextFilePath =
                Instances.FilePaths.Output_TextFilePath
                ;


            /// Outputs.
            var filePath = Instances.ExecutablePathOperator.Get_Path_FromExecutableDirectoryRelativePath(
                    Instances.FilePaths_Relative.Example_Console_RelativeToExecutableDirectory);

            var file_Exists = Instances.FileSystemOperator.Exists_File(filePath);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{filePath}\n\t: output file path")
                .Append($"{file_Exists}\n\t: file exists")
                ;

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }
    }
}
