
using InlamningCsharp.Factories;
using InlamningCsharp.Models;

namespace InlamningCsharp.Tests
{
    public class UserFactory_Tests
    {
        [Theory]
        [InlineData("Zahra", "Parhizkari", "zara@gmail.com", "123456", "Mystreet", "12345", "Stockholm")]
        [InlineData("Sara", "Par", "sara@gmail.com", "111111", "Youstreet", "11111", "Dehli")]
        public void Create_ShouldReturnUserEntity_WhenUserRegistrationFormIsSupplied(string firstName, string lastName, string email, string phone, string street, string postalCode, string city)
        {
            // Arrange
            var form = new UserRegistrationForm
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phone,
                Street = street,
                PostalCode = postalCode,
                City = city
            };

            // Act
            UserEntity result = UserFactory.Create(form);

            // Assert
            Assert.IsType<UserEntity>(result);
            Assert.Equal(firstName, result.FirstName);
            Assert.Equal(lastName, result.LastName);
            Assert.Equal(email, result.Email);
            Assert.Equal(phone, result.Phone);
            Assert.Equal(street, result.Street);
            Assert.Equal(postalCode, result.PostalCode);
            Assert.Equal(city, result.City);
        }
    }
}