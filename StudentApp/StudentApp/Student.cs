using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Courses> Course { get; set;}

    }
    public enum Courses
    {
        Math,
        Science,
        Sport,
        Language,
        Art
    }
}
