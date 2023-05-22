using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace InventorySystem.Models;

public class User : IdentityUser
{
    [Required]
    public string CodeEmployee {get;set;}
  
    public string FristName {get;set;}
   
    public string LastName {get;set;}
}
