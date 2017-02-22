using System;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XmlExample
{
    [Serializable]
    public class Konfiguracja
    {

        #region pola z danymi konfiguracyjnymi

        //tak to powinno wyglądać, ale kod staje się mniej czytelny...
        private string _PytanieWyciagajace; 
        public string PytanieWyciagajace
        {
            get { return _PytanieWyciagajace; }


            set { 
                _PytanieWyciagajace = value;
                if (_PytanieWyciagajace == ""|| _PytanieWyciagajace == null) 
                    _PytanieWyciagajace = "Auuć! Nie będzie ułatwień na kole!";  
            }
        }

        //...dlatego uprościmy sobie życie:
        public int PoziomTrudnosci;
        public bool WlasneMaterialy;
        public bool ZaliczenieZaObecnosc;
        public DateTime TerminKolokwium;
        public string CzasPisania;

        #endregion 

        #region serializacja i deserializacja XML
        
        public static void Serialize(string file, Konfiguracja c)
        {
            System.Xml.Serialization.XmlSerializer xs 
                = new System.Xml.Serialization.XmlSerializer(c.GetType());
            XmlWriter writer = XmlWriter.Create(file);
            xs.Serialize(writer, c);
            writer.Flush();
            writer.Close();
        }
        public static Konfiguracja Deserialize(string file)
        {
            System.Xml.Serialization.XmlSerializer xs
               = new System.Xml.Serialization.XmlSerializer(typeof(Konfiguracja));
            XmlReader reader = XmlReader.Create(file);
            Konfiguracja c = (Konfiguracja)xs.Deserialize(reader);
            reader.Close();
            return c;
        }

        #endregion
    }
}
