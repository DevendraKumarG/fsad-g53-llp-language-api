using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Llp.Language.Models
{
    [Table("media_type")]
    public class MediaType
    {

        [Key]
        [Column("media_type_id")]
        public int MediaTypeId { get; set; }

        [Required]
        [Column("name")]
        public required string Name { get; set; }

        [Required]
        [Column("extension")]
        public required string Extension { get; set; }
    }
}
