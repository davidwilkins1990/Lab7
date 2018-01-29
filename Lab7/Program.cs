/*
 David Wilkins
 Lab 7 - Students 
 01/29/18

 This program lets the user select a student and ask a question about that student
 , either their favorite food or hometown

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        public static List<Student> studentList = StudentList.passList();


        public static void studentInfo()
        {

            Console.WriteLine("*** Student Information Center ***");

            Console.Write("\nWhich Student would you like to know more about? Enter a number 1-13 or L for a list: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            if (input == "l")
            {
                StudentList.listStudents();
                Console.Write("\nEnter a number corresponding to the student: ");
                try
                {
                    int numberInput = int.Parse(Console.ReadLine());
                    search(numberInput);
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                    studentInfo();
                }
            }
            else if (input != "l")
            {
                try
                {
                    int searchInput = 0;
                    searchInput = int.Parse(input);
                    search(searchInput);

                }
                catch
                {
                    Console.WriteLine("\nERROR: Invalid entry");
                    studentInfo();
                }
            }
        
           


        }

      
        public static void search(int input)
        {
            int studentNumber = 0;
            try
            {
                studentNumber = input;
                Console.WriteLine("number: " + studentNumber);

                if (studentNumber > 13 || studentNumber < 1)
                {
                    Console.WriteLine("You must enter a number between 1 and 12");
                    studentInfo();
                }
                else
                {
                    foreach (Student s in studentList)
                    {
                        if (s.getId() == studentNumber)
                        {
                            Console.Write("\nStudent " + studentNumber + " is " + s.getName() +
                                ":\nWhat would you like to know about " + s.getName() + "?\n" +
                                "Enter 'hometown' or 'favorite food': ");
                            string input2 = Console.ReadLine();

                            while (input2 != "hometown" && input2 != "favorite food")
                            {
                                Console.Write("\nERROR: invalid response. Enter 'hometown' or 'favorite food': ");
                                input2 = Console.ReadLine();
                            }

                            if (input2 == "hometown")
                            {
                                Console.WriteLine(s.getName() + " " + s.getHometown());
                                more(studentNumber);
                            }
                            else
                            {
                                Console.WriteLine(s.getName() + " " +s.getFood());
                                more(studentNumber);
                            }
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("You must enter a number 1 - 12 or the letter L");
                studentInfo();
            }
        }

        public static void more(int studentID)
        {
            Console.Write("\nWould you like to know more? [y / n]: ");
            string more = Console.ReadLine();
            more = more.ToLower();
            if (more == "y")
            {
                search(studentID);
            }
            else
            {
                again();
            }
        }

        public static void again()
        {
            Console.Write("\nPress 'y' to look up another student or any other key to quit: ");
            string again = Console.ReadLine();
            again = again.ToLower();
            if (again == "y")
            {
                studentInfo();
            }
            else
            {
                Environment.Exit(0);
            }

        }

        static void Main(string[] args)
        {

            Student student1 = new Student(1, "David", "Fort Wayne, IN" , "Lasagna");
            Student student2 = new Student(2, "Tommy", "Raleigh, NC" ,"Chicken Curry");
            Student student3 = new Student(3, "Aaron", "Hart, MI", "Ribeye");
            Student student4 = new Student(4, "Andrew", "Fremont, MI", "Steak");
            Student student5 = new Student(5, "Chamus", "Zeeland, MI", "Sushi");
            Student student6 = new Student(6, "Marshal", "Holland, MI", "Burgers");
            Student student7 = new Student(7, "Jonathan", "Middleville, MI", "Stouts");
            Student student8 = new Student(8, "Albert", "Grand Rapids, MI", "potatoes and beans");
            Student student9 = new Student(9, "Adam", "Grand Rapids, MI", "putine");
            Student student10 = new Student(10, "Ian", "Allendale, MI", "Alfredo");
            Student student11 = new Student(11, "Kevin", "Chicago, IL", "Oatmeal");
            Student student12 = new Student(12, "Lamar", "Skyrim", "Mead");
            Student student13 = new Student(13, "Kelsey", "Grand Circus Co", "Student's Tears");


            StudentList.addStudent(student1);
            StudentList.addStudent(student2);
            StudentList.addStudent(student3);
            StudentList.addStudent(student4);
            StudentList.addStudent(student5);
            StudentList.addStudent(student6);
            StudentList.addStudent(student7);
            StudentList.addStudent(student8);
            StudentList.addStudent(student9);
            StudentList.addStudent(student10);
            StudentList.addStudent(student11);
            StudentList.addStudent(student12);
            StudentList.addStudent(student13);




            studentInfo();
            
            

            Console.ReadLine();
        }
    }
}
