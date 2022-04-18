using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKalıtım
{
   public class Hayvan
    {

        //erişim belirleyicilerimi deklare edip değişkenlerimi oluşturdum 
        public string isim;
        public string cinsiyet;

        // private olarak tanımladığım için main methodda bu özelliği görüntüleyemiyorum...
        private int yas;

        // bu methodu ekrana vermek için kullandım 
        public void hayvanbilgigoster()
        {
            Console.WriteLine("HAYVANIN İSMİ :" + isim);
            Console.WriteLine("HAYVANIN CİNSİYETİ :" + cinsiyet);

        }


    }
}
