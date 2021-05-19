using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCareVg
{
    class Patient : Person
    {
        public Patient(string Förnamn, string EfterNamn, string PersonNummer, string TelefonNummer, string Email) 
            : base(Förnamn, EfterNamn, PersonNummer, TelefonNummer, Email)
        {

        }
    }
}
