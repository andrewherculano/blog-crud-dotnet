using Dapper.Contrib.Extensions;

namespace BlogDev.Models
{
    [Table("[Tag]")]
    public class Tag
    {
        public Tag(int id, string name, string slug)
        {
            Id = Id;
            Name = name;
            Slug = slug;
        }

        public Tag(string name, string slug)
        {
            Name = name;
            Slug = slug;
        }

        public Tag() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}