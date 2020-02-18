using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recup_on_CSharp
{
   
    public class Program : Dog
    {
        Dictionary<string, StudentPerfomance> mydict = new Dictionary<string, StudentPerfomance>();


        static void Main(string[] args)
        {
            Console.WriteLine("Oliver Kipkemei");
            MyMethod(3,5);
            Program p = new Program();
            
            p.Cannines(null);
            Dog dog = new Cat();
            dog.Cannines(null);
            dog.Age = 8;
            dog.Name = "Jimmy";
            StudentPerfomance studentPerfomance = new StudentPerfomance();
            studentPerfomance.PerfomanceMethod();

            
            
            Console.ReadLine();
        }
        public static void MyMethod(int x, int y)
        { 
            Console.WriteLine($"The Sum of {x}  and {y} is {x+y}");
        }
        public override void Cannines(string strength)
        {
            Console.WriteLine("Cannines Are Sharp ");
        }
    }
    public abstract class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Cannines(string strength);
    }
    public class Cat : Dog
    {
        public override void Cannines(string strength)
        {
            Console.WriteLine("In A cat Cannines Are Sharp also");
        }
    }
    public class StudentPerfomance
    {
        List<string> mylist = new List<string>() { "Oliver", "Kipkemei","Mengich" };
        public void PerfomanceMethod()
        {

       
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            } 
        }
    }
}
