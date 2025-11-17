using System;
 class FieldBasics
{
    //Fields are nothting but kind of variables which can hold the values. Value can be anything.


    //static members
    static string fileName = "Ram_Resume.docx";   //filename is a field . string value.
    static string filLocation = @"D:\Students\Resumes";
    static string fileSize = "2kb";
    static string filecreatedDate = "Mar-01-2025";

    static DateTime applyResumeDateAndTime = DateTime.Now;

    static void ShowMessage(string filename, string filelocation)
    {
        //filename 
        Console.WriteLine($"Hello, File name is {fileName} and file location is {filelocation}");
    }



    static void Main(string[] args)
    {
        string studentFileName = FieldBasics.fileName;
        //Console.WriteLine(studentFileName);

        string studentFileLocation = FieldBasics.filLocation;

        DateTime Apply = FieldBasics.applyResumeDateAndTime;
        //Console.WriteLine(Apply);

        FieldBasics.ShowMessage(studentFileName, studentFileLocation);



    }
}