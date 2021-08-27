using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Adi = "Elma";
            product1.Aciklama = "Eğirdir Elması";
            product1.Fiyati = 3.45;

            Product product2 = new Product();

            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine();
            }
            

            Console.WriteLine("-------------Metotlar-------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add("Armut", "Yeşil Armut", 12 , 36);
            Console.Read();
        }
    }
}