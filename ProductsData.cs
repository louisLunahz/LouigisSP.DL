using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LouigisSP.BO;

namespace LouigisSP.DL
{
   
    public static class ProductsData
    {
        static List<Keyboard> products = new List<Keyboard>();

       
      //  string distribution, string size, string methodOfConnection, float price, string brand, string ilumination, bool wristRest, string design, string color
        public static List<Keyboard> getAllProducts() {
            products.Clear();
            AddProducts();

            return products;
        }

        public static void AddProducts() {
            Keyboard k1 = new Keyboard("190896", "Spanish", "80%", "USB", 123, "Hyper X", "alloy fps", "RGB", false, "QWERTY", "red");
            Keyboard k2 = new Keyboard("190897", "English", "100%", "USB", 143, "Elecom", "TK-FDM063TBK", "No", false, "QWERTY", "black");
            Keyboard k3 = new MechanicalKeyboard("190898", "Spanish", "100%", "USB", 200, "Hyper X", "HX-KB1SS2-LA", "RGB", false, "QWERTY", "black", "red", "Cherry MX");

            products.Add(k1);
            products.Add(k2);
            products.Add(k3);

        }

        

    }
}
