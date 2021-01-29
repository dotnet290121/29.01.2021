namespace OOP2901
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static bool operator >(Student p1, Student p2)
        {
            return p1.Id > p2.Id;
        }
        public static bool operator <(Student p1, Student p2)
        {
            return p1.Id < p2.Id;
        }
        public static bool operator ==(Student p1, Student p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
                return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;

            return p1.Id == p2.Id;
        }
        public override int GetHashCode()
        {
            return this.Id;
        }
        public static bool operator !=(Student p1, Student p2)
        {
            return !(p1 == p2);
        }
        public override bool Equals(object obj)
        {
            Student p = obj as Student;
            return this == p;
        }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}