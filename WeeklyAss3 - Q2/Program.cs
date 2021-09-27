using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyAss3___Q2
{
    delegate void MultiTypeDelegate(object a);

    class Program
    {
        static void Main(string[] args)
        {
            object a = null;
            MultiTypeDelegate MultiDel1 = StringHere.ReturnString;
            MultiTypeDelegate MultiDel2 = IntegerHere.ReturnInt;
            MultiTypeDelegate MultiDel3 = FloatHere.ReturnFloat;
            MultiTypeDelegate MultiDel = MultiDel1;
            MultiDel += MultiDel2;
            MultiDel += MultiDel3;
           
            MultiDel(a);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
