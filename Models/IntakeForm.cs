using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class IntakeForm
{

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(500, ErrorMessage = "Please limit to 500 characters.")]
    public string Symptoms { get; set; }

    [ForeignKey("DoctorId")]
    public int DoctorId { get; set; }
    //public Doctor Doctor { get; set; }

    [ForeignKey("PatientId")]
    public int PatientId { get; set; }
    //public Patient Patient { get; set; }

}