using System;
using System.Collections.Generic;
using System.Text;

namespace Verifica4_SeleneT
{
    public enum NCL
    {
        Matematica, 
        Fisica, 
        Ingegneria, 
        Lettere,
        Informatica
    }
    class CorsoDiLaurea
    {

        public int AnniDiCorso { get; set; }
        public int CFUPerLaurea { get; set; }
        public string NomeCorsoLaurea { get; set; }

        //CdL: nome, annidicorso,cfu per laurea, corsi associali
        public CorsoDiLaurea(NCL nomeCorsoLaurea, int anniDiCorso, int cfuPerLaurea)
        {
            nomeCorsoLaurea= NomeCorsoLaurea;  //TO FIX
            anniDiCorso = AnniDiCorso;
            cfuPerLaurea = CFUPerLaurea;
        }

    }
}
