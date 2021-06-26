using System;
using System.Collections.Generic;
using System.Text;
using DLlayer;
using BLlayer;

namespace BLlayer
{
    public class Login
    {
        public void LogIn()
        {
            LoginData acess = new LoginData();
            

            Console.Title = "LogIn";
            Console.WriteLine("================================================");
            Console.WriteLine("             Input your Credentials             ");
            Console.WriteLine("================================================");

            Console.Write("Input Username: ");
            string uname = Console.ReadLine();
            Console.Write("Input Password: ");
            string pass = Console.ReadLine();

            if (uname == acess.username && pass == acess.password)
            {
                menu(); 
            }
            else
            {
                Console.Clear();
                Console.WriteLine("                 PLEASE TRY AGAIN                ");
                LogIn();
            }
        
        
        }
        public void menu()
        {
            //AddRecord record = new AddRecord();
            Manage fix = new Manage();


            Console.Title = "Main Menu";
            Console.Clear();

            Console.WriteLine("(1)Add Record\n\n\n(2)View record\n\n\n(3)Logout");
            string choice = Console.ReadLine();

            if (choice == "1")
            {

                fix.managing();

                //record.Violation();

                
            }
            else if(choice == "2")
            {
                //record.viewStudents();
                fix.managing2();
               

            }
            else if(choice == "3")
            {
                Console.Clear();
                LogIn();
            }

            else
            {
                Console.WriteLine("INVALID INPUT");
                menu();
            }

            
        }
    }
}
