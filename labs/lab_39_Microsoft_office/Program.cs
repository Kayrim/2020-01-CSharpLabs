using System;
using Xceed.Words.NET;
using System.Diagnostics;
using System.IO;

namespace lab_39_Microsoft_office
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "MicrosoftWordReport.docx";

            var doc = DocX.Create(filename);
            doc.InsertParagraph("This is a Paragraph");
            doc.Save();

            Process.Start("WORD", filename);
        }
    }
}
