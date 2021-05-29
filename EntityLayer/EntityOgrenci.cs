using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {

        private string ogrenciadi;

        private string ogrencisoyadi;
        private string mail;
        private string sifre;

        private string numara;
        public string Numara { get => numara; set => numara = value; }

        private int ogrenciid;

        private double bakiye;
        public double Bakiye { get => bakiye; set => bakiye = value; }

        private string fotograf;
        public string Fotograf { get => fotograf; set => fotograf = value; }
        public string Ogrenciadi { get => ogrenciadi; set => ogrenciadi = value; }
        public string Ogrencisoyadi { get => ogrencisoyadi; set => ogrencisoyadi = value; }
        public int Ogrenciid { get => ogrenciid; set => ogrenciid = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
