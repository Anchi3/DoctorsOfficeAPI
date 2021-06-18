using System.ComponentModel.DataAnnotations;


public class Doctor
{

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

}