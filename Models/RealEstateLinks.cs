using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerryHomesDemo.Models
{
    [Table("realEstateLinks")]
    public class RealEstateLinks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int imageId { get; set; }
    }

    public class RealEstateLinksContext : DbContext
    {
        public RealEstateLinksContext(DbContextOptions<RealEstateLinksContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstateLinks> RealEstateLinks { get; set; } = null!;
    }
}
