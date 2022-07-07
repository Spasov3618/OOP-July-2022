namespace BorderControl
{
    public class Citizens : IAdded
    {
        public Citizens()
        {
        }

        public Citizens(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
    }
}
