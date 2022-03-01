using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsApp
{
    public class Program
    {
        public static string Grade(int mark)
        {
            var grade = "";

            _= (mark > 100 || mark < 0) ? throw new GradeException("Allowed range 0=100") :
            mark >= 85 ? grade = "Distinction" :
            mark >= 65 ? grade = "Pass" : "Fail";

            return grade;
        }
        static void Main(string[] args)
        {

        }
    }
}
