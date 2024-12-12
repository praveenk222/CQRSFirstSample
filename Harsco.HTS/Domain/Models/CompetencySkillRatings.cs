using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public partial class CompetencySkillRatings
    {
        public CompetencySkillRatings()
        {
            Competencies = new HashSet<Competencies>();
        }

        public int CompetencySkillRatingId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<Competencies> Competencies { get; set; }
    }
    public partial class SkillsRating
    {
        [Key]
        public int SkillRatingID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        //public byte[] TimeStamp { get; set; }
    }
    public partial class CompetencyDDL
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

    }
    public partial class EmployeeCommentsDDL
    {
        [Key]
        public int ID { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        public string Role { get; set; }

    }
}
