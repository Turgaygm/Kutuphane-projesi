using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace Logiclayer
{
    public class Class1
    {
        public static List<kitaplar> LLoPersonellistesi()
        {
            return DALKutuphane.Personellistesi();
        }
        public static int LLPersonelekle(kitaplar p)
        {

            if (p.k_ad != "")
            {

                return DALKutuphane.personelekle(p);

            }
            else
            {
                return -1;
            }
        }
            public static bool LLPersonelguncelle(kitaplar p)
            {
                if (p.k_ad != "" )
                {
                    return DALKutuphane.personelguncelle(p);
                }
                else
                {
                    return false;
                }
            }
        public static bool DLPersonelSil(int per)
        {
            if (per >= 1)
            {
                return DALKutuphane.personelsil(per);
            }
            else
            {
                return false;
            }
        }
    }
    }

