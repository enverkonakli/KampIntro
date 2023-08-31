using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Sepete Eklendi : " + product.Name);
        }
        public void Delete(Product product)
        {
            Console.WriteLine("Sepetten Silindi : " + product.Name);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Sepet Güncellendi : " + product.Name);
        }
    }
}
