using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssaiFakes_Affaires
{
    public class Arme
    {
        protected string _nom;
        protected int _dommagesMin, _dommagesMax;
        protected bool _etatContondante, _etatArgent, _etatBenie;
        private Random _aleatoire;

        public Arme(string nom, int dmgMin, int dmgMax, bool cont, bool arg, bool ben)
        {
            _nom = nom;
            _dommagesMin = dmgMin;
            _dommagesMax = dmgMax;
            _etatContondante = cont;
            _etatArgent = arg;
            _etatBenie = ben;
            _aleatoire = new Random();
        }

        #region Proprietes
        public string Nom { get { return _nom; } set { _nom = value; } }
        public int DommagesMin { get { return _dommagesMin; } set { _dommagesMin = value; } }
        public int DommagesMax { get { return _dommagesMax; } set { _dommagesMax = value; } }
        public bool estContondante() { return _etatContondante; }
        public bool estEnArgent() { return _etatArgent; }
        public bool estBenie() { return _etatBenie; }
        #endregion

        public int determinerNbPtsDegat()
        {
            return _aleatoire.Next(_dommagesMin, _dommagesMax+1);
        }
        public int attaquer(Creature creature)
        {
            return creature.attaquer(this);
        }
    }
}
