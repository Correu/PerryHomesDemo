using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerryHomesDemo.Models
{
    [Table("user_links")]
    public class UserLinks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int userId { get; set; }
        public int userType { get; set; }
    }

    public class UserLinksContext : DbContext
    {
        public UserLinksContext(DbContextOptions<UserLinksContext> options)
            : base(options)
        {
        }

        public DbSet<UserLinks> UserLinks { get; set; } = null!;
    }
}
