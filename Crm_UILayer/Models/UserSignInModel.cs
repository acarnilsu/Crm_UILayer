using System.ComponentModel.DataAnnotations;

namespace Crm_UILayer.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage="Lütfen kullanıcı adını boş geçmeyin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
    }
}
