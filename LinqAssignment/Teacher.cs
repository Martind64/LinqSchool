using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Teacher
    {
        public string _name { get; set; }
        public int _id { get; set; }
        public int _salary { get; set; }

        public Teacher(string name, int id, int salary)
        {
            _name = name;
            _id = id;
            _salary = salary;
        }

    }
}
