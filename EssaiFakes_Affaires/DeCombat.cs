using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssaiFakes_Affaires
{
    public class DeCombat : De
    {
        public DeCombat() : base(20) { }

        public bool aManque() { return _valeur == 1; }
        public bool aTouche() { return !this.aManque(); }
        public bool estAttaqueCritique() { return _valeur == 20; }
    }
}
