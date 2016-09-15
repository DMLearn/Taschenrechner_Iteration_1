﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        //Damit der view Zugriff auf die Klasse model hat, wird ein Attribut model angelegt 
        private RechnerModel model;

        //Konstruktur
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }

        public void HoleEingabenVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBeutzer();
            model.Operation = HoleOperatorVomBeutzer();
            model.ZweiteZahl = HoleZahlVomBeutzer();
        }

        private double HoleZahlVomBeutzer()
        {
            string zahl;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            zahl = Console.ReadLine();

            return Convert.ToDouble(zahl);
        }

        private string HoleOperatorVomBeutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+ - * /): ");
            return Console.ReadLine();
        }

        public string WarteAufEndeDurchBenutzer()
        {
            Console.Write("-------------------------------------\nZum Beenden bitte eine Taste drücken!");
            return Console.ReadLine();
        }
      
        /// <summary>
        /// Ausgabe des Ergebniss
        /// </summary>
        /// <param name="resultat"></param>
        /// <param name="operation"></param>
        public void GibResultatAus()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;
                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;
                case "/":
                    Console.WriteLine("Der Quotient ist: {0}", model.Resultat);
                    break;
                default:
                    Console.WriteLine("Du hast eine ungültige Operation ausgewählt!");
                    break;
            }
        }   
    }
}
