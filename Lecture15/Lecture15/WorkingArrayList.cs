using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture15
{
    public class WorkingArrayList
    {
       public static ArrayList MyList = new ArrayList();
        public WorkingArrayList() {
            
            MyList.Add("I ");
            MyList.Add("want to show you");
            MyList.Add("haw I can to set the int value in List: ");
            MyList.Add(2020);
        }
        
        public void PrintValues()
        {

            foreach (Object obj in MyList)
                Console.Write(" {0}", obj);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
