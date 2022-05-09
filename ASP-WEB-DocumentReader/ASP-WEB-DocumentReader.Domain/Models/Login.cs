using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASP_WEB_DocumentReader.Domain.Models
{
    public class LoginRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; } 
    }
    public class LoginResponse
    {
        public string usuarioCatalogoID { get; set; }
        public string razaoSocial { get; set; }
        public string email { get; set; }
        public string nomeUsuario { get; set; }
        public string merchantId { get; set; }
        public string merchantKey { get; set; }
        public string guidRelatorio { get; set; }
        public string Token { get; set; }
    }

    public class UserResponse
    {
        public LoginResponse login { get; set; }
    }
}
