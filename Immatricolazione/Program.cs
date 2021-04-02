using System;
using System.Collections.Generic;

namespace Verifica4_Selene
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("IMMATRICOLAZIONE");
            Console.WriteLine("Digita il nome dell'esame: ");
            string nuovoEsame= Console.ReadLine();

            //Inserisco manualmente studentdi di prova
            Studente chris = new Studente(nome: "Chris", cognome: "Bourne", annoDiNascita: 1990,
                richiestaLaurea: false, esamiPassati: [true, false, false, true, false]);
           


            Console.WriteLine(chris.EsamiPassati);



            Console.ReadLine();
        }
    }
}
