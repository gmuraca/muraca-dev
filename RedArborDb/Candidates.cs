using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedArborDb
{
    public class Candidates
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Candidato")]
        public int IdCandidate { get; set; }

        [Required(ErrorMessage = "Your message here")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your message here")]
        [Display(Name = "Apellido")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Your message here")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Your message here")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public virtual ICollection<CandidateExperiences> Experiences { get; set; }
    }
}
