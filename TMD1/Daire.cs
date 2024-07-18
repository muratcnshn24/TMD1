using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    public class Daire
    {
        public const double pi = 3.14;

        ///<summary>
        /// Darienin alanını hesaplar
        ///</summary>
        ///<param name="r">YarıÇap</param>param>
        ///<returns>Alan değeridir</returns>
        public static double AlaniHesapla(double r)
        {
            return pi * r* r;       
        }

        ///<summary>
        /// Darienin alanını hesaplar
        ///</summary>
        ///<param name="r">YarıÇap</param>param>
        ///<param name="aci">Gördüğü aci</param>param>
        ///<returns>Alan değeridir</returns>
        public static double AlaniHesapla(double r, double aci)
        {
            return pi * r * r* aci/360;
        }
    }
}
