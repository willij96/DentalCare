using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCareVg
{
    class Person
    {
        string förNamn;
        string efterNamn;
        string personNummer;
        string telefonNummer;
        string email;

        public Person(string Förnamn, string EfterNamn, string PersonNummer, string  TelefonNummer, string Email)
        {
            förNamn = Förnamn;
            efterNamn = EfterNamn;
            personNummer = PersonNummer;
            telefonNummer = TelefonNummer;
            email = Email;
        }
        public string GetFörNamn()
        {
            return förNamn;
        }
        public string GetEfterNamn()
        {
            return efterNamn;
        }
        public string GetPersonNummer()
        {
            return personNummer;
        }
        public string GetTelefonNummer()
        {
            return telefonNummer;
        }
        public string GetEmail()
        {
            return email;
        }
    }
}
