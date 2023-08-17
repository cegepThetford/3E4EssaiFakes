using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssaiFakes_Affaires
{
    public abstract class Creature
    {
        protected int _nbPtsVie;

        public Creature(int nbPtsVie)
        {
            _nbPtsVie = nbPtsVie;
        }

        public int NbPtsVie { get { return _nbPtsVie; } set { _nbPtsVie = value; }}

        public virtual void enregistrerDegats(int nbPts)
        {
            _nbPtsVie = (_nbPtsVie < nbPts) ? 0 : _nbPtsVie - nbPts; 
        }

        public bool estMorte() { return _nbPtsVie == 0; }
        public bool estVivante() { return !this.estMorte(); }

        public virtual int attaquer(Arme arme)
        {
            int dommages = this.determinerDommagesEffectifs(arme);
            this.enregistrerDegats(dommages);
            return dommages;
        }

        public virtual int determinerDommagesEffectifs(Arme arme)
        {
            DeCombat de = DeJeu.getInstance().De;
            de.lancer();
            int ptsDegat;
            if (de.aManque())
                ptsDegat = 0;
            else {
                ptsDegat = arme.determinerNbPtsDegat();
                if (de.estAttaqueCritique())
                    ptsDegat = arme.DommagesMax;
            }
            return ptsDegat;
        }
    }
}
