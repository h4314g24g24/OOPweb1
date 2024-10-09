using System;
namespace oopveb8.Models
{
    public class User
    {
        public int Id { get; set; } // Ідентифікатор користувача
        public string FirstName { get; set; } // Ім'я
        public string LastName { get; set; } // Прізвище
        public string Email { get; set; } // Адреса електронної пошти
        public DateTime RegistrationDate { get; set; } // Дата реєстрації
    }
}
