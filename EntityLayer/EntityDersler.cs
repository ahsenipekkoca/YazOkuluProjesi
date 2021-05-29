using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityDersler
    {
        private string dersadi;
        private int min;
        private int max;
        private int dersid;

        public string Dersadi { get => dersadi; set => dersadi = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
        public int Dersid { get => dersid; set => dersid = value; }
    }
}
