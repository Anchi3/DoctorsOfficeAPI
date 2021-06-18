using System.ComponentModel.DataAnnotations;
using System;


public class Patient
{

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string DateOfBirth { get; set; }
    public int HealthNumber { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

}