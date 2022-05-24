using System;
using Dapper.Contrib.Extensions;

namespace BlogDev.Models
{
    [Table("[Post]")]
    public class Post
    {
        public Post()
        {
            Summary = "SUMARIO TESTE";
            Body = "body para teste";
            CreateDate = DateTime.UtcNow;
            LastUpdateDate = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}