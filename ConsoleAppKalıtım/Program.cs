using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            //kedi clasımdan turettiğim nesneye değerlerimi giriyorum 
            //Ancak bu classın içi boş çünkü ben özelliklerimi hayvan classımdan alıyorum...


            Kedi kedi = new Kedi();
            kedi.isim = "TEKİR";
            kedi.cinsiyet = "DİŞİ";

            // ekrana vermek için metodumu
            kedi.hayvanbilgigoster();

            //programımı sonlandırdım Eğer silersem program çalışmaz
            Console.ReadKey();


        }
    }
}
