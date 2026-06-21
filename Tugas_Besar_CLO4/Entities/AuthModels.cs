using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Besar_CLO4.Entities
{
    public class RegisterRequest
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public class LoginRequest
    {
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public class AuthResponse
    {
        public string Message { get; set; } = "";
        public int UserId { get; set; }
        public string Email { get; set; } = "";
        public string Role { get; set; } = "";
        public string Token { get; set; } = "";
    }

    public class ErrorResponse
    {
        public string Message { get; set; } = "";
    }
}