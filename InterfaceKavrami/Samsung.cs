using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKavrami
{
    class Samsung : IBasliklar, IUzunluk
    {
        public string AltBaslik()
        {
            return "Telefon";
        }

        public string AnaBaslik()
        {
            return "Teknoloji";
        }

        public string Boy()
        {
            return "145.7";
        }

        public string En()
        {
            return "80.3";
        }

        public string Isim()
        {
            return "Model=Galaxy S10";
        }

        public string Yazdir()
        {
            return String.Format($"{Isim()} {AnaBaslik()} {AltBaslik()} {En()} {Boy()}");
        }
    }
}
