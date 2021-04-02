using System;

namespace Verifica4_SeleneT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("IMMATRICOLAZIONE");
            Console.WriteLine("Digita il nome dell'esame: ");
            string nuovoEsame = Console.ReadLine();

            //creo dei corsi/esami manualmente
            Corso analisi1 = new Corso("Analisi1", 12);
            Corso letteratura = new Corso("Letteratura", 6);
            Corso fisica = new Corso("Fisica", 12);
            Corso programmazione = new Corso("Programmazione", 8);
            Corso elettrotecnica = new Corso("Elettrotecnica", 8);
            Corso inglese = new Corso("Inglese", 3);

            //creo i corsi di laurea a cui associare gli esami
            CorsoDiLaurea lettere = new CorsoDiLaurea(NCL.Lettere, 5, 40);
            CorsoDiLaurea informatica = new CorsoDiLaurea(NCL.Informatica, 4, 40);
            CorsoDiLaurea ingegneria = new CorsoDiLaurea(NCL.Ingegneria, 5, 40);

            //Nella fase di immatricolazione devo associare l'esame al corso di laurea
            Immatricolazione immatric1 = new Immatricolazione(DateTime.Today, lettere);
            Immatricolazione immatric2 = new Immatricolazione(DateTime.Today, informatica);
            Immatricolazione immatric3 = new Immatricolazione(DateTime.Today, ingegneria);
        

            //Inserisco manualmente degli studenti. Ad ognuno oltre ai dati anagrafici è associato il codice di immatricolazione
            //riportato durante l'immatricolazione
            Studente chris = new Studente(nome: "Chris", cognome: "Bourne", annoDiNascita: 1990, richiestaLaurea: false,immatric1 );
            Studente nick = new Studente(nome: "Nicole", cognome: "Argent", annoDiNascita: 1989, richiestaLaurea: false, immatric2);
            Studente adri = new Studente(nome: "Adrien", cognome: "Sofi", annoDiNascita: 1994, richiestaLaurea: true, immatric3);



            //Console.WriteLine($"{chris.Nome} {chris.Cognome} ");
            Console.ReadLine();
        }
    }
}
