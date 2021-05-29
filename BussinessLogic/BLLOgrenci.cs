using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BussinessLogic
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if(p.Ogrenciadi!= null && p.Ogrencisoyadi!=null && p.Numara!=null &&p.Sifre!=null && p.Mail != null)
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
    }
}
