using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool status;
            //status = true;
            //Console.WriteLine("Did the student pass the exam ? " + status);

            //Kullanıcı girisi ile bool örnegi;
            bool evlimi;
            Console.WriteLine("Lütfen medeni durumunuzu girin : ");
            evlimi = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Medeni durumunuz : " + evlimi);

            Console.Read();
        }
    }
}
