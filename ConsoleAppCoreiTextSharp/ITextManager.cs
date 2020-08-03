using System;
using System.Collections.Generic;
using System.Text;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace ConsoleAppCoreiTextSharp
{
    class ITextManager
    {
        public void Write(String path,string text)
        {
            // Must have write permissions to the path folder 
            String pat = @"‪Pdf_for_core\mypdf";
            PdfWriter writer = new PdfWriter(pat);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph(text)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            document.Add(header);
            document.Close();
        }
    }
}
