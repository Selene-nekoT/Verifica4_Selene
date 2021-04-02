using System;
using System.Collections.Generic;
using System.Text;

namespace Verifica4_SeleneT
{
    public class Studente
    {
        //Lista studenti inserita per archiviare i record
        private List<Studente> _studenti = new List<Studente>();

        //Inserisco le proprietà della classe studente
        public string Nome { get; }
        public string Cognome { get; }
        public int AnnoDiNascita { get;}
        public bool RichiestaLaurea { get; set; }
        
        //METODO: associo un array assumendo che ogni studente abbia esattamente 3 esami da dare per potersi laureare
        //ad ogni indice corrisponde un esame da passare (inizialmente sono tutti FALSE)
        public bool[] EsamiPassati() {
            bool[] esamipassati = new bool[] { false, false, false };
            return esamipassati;
;        }

        //Costruttore dello Studente
        public Studente(string nome, string cognome, int annoDiNascita, bool richiestaLaurea)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
            RichiestaLaurea = richiestaLaurea;
            _matricola;
        }


        public void Immatricolazione()
        {
            throw new System.NotImplementedException();
        }
    }
}