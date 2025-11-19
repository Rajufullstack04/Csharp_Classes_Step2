using System;
using ExcelFilesSystem;
using PPTFileSystem;



namespace MainProgramSystem
{
    class MainProgram
    {
        public static void Main()
        {
            ExcelFilesSystem.Jan_File jan_File_excel = new ExcelFilesSystem.Jan_File();
            Console.WriteLine(jan_File_excel.FileName);

            PPTFileSystem.Jan_File jan_file_pdf = new PPTFileSystem.Jan_File();
            Console.WriteLine(jan_file_pdf.FileName);

        }
    }
}