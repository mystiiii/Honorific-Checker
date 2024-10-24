using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WW1
{
    internal class Program
    {
        public class compute
        {
            public string award { get; set; }
            
            public void Average(float subj1, float subj2, float subj3)
            {
                float sum = subj1 + subj2 + subj3;
                float ave = sum / 3;

                if (subj1 >= 90 && subj2 >= 90 && subj3 >= 90) {
                    if (ave >= 97) {
                        award = "First Honors";
                    } else if (ave >= 92 && ave <= 96) {
                        award = "Second Honors";
                    } else if (ave >= 87 && ave <= 91) {
                        award = "Third Honors";
                    } else {
                        return;
                    }
                } else { award = "Not Eligible for Honors"; }
            }
            public string Initials(string fInitial, string mInitial, string lInitial)
            {
                string F = fInitial.Substring(0, 1).ToUpper();
                string M = mInitial.Substring(0, 1).ToUpper();
                string L = lInitial.Substring(0, 1).ToUpper();
                return F + ". " + M + ". " + L + "., ";
            }
        }

        static void Main(string[] args)
        {
            //Full Name
            Console.Write("Input First Name: ");
            string fName = Console.ReadLine();
            Console.Write("Input Last Name: ");
            string lName = Console.ReadLine();
            Console.Write("Input Middle Name: ");
            string mName = Console.ReadLine();

            Console.WriteLine("\n-------------------");

            //Grades
            Console.Write("\nInput Physics Grade: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Calculus Grade: ");
            int calculus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Programming Grade: ");
            int prog = Convert.ToInt32(Console.ReadLine());

            compute comp = new compute();
            comp.Average(physics, calculus, prog);

            Console.WriteLine("\n-------------------\n");

            string initials = comp.Initials(lName, fName, mName);

            Console.WriteLine(initials + comp.award);
            Console.ReadLine();

        }
    }
}
