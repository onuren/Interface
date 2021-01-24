using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKavrami
{
    interface IBasliklar
    {
        //Interfacelerin tüm üyeleri Public kabul edilir. Private, Protected, Static gibi tanımlanamazlar.

        string Isim();//Metot
        //Metodun içerisine herhangi bir kod yazılamaz sadece tanımlama yapılabilir.

        //void IBasliklar();
        //Interfaceler constructor içeremez

        string AnaBaslik();

        string AltBaslik();

        string Yazdir();
    }

    interface IUzunluk
    {
        string En();

        string Boy();

        string Yazdir();
    }
}
