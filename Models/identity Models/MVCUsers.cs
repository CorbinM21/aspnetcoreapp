using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Identity;

namespace BasicMVC.Models
{
    public class MVCUser : IdentityUser
    {
        [Key]
        public override string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Property to return the full name
        public string FullName => FirstName + " " + LastName;

        // Property to parse Id as an integer
        public int GetNumericId => int.TryParse(Id, out var numericId) ? numericId : 0;
    }
}