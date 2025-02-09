#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUD.Models;

public class Squishy {
    [Key]
    public int SquishyId {get; set;}
    [Required]
    public string SquishyName {get; set;}
    [Required]
    public string SquishyImg {get; set;}
    [Required]
    public string Owner {get; set;} = "Ubin";
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}