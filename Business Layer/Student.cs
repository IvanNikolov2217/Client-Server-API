using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [SerializableAttribute]
    public class Student
    {
        public string ID { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public List<int> Points { get; private set; }

        public List<Classroom> Classrooms { get; set; }

        private Student()
        {

        }

        public Student(string name, int age ,List<int> points)
        {
            ID = Guid.NewGuid().ToString();
            Age = age;
            Name = name;
            Points = points;
        }
    }
}
