using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenraten
{
    internal class ZahlenratenGUI
    {
        public void Ratezahl()
        {
            int maxZahl = MaxZahlenEingeben();
            RateLogik NC = new RateLogik(maxZahl);
            NC.DenkeNeueZahl();
            int resultat = 1;
            do
            {
                int versuch = GerateneZahlEingeben();
                resultat = NC.RateZahl(versuch);
                switch (resultat)
                {
                    case int n when n > 0:
                        Console.WriteLine("Ihre Zahl ist zu klein, versuche es mit einer grösseren.");
                        break;
                    case int n when n < 0:
                        Console.WriteLine("Ihre Zahl ist zu grosss, versuche es mit einer kleineren ");
                        break;
                    case 0:
                        Console.WriteLine("Du hast gewonnen, du hast gewonnwn, Glückwunsch!!!");
                        break;
                    default:
                        Console.WriteLine("Fehler, ALARM, ALARM");
                        break;
                }
            }
            while (resultat != 0);
        }




        private int MaxZahlenEingeben()
        {
            Console.WriteLine("Geben Sie die Maximale Zahl ein");
                int maxZahl = 0;
            while (maxZahl == 0)
            {
                try
                {
                    string userEingabe = Console.ReadLine();
                    maxZahl = int.Parse(userEingabe);
                }
                catch
                {
                    Console.WriteLine("Geben sie Bitte eine Zahl ein, probiere es nochmals");
                }
            }
            return maxZahl;

        }

        private int GerateneZahlEingeben()
        {
            Console.WriteLine("Erraten Sie die Zahl");
            int errrateneZahl = 0;
            while (errrateneZahl == 0)
            { try
                {
                    string userEingabe = Console.ReadLine();
                    errrateneZahl = int.Parse(userEingabe);
                }

                catch
                {
                    Console.WriteLine("Fehleingabe, versuchen Sie es nochmal.");

                }
            }
            return errrateneZahl;
        }


    }
}









  
