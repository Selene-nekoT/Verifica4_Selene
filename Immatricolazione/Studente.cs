using System;
using System.Collections.Generic;
using System.Text;

namespace Verifica4_Selene
{
    public class Studente
    {
        //Lista studenti inserita per archiviare i record
        private List<Studente> _studenti = new List<Studente>();

        //Inserisco le proprietà della classe studente
        public string Nome { get;} 
        public string Cognome { get;} 
        public int AnnoDiNascita { get; set; } 
        public bool RichiestaLaurea { get; set; } 
        
        //associo un array assumendo che ogni studente abbia esattamente 5 esami da dare per potersi laureare
        //ad ogni indice corrisponde un esame da passare (inizialmente sono tutti FALSE)
        public bool[] EsamiPassati { get; set; }

        //Costruttore dello Studente
        public Studente(string nome, string cognome, int annoDiNascita, bool richiestaLaurea, bool [] esamiPassati )
        {
            Nome = nome; 
            Cognome = cognome; 
            AnnoDiNascita = annoDiNascita; 
            RichiestaLaurea = richiestaLaurea; 
            EsamiPassati = new bool[5] { false, false, false, false, false };
        }
        

        public void Immatricolazione()
        {
            throw new System.NotImplementedException();
        }
    }
}