using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class TriangleSolver
    {
        public static String Analyze(int sideaa,
        int sidebb,
        int sidecc)
        {
            
            if (sideaa + sidebb > sidecc && sideaa + sidecc > sidebb && sidecc + sidebb > sideaa)
            {
                if (sideaa == sidebb && sidebb == sidecc)
                {
                    return ("It is Equilteral triangle");

                }
                else if (sideaa == sidebb || sideaa == sidecc || sidebb == sidecc)
                {
                    return ("It is Isosceles triangle");

                }
                else if (sideaa != sidebb || sideaa != sidecc || sidebb != sidecc)
                {
                    return ("It is Scalene triangle");

                }
                return "";

            }
            else if (sideaa == 0 || sidebb == 0 || sidecc == 0)
            {
                return ("Enter Valid Dimnesions");
            }
            else
            {
                return "Traingle cannot be formed";
            }

       
        }
    }
}

