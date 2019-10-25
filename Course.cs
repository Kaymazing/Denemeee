using System;
using System.Collections.Generic;
using System.Text;

namespace Mert_Kaymaz_HW2
{
    public class Course
    {
        public string Code { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int credit;
        public int Credit
        {
            get { return credit; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Credit can not be smaller than 0 or grater than 10");
                }
                credit = value;
            }
        }
    }
}
