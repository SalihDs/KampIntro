using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : "+product.Adi);
        }

        public void Add(string urunAdi , string aciklama , double fiyat , int stokAdedi) 
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
