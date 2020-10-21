using System;
using System.Collections.Generic;
using System.Text;

namespace Seance3DMWM2020
{
    interface IPremiereInterfac
    {
        int FaireQQchose();
    }
    interface IDeuxiemeInterface
    {
        void FaireQQchose();
    }
    public class test : IPremiereInterfac, IDeuxiemeInterface
        {
        public void FaireQQchose()
        {
            Console.WriteLine("Faire qqchose");
        }
        int IPremiereInterfac.FaireQQchose()
        {

        }
        }
}
