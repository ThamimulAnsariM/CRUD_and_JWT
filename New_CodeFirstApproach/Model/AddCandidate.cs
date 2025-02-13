using System.ComponentModel.DataAnnotations.Schema;

namespace New_CodeFirstApproach.Model
{
    public class AddCandidate
    {
        [Column(TypeName = "varchar(100)")]
        public required string? Name { get; set; }

        public required string Address { get; set; }

        public string? phone { get; set; }

        public decimal salary { get; set; }
    }
}
