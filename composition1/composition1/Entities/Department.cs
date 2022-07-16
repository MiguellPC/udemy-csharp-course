namespace composition1.Entities
{
    internal class Department
    {
        public string Name { get; private set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
