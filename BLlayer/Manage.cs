using System;
using System.Collections.Generic;
using System.Text;

namespace BLlayer
{
    class Manage
    {
        AddRecord manage = new AddRecord();

       public void managing()
        {
            Console.WriteLine("enter? (1)YES  (2)NO");
            string choice4 = Console.ReadLine();

            if (choice4 == "1")
            {
                manage.Violation();
            }
        }
        public void managing2()
        {
            Console.WriteLine("enter? (1)YES  (2)NO");
            string choice6 = Console.ReadLine();

            if (choice6 == "1")
            {
                manage.viewStudents();
            }
        }
       
    }
}
