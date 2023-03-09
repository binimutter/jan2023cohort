#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DevsOnDeck.Models;

public class OrganizationProfile {
    [Key]
    public int OrganizationProfileId {get; set;}
    public string? Address {get; set;}
    public string City {get; set;}
    public string State {get; set;}
    public string Zip {get; set;}
    public string? Bio {get; set;}
    public string? LinkedIn {get; set;}
    public string? Github {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // ******* One to One id side
    public int OrganizationId {get; set;}
    public Organization? org {get; set;}

}