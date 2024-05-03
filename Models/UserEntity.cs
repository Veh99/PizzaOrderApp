using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace PizzaOrderApp.Models
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public List<OrderEntity> Orders { get; set; } = [];

        //private UserEntity(Guid id, string userName, string password, string address, string phoneNumber)
        //{
        //    Id = id;
        //    Password = password;
        //    UserName = userName;
        //    Address = address;
        //    PhoneNumber = phoneNumber;

        //}
        //public UserEntity Create(Guid id, string userName, string password, string address, string phoneNumber)
        //{
        //    var user = new UserEntity(id, userName, password, address, phoneNumber);
        //    return user;
        //} 

    }
}
