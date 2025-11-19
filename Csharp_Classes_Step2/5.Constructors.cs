using System;
class FileDetailsConstructors
{

    string filename = "Student1_Resume.docx";
    string filelocation = @"D:\Students\Resumes";
    string filesize = "2Kb";
    string createddate = "Mar-01-2024";
    DateTime createdDateTime = DateTime.Now;


    public FileDetailsConstructors()
    {
        ///Code here..
        ///
        Console.WriteLine("File object created");
        Console.WriteLine(this.filename); // "Student1_Resume.docx"

        this.filename = "Sam_reusme.docx";

    }

    static void Main()
    {
        FileDetailsConstructors file1 = new FileDetailsConstructors();

        //Note : i have changed the filename inside of the constrcutor.

        Console.WriteLine(file1.filename);  //Sam_reusme.docx
    }




}

