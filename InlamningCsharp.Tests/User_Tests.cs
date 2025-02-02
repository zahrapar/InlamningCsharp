

using InlamningCsharp.Models;
using InlamningCsharp.Services;

namespace InlamningCsharp.Tests
{
    public class User_Tests
    {
        //private readonly User _user = new User();
        private readonly UserService _userService = new UserService();
        private readonly UserRegistrationForm _form;

        [Fact]
        public void WeTestCreateFunction_TrueResult_WhenUserIsCreated()
        {
            // Arrange
            var form = new UserRegistrationForm
            {
                FirstName = "Zahra",
                LastName = "Parhizkari",
                Email = "zara@gmail.com",
                Phone = "123456",
                Street = "Mystreet",
                City = "Stockholm",
                PostalCode = "12345"
            };

            // Act
            var result = _userService.Create(form);

            // Assert
            Assert.True(result);
        }



        [Fact]
        public void WeTestGetAllFunction_ShouldReturnCreatedUser()
        {
            // Arrange
            var form = new UserRegistrationForm
            {
                FirstName = "Zahra",
                LastName = "Parhizkari",
                Email = "zara@gmail.com",
                Phone = "123456",
                Street = "Mystreet",
                City = "Stockholm",
                PostalCode = "12345"
            };

            // Act
            _userService.Create(form); 
            var users = _userService.GetAll().ToList();

            // Assert
            Assert.NotEmpty(users);

            var _user = users.FirstOrDefault(u => u.FirstName == form.FirstName && u.LastName == form.LastName);
            Assert.NotNull(_user); 

        }
    }
}

