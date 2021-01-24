using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Interface, Türkçe anlamı Arayüz olan ve diğer sınıflara Rehberlik görevi üstlenen yapıdır.
            //Yaptığı iş sadece diğer sınıflara yön göstermektir.
            //Bu sebeple interfaceler içerisinde kesinlikle kod bloğu bulunmaz.
            //Interfaceler sadece tanımlamadan ibarettir.

            //BİR SINIF SADECE BİR SINIFTAN TÜRETİLEBİLİRKEN, BİRDEN ÇOK INTERFACE TEN TÜRETİLEBİLİR.

            #endregion

            #region Samsung Nesnesi

            Samsung s = new Samsung();
            Console.WriteLine(s.Yazdir());

            Console.WriteLine("--------------------");
            IBasliklar b = s;

            Console.WriteLine(b.Isim());

            Samsung s2 = (Samsung)b;

            Console.WriteLine(s2.Yazdir());

            #endregion
        }
    }
}
