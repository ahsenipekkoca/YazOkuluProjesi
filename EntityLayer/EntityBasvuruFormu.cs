using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityBasvuruFormu
    {
        private int basvuruid;
        private int basvurudersid;
        private int basvuruogretmenid;

        public int Basvuruid { get => basvuruid; set => basvuruid = value; }
        public int Basvurudersid { get => basvurudersid; set => basvurudersid = value; }
        public int Basvuruogretmenid { get => basvuruogretmenid; set => basvuruogretmenid = value; }
    }
}
