using System.Globalization;

namespace BasicMVC.Models
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public string PostText { get; set; } = string.Empty;
        public string OwnerID { get; set; } = string.Empty; // represents the physical value in the database
        public MVCUser Owner { get; set; } = null!; // navigation propery for MVCUser

        // Navigation property showing relationships by connecting comments/ many side
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}