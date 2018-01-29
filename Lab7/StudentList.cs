using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    static class StudentList
    {

        static List<Student> studentList = new List<Student>();
        
        public static void addStudent(Student student)
        {
            studentList.Add(student);
        }

        public static void listStudents()
        {
            int i = 1;
            foreach (Student s in studentList)
            {
                Console.WriteLine("ID " + i + ": "  + s.getName());
                i++;
            }
        }

        public static List<Student> passList()
        {
            return studentList;
        }
    }
}
