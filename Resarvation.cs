using System;
using System.Collections.Generic;
using System.Text;
namespace DentalCare
{
    class Reservartion
    {
        string förNamn;
        string efterNamn;
        string personNummer;
        string telefonNummer;
        string eMail;
        string anledning;
        string tandLäkare;
        DateTime datum;
        public Reservartion(string personNummer, string anledning, string tandLäkare, DateTime datum)
        {
            
            this.personNummer = personNummer;
            this.anledning = anledning;
            this.tandLäkare = tandLäkare;
            this.datum = datum;
        }
        
        public string GetfullName()
        {
            return förNamn + "" + efterNamn;
        }
        public string GetpersonNummer()
        {
            return personNummer;
        }
        public string GettelefonNummer()
        {
            return telefonNummer;
        }
        public string GeteMail()
        {
            return eMail;
        }
        public string Getanledning()
        {
            return anledning;
        }
        public string GettandLäkare()
        {
            return tandLäkare;
        }
        public DateTime GetDatum()
        {
            return datum;
        }
    }
}