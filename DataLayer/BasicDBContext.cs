
using Microsoft.EntityFrameworkCore;

namespace BacisMVC.DataLayer{

    public class BasicDBContext : DBContext{
       
    public DbSet<Message> messages {get; set;}= null;

        public BasicDBContext(DBContextOptions<BasicDBContext> options):base(options){
        
        }

    }
}