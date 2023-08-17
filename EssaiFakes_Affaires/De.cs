using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssaiFakes_Affaires
{
    public class De
    {
        protected int _valeur, _nbFaces;
        private Random _aleatoire;

        public De() : this(6) { }
        public De(int nbFaces)
        {
            _nbFaces = nbFaces;
            _valeur = _nbFaces;
            _aleatoire = new Random();
        }

        public void lancer()
        {
            _valeur = _aleatoire.Next(1, _nbFaces);
        }

        public int Valeur { get { return _valeur; } set { _valeur = value; } }
        public int NbFaces { get { return _nbFaces; } set { _nbFaces = value; } }
    }
}
