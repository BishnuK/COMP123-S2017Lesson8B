using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017Lesson8B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Person person = new Person("Tom", 25);
            person.Talks();
            
            //person is a new object, . dot is used to access the 'Talks' method

            Console.WriteLine("\n");

        }
    }
}
