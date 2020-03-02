using System;
using Xceed.Words.NET;
using System.Diagnostics;

namespace lab_40_Microsoft_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fileName = "MicrosoftWordReport.docx";

            var doc = DocX.Create(fileName);

            doc.InsertParagraph("This is a Microsoft Word Report");

            doc.InsertParagraph("This contains test report data");

            doc.InsertParagraph("5 tests have passed and 2 have failed");

            doc.Save();

            //Process.Start(@"C:\Program Files(x86)\Microsoft Office\root\Office16\WINWORD.EXE", fileName);
            //Process.Start("WINWORD.EXE", fileName);
        }
    }
}
