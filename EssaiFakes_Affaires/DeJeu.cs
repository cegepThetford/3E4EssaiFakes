using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssaiFakes_Affaires
{
    public class DeJeu
    {
        private static DeJeu _deJeu = null;
        private DeCombat _de;

        private DeJeu()
        {
            _de = new DeCombat();
        }

        public static DeJeu getInstance()
        {
            if (_deJeu == null)
                _deJeu = new DeJeu();
            return _deJeu;
        }

        public DeCombat De { get { return _de; } set { _de = value; } }
    }
}
