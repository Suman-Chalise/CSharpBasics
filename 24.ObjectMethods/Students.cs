using System;
using System.Collections.Generic;
using System.Text;

namespace _24.ObjectMethods
{
    class Students
    {
        public string name;
        public string major;
        public double gpa;

        public Students(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()    // creating method ( I call it functions ) it is called object method 
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;


        }
    }
}
