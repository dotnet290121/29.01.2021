using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2901
{
    public class ClassRoom
    {
        private List<Student> m_students = new List<Student>();

        public Student this[int id]
        {
            get
            {
                // this returns the item in this index
                //return m_students[index];
                return m_students.FirstOrDefault(_ => _.Id == id);
            }
            set
            {
                // this returns the item in this index
                m_students[m_students.FindIndex(_ => _.Id == id)] = value;
            }
        }
        public List<Student> this[string name]
        {
            get
            {
                return m_students.Where(_ => _.Name == name).ToList();
            }
        }

        public void Add(Student s)
        {
            m_students.Add(s);
        }

        public void Remove(Student s)
        {
            m_students.Remove(s);
        }
    }
}
