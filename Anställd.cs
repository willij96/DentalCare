using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCareVg
{
    class Anställd : Person
    {
        string id;
        decimal lön;

        public Anställd(string Förnamn, string EfterNamn, string PersonNummer, string TelefonNummer, string Email, string Id, decimal Lön) 
            : base(Förnamn, EfterNamn, PersonNummer, TelefonNummer, Email)
        {
            Id = id;
            Lön = lön;
        }
        public string GetId()
        {
            return id;
        }
        public decimal GetLön()
        {
            return lön;
        }
    }
}
