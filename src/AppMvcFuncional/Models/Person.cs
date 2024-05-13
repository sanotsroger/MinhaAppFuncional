using System.ComponentModel.DataAnnotations;

namespace AppMvcFuncional.Models;

public class Person
{
    [Key]
    [ScaffoldColumn(false)]
    public int Id { get; set;}

    [Required(ErrorMessage = "The {0} field is required")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "The {0} field have must between {2} and {1} characters")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "The {0} field is required")]
    public int? Age { get; set;}
}