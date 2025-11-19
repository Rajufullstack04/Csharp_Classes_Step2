using System;


class PDFFile
{
    //string _filename;
    //string _filelocation;
    //string _filesize;
    //string _createddate;

    public string FileName { get; set; }
    public string FileLocation { get; set; }
    public string FileSize { get; set; }
    public string CreatedDate { get; set; }
}


class PDFFilesSystem
{
    public void ShowPDFFileNamesLength(string[] fileNames)
    {
        //Code here......
    }

    public void PrintEveryPDFFileName(string[] fileNames)
    {
        foreach (string fileName in fileNames)
        {
            Console.WriteLine($"file name is : {fileName}");
        }
    }

    public void PrintEveryPDFFileDetails(PDFFile[] files)
    {
        foreach (PDFFile file in files)
        {
            Console.WriteLine($"file name is : {file.FileName}");
            Console.WriteLine($"file name is : {file.FileSize}");
            Console.WriteLine($"file name is : {file.FileLocation}");
            Console.WriteLine($"file name is : {file.CreatedDate}");
        }
    }

}


class PDFProgram
{

    static void Main()
    {
        PDFFilesSystem pdf = new PDFFilesSystem();

        string[] fileNames = { "PDFFile1.pdf", "PDFFile2.pdf", "PDFFile3.pdf" };
        pdf.ShowPDFFileNamesLength(fileNames);
        pdf.PrintEveryPDFFileName(fileNames);


        //PDFFile pdfFile = new PDFFile();
        //pdfFile.FileName = "CreditcardstatmentMarch.pdf";
        //pdfFile.CreatedDate = "Mar-01-2025";
        //pdfFile.FileSize = "5kb";
        //pdfFile.FileLocation = @"C:/Downloads";

        //string[] fileNames = { "PDFFile1.pdf", "PDFFile2.pdf", "PDFFile3.pdf" };
        string[] fileNames1 = new string[] { "PDFFile1.pdf", "PDFFile2.pdf", "PDFFile3.pdf" };


        PDFFile creditcardstatmentMarch = new PDFFile()
        {
            FileName = "CreditcardstatmentMarch.pdf",
            CreatedDate = "Mar-01-2025",
            FileSize = "5kb",
            FileLocation = @"C:/Downloads"
        };

        PDFFile creditcardstatmentApril = new PDFFile()
        {
            FileName = "CreditcardstatmentApril.pdf",
            CreatedDate = "April-01-2025",
            FileSize = "4kb",
            FileLocation = @"C:/Downloads"
        };

        PDFFile creditcardstatmentMay = new PDFFile()
        {
            FileName = "CreditcardstatmentMay.pdf",
            CreatedDate = "May-01-2025",
            FileSize = "3kb",
            FileLocation = @"C:/Downloads"
        };

        PDFFile[] allCreditCardStatementFiles = new PDFFile[]
        {
            new PDFFile()
                {
                    FileName = "CreditcardstatmentMarch.pdf",
                    CreatedDate = "Mar-01-2025",
                    FileSize = "5kb",
                    FileLocation = @"C:/Downloads"
                },
            new PDFFile()
                {
                    FileName = "CreditcardstatmentApril.pdf",
                    CreatedDate = "April-01-2025",
                    FileSize = "4kb",
                    FileLocation = @"C:/Downloads"
                },
            new PDFFile()
                {
                    FileName = "CreditcardstatmentMay.pdf",
                    CreatedDate = "May-01-2025",
                    FileSize = "3kb",
                    FileLocation = @"C:/Downloads"
                }
          };

        pdf.PrintEveryPDFFileDetails(allCreditCardStatementFiles);

    }

}



