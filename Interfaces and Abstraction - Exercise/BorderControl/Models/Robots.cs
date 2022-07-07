namespace BorderControl
{
    public class Robots : IAdded
    {
       public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; set; }
    }
}
