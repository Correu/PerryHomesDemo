using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerryHomesDemo.Models
{
    [Table("realEstate")]
    public class RealEstate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public required string address { get; set; }
        public required string value { get; set; }
        public required string type { get; set; }
    }

    public class RealEstateContext : DbContext
    {
        public RealEstateContext(DbContextOptions<RealEstateContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstate> RealEstate { get; set; } = null!;
    }
}
