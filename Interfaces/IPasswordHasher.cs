using Microsoft.EntityFrameworkCore.Sqlite.Storage.Json.Internal;

namespace PizzaOrderApp.Interfaces
{
    public interface IPasswordHasher
    {
        public string Generate(string password);

        public bool Verify(string password, string hashPassword);
    }
}