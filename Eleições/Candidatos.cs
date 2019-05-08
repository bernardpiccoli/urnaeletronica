using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleições
{
 [Serializable]
    public class Candidatos
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _numero;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private string _partido;

        public string Partido
        {
            get { return _partido; }
            set { _partido = value; }
        }

        private string _cargo;

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        private string _UrlFoto;

        public string UrlFoto
        {
            get { return _UrlFoto; }
            set { _UrlFoto = value; }
        }
        private int _Votos;

        public int Votos
        {
            get { return _Votos; }
            set { _Votos = value; }
        }

        public Candidatos()
        {

        }

        
    }
}
