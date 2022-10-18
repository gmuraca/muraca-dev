using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedArborDb
{
    public class CandidateExperiences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCandidateExperience { get; set; }

        [Required(ErrorMessage = "La relacion con el candidato es requerida")]
        public int IdCandidate { get; set; }

        [Required(ErrorMessage = "La compania es requerida")]
        [Display(Name = "Compania")]
        public string Company { get; set; }

        [Required(ErrorMessage = "El empleo es requerido")]
        [Display(Name = "Empleo")]
        public string Job { get; set; }

        [Required(ErrorMessage = "La descripcion del empleo es requerida")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El salario es requrido")]
        [Display(Name = "Salario")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        [Display(Name = "Fecha de Inicio")]
        public DateTime BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        [ForeignKey("IdCandidate")]
        public virtual Candidates Candidate { get; set; }
    }
}
