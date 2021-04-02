using System;
using System.Collections.Generic;
using System.Text;

namespace Verifica4_SeleneT
{
    class Corso
    {

        private List<Corso> _corsi = new List<Corso>();

        public string NomeEsame { get; }
        public int CFU { get; }
        public Corso(string nomeEsame, int cfu)
        {
            NomeEsame = nomeEsame;
            CFU = cfu;
            _corsi.Add(this);
        }


    }

}