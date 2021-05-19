using DentalCareVg;
using System;
using static System.Console;

namespace DentalCare
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservartion[] patients = new Reservartion[100];
            Anställd[] anställda = new Anställd[100];
            
            bool shouldNotExit = true;
            int patientCounter = 0;
            int anställdCounter = 0;

            while (shouldNotExit)
            {
                WriteLine("1. Skapa bokning");
                WriteLine("2. Lista bokningar");
                WriteLine("3. Registrera kund");
                WriteLine("4. Registrera anställd");
                WriteLine("5. Lista anställda");
                WriteLine("6. Avsluta");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:


                        Write("Kund (Personnummer): ");
                        string personNummer = ReadLine();

                        WriteLine();

                        Write("Anledning: ");
                        string anledning = ReadLine();

                        WriteLine();

                        Write("Utförs av (ID): ");
                        string tandläkare = ReadLine();

                        Write("Datum (yyyy-mm-dd hh:mm): ");
                        DateTime datum = Convert.ToDateTime(ReadLine());

                        WriteLine();

                        WriteLine("Är detta rätt? (J)a (N)ej");
                        keyPressed = ReadKey(true);

                        if(keyPressed.Key == ConsoleKey.Y)
                        {
                            continue;
                        }

                        Reservartion patient = new Reservartion(personNummer, anledning, tandläkare, datum);

                        patients[patientCounter++] = patient;


                        break;


                    case ConsoleKey.D2:

                        WriteLine("Patient\t\t\t\t Anledning\t  Tid");
                        WriteLine("-------------------------------------------------------");

                        foreach (Reservartion patient1 in patients)
                        {
                            if (patient1 == null) continue;

                            {
                                WriteLine($"{patient1.GetfullName()}, {patient1.GetpersonNummer()}, {patient1.Getanledning()}, {patient1.GetDatum()}");
                            }
                        }

                        ReadKey();

                        break;

                    case ConsoleKey.D3:

                        Write("Förnamn: ");
                        string förNamn = ReadLine();

                        Write("Efternamn: ");
                        string efterNamn = ReadLine();

                        Write("Personnummer: ");
                        string personNummer1 = ReadLine();

                        Write("Telefonnummer: ");
                        string telefonNummer = ReadLine();

                        Write("E-mail: ");
                        string email = ReadLine();

                        Patient patientGrid = new Patient(förNamn, efterNamn, personNummer1, telefonNummer, email);

                        break;

                    case ConsoleKey.D4:

                        Write("Förnamn: ");
                        string förnamnAnställd = ReadLine();

                        Write("Efternamn: ");
                        string efternamnAnställd = ReadLine();

                        Write("Personnummer: ");
                        string personNummerAnställd = ReadLine();

                        Write("Telefonnummer: ");
                        string telefonNummerAnställd = ReadLine();

                        Write("E-mail: ");
                        string emailAnställd = ReadLine();

                        WriteLine();

                        Write("ID: ");
                        string idAnställd = ReadLine();

                        Write("Lön: ");
                        decimal lön = decimal.Parse(ReadLine());

                        WriteLine();

                        WriteLine("(1) Tandläkare  (2) Tandhygienist");
                        
                        //if (keyPressed.Key == ConsoleKey.D1)
                        //{
                        //    WriteLine("Roll: 1");
                        //}
                        //else if (keyPressed.Key == ConsoleKey.D2)
                        //{
                        //    WriteLine("Roll: 2");
                        //}

                        WriteLine();

                        WriteLine("Är detta korrekt? (J)a (N)ej");
                        bool validKeyPressed;
                        do
                        {
                            ConsoleKeyInfo keyPressed1 = ReadKey(true);
                            validKeyPressed = keyPressed1.Key == ConsoleKey.J ||
                                              keyPressed1.Key == ConsoleKey.N;
                        }
                        while (!validKeyPressed);
                        WriteLine("Du tryckte på J eller N");

                        Anställd enAnställd = new Anställd(förnamnAnställd, efternamnAnställd, personNummerAnställd, telefonNummerAnställd, emailAnställd, idAnställd, lön);

                        anställda[anställdCounter++] = enAnställd;

                        ReadKey();

                        break;

                    case ConsoleKey.D5:

                        WriteLine("Anställd\t\t\t ID");
                        WriteLine("-----------------------------------------------");

                        foreach (Anställd anställd in anställda)
                        {
                            if (anställd == null) continue;
                            {
                                WriteLine($"{anställd.GetFörNamn()} {anställd.GetEfterNamn()}, {anställd.GetId()}");

                            }
                        }

                        ReadKey();

                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }

        }
    }
}
