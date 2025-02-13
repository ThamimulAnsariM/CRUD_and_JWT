using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace New_CodeFirstApproach.Model.Entities
{
    [Table("CandidateInfo")]
    public class Candidate
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public required string? Name { get; set; }

        public required string Address { get; set; }

        public string? phone { get; set; }

        public decimal salary { get; set; }
    }

}
