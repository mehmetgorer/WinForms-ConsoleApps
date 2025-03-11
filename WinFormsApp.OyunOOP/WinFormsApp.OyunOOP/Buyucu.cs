using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.OyunOOP
{
    public class Buyucu
    {
        //Bu sınıfın neyi var
        public string OyuncuIsmi { get; set; } 
        public string Brans { get; set; }
        public string Irk { get; set; }
        public string Silah { get; set; }
        public int SaldiriGucu { get; set; }

        //Buyucum ne yapabilir 

        public void Saldir()
        {
            switch (Brans)
            {
                case "Karabüyü":
                    SaldiriGucu = 50;
                    break;
                case "Defansif":
                    SaldiriGucu = 10;
                    break;
                default:
                    SaldiriGucu = 30;
                    break;
            }

        }

    }
}
