using Microsoft.AspNetCore.Identity;

namespace FirstDotnetCoreMVC.Entities.Identity
{
    public class CustomIdentityUser:IdentityUser
    {
        public string Name { get; set; }
    }
}