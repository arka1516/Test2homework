using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Lets check checkname function");
            string checkname = Console.ReadLine();
            Student a = new Student();//this is just to check if checkname functions properly
            while (!(a.setName(checkname)))//while loop repeats until correct input is made for setname
            {
                checkname = Console.ReadLine();
            }

            List<Student> studentnames = new List<Student>//list of students who will be sorted by name
            {   
                new Student("Somename3","Somelastnam39","someemail@.com"),
                new Student("Somename2","Somelastname92","someemail2@.com"),
                new Student("Somename1","Somelastname81","someemail1@.com"),
                new Student("Somename4","Somelastname94","someemail4@.com"),
                new Student("Somename","Somelastnam8e","someemail@.com"),
                new Student("Somename8","Somelastname78","someemail8@.com"),
                new Student("Somename7","Somelastname87","someemail7@.com"),
                new Student("Somename5","Somelastname94","someemail4@.com"),
                new Student("Somename45","Somelastname945","ematl88887@.com"),
                new Student("Somename54","Somelastname754","someemail45@.com")

            };
            Console.WriteLine("List of students sorted by names");
            studentnames.Sort();//calls compare 
            foreach (Student name in studentnames)//for every student it will output their records,due to called sort method it will be ascending order alphabetically
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
