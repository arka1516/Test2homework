using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
   class Person
   {
       static string copyright = "Amar Kruscica";
     protected  static int count = 0;//counts when method is called
     protected string name { get; set; }
     protected string lastName { get; set; }
public Person() {
    ++count;//i read post incrementing counter is better when you want to list it immediately so it increases after method is called
     }
public Person(string name, string lastName)//constructor from parent class for 2 arguments name and lastName

{

this.name = name;

this.lastName = lastName;

 

}

protected string getPersonInfo() { return name + ", " + lastName; }

} 

 class Student : Person, IComparable<Student>

   {
     public Student() { ++count;//empty constructor for Student class
          }
      ~Student() { }//empty destructor
     public Student(string name, string lastName, string emailorlocation):base(name,lastName){
         if (emailorlocation.Contains("@"))
         {//i read this is best way to do it as 2 constructors with same type of parameters arent allowed in same class
             this.email = emailorlocation;
         }
         else { this.location = emailorlocation; }
     }
    
      public string email{get; set;}
      protected string location;
      public string Location {
          get
          {
              if (location == "SA")
              {
                  return "Sarajevo";
              }
              else if (location == "TZ")
              {
                  return "Tuzla";
              }
              else
              {
                  return "Other";
              }
          }
          set { 
          if (value == "SA" || value == "Sarajevo" || value == "SARAJEVO") 
          {
              location = "SA";
          }
          else if (value == "TZ" || value == "TUZLA" || value == "Tuzla")
          {
              location = "TZ";
          }
          else
          {
              value = "N/A";
              location =value;
          }
          }
      }

       public bool setName(string input)//setName for checking if input for name is correct

       {

           if (input.Length<2)//checks if string length is lower than 2

           {

           Console.WriteLine("Name must be at least two characters long");

               return false;

           }


           for(int i =0;i<input.Length;i++){
           if (!(char.IsLetter(input[i])))//checks if it isnt letter
           {

               Console.WriteLine("Name can only have letters");
              
               return false;
           }

}

          if (!(char.IsUpper(input[0])))//checks 1st character in string

          {

          Console.WriteLine("Name must start with an uppercase letter");             
              return false;

           }

        return true;
       }
       public string getStudentInfo()
       {
           return email + "," + location + "," + getPersonInfo();

       }
       public override string ToString() { return name+" " + lastName+" " + email+" " + location+"\n"; }

       public int CompareTo(Student other)
       {
           return this.name.CompareTo(other.name); // sorts alphabetically as result of comparison between members in it
       }
   }


}
