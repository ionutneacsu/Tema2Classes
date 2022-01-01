using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;using Tema2Classes;

namespace Tema2Classes
{
    class Student
    {
        public int ageField;
        public string nameField; // - two fields: age and name
        private const int MIN_AGE = 18; // - a constant field named MIN_AGE equal to 18
        private const int MAX_AGE = 99; //- a constant field named MAX_AGE equal to 99


        public int Ageprop  // - a full property named Age (validate for minimum input  MIN_AGE and maximum input MAX_AGE)
        {
            get { return ageField; }

            set {if ((value <= MIN_AGE) || (value >= MAX_AGE))
                {
                    ageField = 0;
                }
                else ageField = value;
               }
        }
        public string Name
        {
            get { return nameField; }
            set { nameField = value; }
        }
        //- a nullable automatic property named Mark

        public int Mark { get; set; }

        //- a constructor with age and name parameters
        public Student(string name, int age)
        {
            nameField = name;
            Ageprop = age;
        }
        // - a readonly dynamic property named Info, combining name and age in one string

        public string Info {get;}
    }
}