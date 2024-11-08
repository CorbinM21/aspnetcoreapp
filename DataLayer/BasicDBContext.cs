
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer{

    public class BasicDBContext : DBContext{
       
    public DbSet<Message> messages {get; set;}= null;

        public BasicDBContext(DBContextOptions<BasicDBContext> options):base(options){
        
        }

    }
}