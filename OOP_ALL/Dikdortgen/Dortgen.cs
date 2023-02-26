using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdortgen
{
    internal class Dortgen
    {
        private string _ad;
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        private double _solx;
        public double Solx
        {
            get { return _solx; }
            set { _solx = value; }
        }

        private double _soly;
        public double Soly
        {
            get { return _soly; }
            set { _soly = value; }
        }

        private double _sagx;
        public double Sagx
        {
            get { return _sagx; }
            set { _sagx = value; }
        }

        private double _sagy;
        public double Sagy
        {
            get { return _sagy; }
            set { _sagy = value; }
        }

        public Dortgen(string ad, double a, double b, double c, double d)
        {
            _ad = ad;
            _solx = a;
            _soly = b;
            _sagx = c;
            _sagy = d;
        }
        public void Yaz()
        {
            Console.WriteLine($"Çemberin Adı:{_ad}, Sol üst Kordinatı: {_solx},{_soly}, Sag alt Kordinatı: {Sagx},{Sagy}");
        }
        public void SetSolÜst(double a, double b)
        {
            Solx = a;
            Soly = b;
        }
        public void SetSagAlt(double a, double b)
        {
            Sagx = a;
            Sagy = b;
        }
        public double GetBoy()
        {
            return Math.Abs(_soly - _sagy);
        }
        public double GetEn()
        {
            return Math.Abs(_sagx - _solx);
        }
        public double GetAlan()
        {
            return GetBoy() + GetAlan();
        }
        public double GetCevre()
        {
            return 2 * (GetBoy() + GetAlan());

        }
        public Dortgen BuyukOlan(Dortgen b)
        {
            return this.GetAlan() > b.GetAlan() ? this : b;
        }
        public void KareYap()
        {
            if (GetEn() > GetBoy())
            {
                Sagx = Solx + GetBoy();
            }
            else
            {
                Sagy = Soly + GetEn();
            }
        }
    }
}
