using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çember_OPP
{
    internal class Cember
    {
        public double Merkezx { get; set; }
        public double Merkezy { get; set; }
        public double YariCap { get; set; }
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }


        public Cember(string ad,double x, double y, double r)
        {
            Merkezx = x;
            Merkezy = y;
            YariCap = r;
            Ad = ad;
        }
        public void Yaz()
        {
            Console.WriteLine($"Çemberin X Kordinati :{Merkezx} Y Kordinatı {Merkezy}  Yarıcapı: {YariCap}");
        }
        public void SetMerkezXY(double x, double y)
        {
            Merkezx = x;
            Merkezy = y;
        }
        public void SetYariCap(double r)
        {
            YariCap = r;
        }
        public double GetAlan()
        {
            return Math.PI * Math.Pow(YariCap, 2);
        }
        public double GetCevre()
        {
            return 2 * Math.PI * YariCap;
        }
        public double mesafe(Cember a)
        {
            return Math.Sqrt(Math.Pow(this.Merkezx - a.Merkezx, 2) + Math.Pow(this.Merkezy - a.Merkezy, 2));
        }
        public bool icindeMi(Cember a)
        {
            bool sonuc=false;
            if (mesafe(a)<Math.Abs(this.YariCap-a.YariCap))
            {
                sonuc = true;
            }
            return sonuc;
        }
        public Cember BuyukOlan(Cember b)
        {
            Cember donus = this;
            if (this.YariCap > b.YariCap)
            {
                donus = this;
            }
            else if (this.YariCap < b.YariCap)
            {
                donus = b;
            }
            else
            {
                donus = null;
            }
            return donus;
        }
        public void TegetYap(char eksen)
        {
            if (eksen == 'x' || eksen == 'X')
            {
                Merkezy = YariCap;
            }
            else if (eksen == 'y' || eksen == 'Y')
            {
                Merkezx = YariCap;
            }
            else
            {
                Console.WriteLine("Lütfen X  yada Y formatın giriş yapınız.\n Teğet yapma durumu gerçekleşmez.");
            }
        }
        public void TegetYap(char eksen, char eksen2)
        {
            Merkezx = YariCap;
            Merkezy = YariCap;

        }
    }
}

