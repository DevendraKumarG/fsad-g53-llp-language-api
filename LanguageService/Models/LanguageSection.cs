using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Llp.Language.Models
{
    [Table("language_sections")]
    public class LanguageSection
    {
        [Key]
        [Column("section_id")]
        public int SectionId { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Required]
        [Column("section_name")]
        public required string SectionName { get; set; }

        [Column("description")]
        public string Description { get; set; } = "";

        [Column("media_type_id")]
        public int MediaTypeId { get; set; }

        [Column("s3_file_key")]
        public required string S3FileUrl { get; set; }

        [Column("sequence")]
        public int Sequence { get; set; }

        [ForeignKey("LanguageId")]
        public virtual required Language Language { get; set; }

        [ForeignKey("MediaTypeId")]
        public virtual required MediaType MediaType { get; set; }
    }
}
