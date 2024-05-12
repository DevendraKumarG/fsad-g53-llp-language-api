using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Llp.Language.Models
{
    [Table("assessments")]
    public class Assessment
    {

        [Key]
        [Column("assessment_id")]
        public int AssessmentId { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Column("section_id")]
        public int SectionId { get; set; }

        [Column("description")]
        public required string Description { get; set; }

        [Column("media_type_id")]
        public int MediaTypeId { get; set; }

        [Column("s3_file_key")]
        public required string S3FileUrl { get; set; }

        [Column("sequence")]
        public int Sequence { get; set; }

        [Column("attempts_allowed")]
        public int AttemptsAllowed { get; set; }

        [Column("pass_score")]
        public int PassScore { get; set; }

        [ForeignKey("LanguageId")]
        public virtual required Language Language { get; set; }

        [ForeignKey("MediaTypeId")]
        public virtual required MediaType MediaType { get; set; }
    }
}
