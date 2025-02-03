using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2
{
    internal class Program
    {
        internal class Student
        {
            // Class attributes (private therefore encapsulated)
            private string _Name;
            private string _Module;
            private int _Mark;

            // Setter functions for attributes
            public string Name {
                get { return _Name; }
                set {
                    if (string.IsNullOrEmpty(value)) {
                        _Name = "NoName"; 
                    }
                    else {
                        _Name = value; 
                    }
                } 
            }
            public string Module {
                get { return _Module; }
                set {  _Module = value; } 
            }
            public int Mark {
                get { return _Mark; }
                set {
                    if (value < 0 || value > 100) {
                        _Mark = 0;
                    }
                    else {
                        _Mark = value;
                    }
                }
            }

            // Objects (only object needed is student)
            public Student(string _Name, string _Module, int _Mark) {
                Name = _Name;
                Module = _Module;
                Mark = _Mark;
            }

            // Object functionality
            public void DisplayInfo() {
                Console.WriteLine($"The student: {Name} attended the module {Module} and was marked with {Mark}.");
            }
            public void ComputeGradeCategory() {
                if (Mark == 0) {
                    Console.WriteLine("Missing Mark");
                }
                else {
                    if (Mark < 40) {
                        Console.WriteLine($"{Name} with {Mark} you fail.");
                    }
                    else if (Mark >= 40 && Mark < 50) {
                        Console.WriteLine($"{Name} with {Mark} you pass.");
                    }
                    else if(Mark >= 50 && Mark < 60) {
                        Console.WriteLine($"{Name} with {Mark} you get a 2:2.");
                    }
                    else if(Mark >= 60 && Mark < 70) {
                        Console.WriteLine($"{Name} with {Mark} you get a 2:1.");
                    }
                    else{
                        Console.WriteLine($"{Name} with {Mark} you get a 1st.");
                    }
                }

            }
        }
        static void Main(string[] args) {

            // Creating different instances of the student object to show functionality of the student class
            Student charlieprofile = new Student("Charlie", "OOP", 41);
            charlieprofile.DisplayInfo();
            charlieprofile.ComputeGradeCategory();
            Console.WriteLine();

            Student oliviaprofile = new Student("Olivia", "OOP", 12);
            oliviaprofile.DisplayInfo();
            oliviaprofile.ComputeGradeCategory();
            Console.WriteLine();

            Student tashasprofile = new Student("Tasha", "OOP", 89);
            tashasprofile.DisplayInfo();
            tashasprofile.ComputeGradeCategory();
            Console.WriteLine();

            Student bellaprofile = new Student("Bella", "OOP", 65);
            bellaprofile.DisplayInfo();
            bellaprofile.ComputeGradeCategory();
            Console.WriteLine();

            Student gabrielprofile = new Student("Gabriel", "OOP", 101);
            gabrielprofile.DisplayInfo();
            gabrielprofile.ComputeGradeCategory();

        }
    }
}
