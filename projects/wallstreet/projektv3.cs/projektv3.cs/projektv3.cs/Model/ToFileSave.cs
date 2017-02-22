using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using FormHello.cs.Controller;
using System.Xml;

namespace FormHello.cs
{
    public static class ToFileSave
    {
        #region Zapisywanie notowań do pliku PDF.
        internal static void PdfSave(List<ThreadsTimer.Interest[]> interestList)
        {
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream("D:\\Notowania.pdf", FileMode.Create));
            document.Open();
            for (int i = 0; i < interestList.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Paragraph line = new Paragraph(interestList[i][j].nameOfInterst + " o wartosci: " + interestList[i][j].valueOfInterest + "przy zmianie o :" + interestList[i][j].percentOfInterest);
                    document.Add(line);
                }
            }
            document.Close();
            Comunicats.GeneratePDF();
        }
        #endregion
        #region Generowanie pliku XML. W ramach dodatkowej nauki.
        public static void XmlSave(decimal saldo)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("D:\\portfel.xml", null);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.Indentation = 4;//wcięcia w kodzie
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Users");
            xmlWriter.WriteStartElement("User1");
            xmlWriter.WriteString("Stan portfela:" + saldo);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            Comunicats.GenerateXML();
        }
        #endregion
    }
}
