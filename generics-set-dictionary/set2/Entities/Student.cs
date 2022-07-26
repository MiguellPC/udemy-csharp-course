namespace set2.Entities
{
    internal class Student
    {
        public int ID { get; set; }

        public Student(int iD)
        {
            ID = iD;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Student)
            {
                return false;
            }

            Student other = obj as Student;

            return ID.Equals(other.ID);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
