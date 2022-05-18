using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [SerializableAttribute]
    public class Classroom
    {
        public string ID { get; private set; }

        public string Name { get; private set; }

        public string Subject { get; private set; }

        public List<Student> Students { get; set; }

        private Classroom()
        {

        }

        public Classroom(string name, string subject)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
            Subject = subject;
        }


    }
}
