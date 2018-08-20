using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StudentsList
    {
        public List<Student> student = new List<Student>()
        {
            new Student(){ ID = 0, Name = "Marco", Course = new List<Courses>(){ Courses.Art, Courses.Math } },
            new Student(){ ID = 1, Name = "Pieter", Course = new List<Courses>(){ Courses.Art, Courses.Language } },
            new Student(){ ID = 2, Name = "John", Course = new List<Courses>(){ Courses.Science, Courses.Math } },
            new Student(){ ID = 3, Name = "Eve", Course = new List<Courses>(){ Courses.Art, Courses.Science } },
            new Student(){ ID = 4, Name = "Sara", Course = new List<Courses>(){ Courses.Sport, Courses.Math } }
        };
    }
}
