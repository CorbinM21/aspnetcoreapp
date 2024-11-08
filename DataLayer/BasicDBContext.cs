
using BasicMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer{

    public class BasicDBContext : DBContext{
       
    public DbSet<Message> messages {get; set;}= null;

        public BasicDBContext(DBContextOptions<BasicDBContext> options):base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<messages>().HasData(
            new message {MessageID = 1, MessageText = "message one"}
            new message {MessageID = 2, MessageText = "Messgae Two"}
            )
        }
    }
}