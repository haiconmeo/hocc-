using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1
{
    delegate int congthuctoan(int a, int b);

    class Program
    {

        static int tong(int a,int b)
        {
            return a + b;

        }
        static int hieu(int a,int b)
        {
            return a - b;
        }
        static int tich(int a,int b)
        {
            return a * b;
        }
        static int ctt(int a,int b,congthuctoan ct)
        {
            return ct(a, b);
        }
        static void Main(string[] args)
        {
            congthuctoan ct = new congthuctoan(tong);
            congthuctoan ct2 = new congthuctoan(hieu);
            congthuctoan ct3 = new congthuctoan(tich);
            congthuctoan tonghop;
            tonghop = ct + ct2 + ct3;
            //Console.Write("{0}", tonghop(1, 2));
            Console.Write("{0}", ctt(1, 2, tong));
            Console.ReadKey();
        }
    }
}
