using System;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace ConsoleAppCoreiTextSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ITextManager textManager = new ITextManager();
            textManager.Write(@"Pdf_for_core\mypdf.pdf", "Center Header") ;

            Console.WriteLine("Done!");
        }
    }
}
