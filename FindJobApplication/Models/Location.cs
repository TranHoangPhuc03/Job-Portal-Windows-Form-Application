namespace FindJobApplication.Models
{
    public class Location
    {
        private int id;
        private string name;

        public Location() { }
        public Location(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; }
        public string Name { get => name; }
    }
}
