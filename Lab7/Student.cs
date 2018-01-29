using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Student
    {
        private string name;
        private string hometown;
        private string food;
        private int id;

        public string getName()
        {
            return "Student Name: " + name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getHometown()
        {
            return "Hometown: " + hometown;
        }

        public void setHometown(string hometown)
        {
            this.hometown = hometown;
        }

        public string getFood()
        {
            return "Favorite Food: " + food;
        }

        public void setFood(string food)
        {
            this.food = food;
        }

        public Student()
        {
            name = "";
            hometown = "";
            food = "";


        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }


        public Student(int id, string name, string hometown, string food)
        {
            this.id = id;
            this.name = name;
            this.hometown = hometown;
            this.food = food;
        }

        override
        public string ToString()
        {
            string myString = "";
            myString = "ID: " + this.id + "Name: " + this.name + "\nHometown: " + this.hometown + "\nFavorite Food: " + this.food;
            return myString;
        }

    }

}
