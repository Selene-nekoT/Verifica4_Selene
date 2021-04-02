using System;
using System.Collections.Generic;
using System.Text;

namespace Verifica4_SeleneT
{
    class Immatricolazione
    {
        //Matricola autoincrementata ogni volta che creo un'associazione
        public static int _matricola = 0;
        public int Matricola { get; }

        //Quando istanzio questa classe sto iscrivendo un nuovo studente(generico) ad un esame
        //associo successivamente il codice generato allo studente

        public DateTime DataEsame { get; set; }
        public string CorsoDiLaurea { get; set; }
        public Immatricolazione(DateTime dataesame, string corsoDiLaurea)
        {
            dataesame = DataEsame;
            corsoDiLaurea = CorsoDiLaurea;
            Matricola = ++_matricola;
        }
    }
}
