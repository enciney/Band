using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace EternalBAND.Models;

public class Users:IdentityUser
{
    [DisplayName("Ad")]
    public string? Name { get; set; }
    [DisplayName("Soyad")]
    public string? Surname { get; set; }
    [DisplayName("Ad Soyad")]
    public string? FullName { get; set; }
    [DisplayName("Fotoğraf")]
    public string? PhotoPath {get; set; }
    [DisplayName("Şehir")]
    public int City {get; set; }
    [DisplayName("Yaş")]
    public int Age {get; set; }
    [DisplayName("Kaydolma Tarihi")]
    public DateTime RegistrationDate {get; set; }
}