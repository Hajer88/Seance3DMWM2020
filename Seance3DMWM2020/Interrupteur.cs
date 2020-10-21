using System;
using System.Collections.Generic;
using System.Text;

namespace Seance3DMWM2020
{
    class Interrupteur
    {
        public int position { get; set; }
        Lampe l;
        public Interrupteur(Lampe l)
        {
            position = 0;
            this.l = l;
        }
        public void allume()
        {
            position = 1;
            l.allumer();

        }
        public void eteint()
        {
            position = 0;
            l.eteint();
        }
    }
    class Lampe
    {
        bool allume;
        public Lampe()
        {
            allume = false;
        }
        public void allumer()
        {
            allume = true;
        }
        public void eteint()
        {
            allume = false;
        }
    }
}
