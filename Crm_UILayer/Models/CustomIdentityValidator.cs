using Microsoft.AspNetCore.Identity;

namespace Crm_UILayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Şifre minimum {length} karakter olmadılır"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Şifre en az 1 tane büyük harf içermelidir."
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $"İlgili mail adresi {email} zaten sistemde kayıtlı, farklı bir mail deneyiniz"
            };
        }
    }
}
