using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Node n1 = new Node(5);

            //Node n2 = new Node(10);

            //Node n3 = new Node(15);

            //n1.Next = n2;
            //n2.Next = n3;

            //Console.WriteLine(n2.Next.Data);

            LinkedList2 ls = new LinkedList2();

            ls.AddatEnd(5);
            ls.AddatEnd(6);
            ls.AddatEnd(7);

            ls.AddFirstly(2);

            //ls.delete(2);
            ls.AddAtMid(30, 2);
            ls.Print();



            //ls.Count();
            //ls.search(5);

            //Console.ReadKey();
        }
    }
}
