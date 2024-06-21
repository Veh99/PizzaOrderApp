using Microsoft.AspNetCore.Identity;
using PizzaOrderApp.Interfaces;

namespace PizzaOrderApp.Infrastraction
{
    public class PasswordHasher : IPasswordHasher
    {
        public string Generate(string password) =>
            BCrypt.Net.BCrypt.EnhancedHashPassword(password);

        public bool Verify(string password, string hashPassword) =>
            BCrypt.Net.BCrypt.Verify(password, hashPassword);
    }
}