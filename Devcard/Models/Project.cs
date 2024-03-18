

namespace Devcard.Models
{
    public class Project
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Project(long iD, string name, string description, string image, string client)
        {
            ID = iD;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}
