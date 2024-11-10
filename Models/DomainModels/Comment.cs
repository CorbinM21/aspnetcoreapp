namespace BasicMVC.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public string OwnerID { get; set; } = string.Empty; // represents the physical value in the database
        public MVCUser Owner { get; set; } = null!; // navigation propery for MVCUser
                public int PostIdNumber { get; set; }
        
        // Navigation property to the related Post class
        public Post Post { get; set; } = null!;
    }
}