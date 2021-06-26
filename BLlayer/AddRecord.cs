using System;
using System.Collections.Generic;
using System.Text;
using DLlayer;

namespace BLlayer
{
    public class AddRecord
    {

       
        public void Violation()
        {

            addstudentData addStud = new addstudentData();
            Login log = new Login();

            Console.WriteLine("Name: ");
            addStud.studentname.Add(Console.ReadLine());
            Console.WriteLine("Student ID: ");
            addStud.studentID.Add(Console.ReadLine());
            Console.WriteLine("Violation: ");
            addStud.studentViolation.Add(Console.ReadLine());
            Console.WriteLine("Offence: ");
            addStud.studentOffence.Add(Console.ReadLine());

            
             
            Console.WriteLine("STUDENT RECORDED!");

            Console.WriteLine("(1)RETURN TO MENU");
            string choice3 = Console.ReadLine();
            if(choice3 == "1")
            {
                log.menu();
            }
        
        }

        public void viewStudents()
        {
            addstudentData show = new addstudentData();
            Login log = new Login();



            for (int i = 0; i < show.studentname.Count; i++)
            {
                Console.WriteLine(show.studentname[i]);
                Console.WriteLine(show.studentID[i]);
                Console.WriteLine(show.studentViolation[i]);
                Console.WriteLine(show.studentOffence[i]);
            }


            Console.WriteLine("(1)RETURN TO MENU");
            string choice5 = Console.ReadLine();
            if (choice5 == "1")
            {
                log.menu();
            }


        }

    }

        
    }

