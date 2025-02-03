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
            private string _Name;
            private string _Module;
            private int _Mark;
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

            public Student(string _Name, string _Module, int _Mark) {
                Name = _Name;
                Module = _Module;
                Mark = _Mark;
            }
            public void DisplayInfo() {
                Console.WriteLine($"The student: {Name} attended the module {Module} and was marked with {Mark}.");
            }
            public void ComputeGradeCategory() {
                if (Mark == 0) {
                    Console.WriteLine("Missing Mark");
                }
                else {
                    if (Mark >= 40 && Mark < 50) {
                        Console.WriteLine($"{Name} with {Mark} you pass.");
                    }
                    else if(Mark >= 50 && Mark < 60) {
                        Console.WriteLine($"{Name} with {Mark} you get a 2:2.");
                    }
                    else if(Mark >= 60 && Mark < 70) {
                        Console.WriteLine($"{Name} with {Mark} you get a 2:1.");
                    }
                    else {
                        Console.WriteLine($"{Name} with {Mark} you get a 1st.");
                    }
                }

            }
        }
        static void Main(string[] args) {
            Student charlie = new Student("Charlie", "OOP", 100);
            charlie.DisplayInfo();
            charlie.ComputeGradeCategory();
        }
    }
}
