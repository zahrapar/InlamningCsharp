

using InlamningCsharp.Helpers;
using InlamningCsharp.Models;


namespace InlamningCsharp.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static UserEntity Create(UserRegistrationForm form)
    {
        return new UserEntity
        {
            //Id = UniqueIdentifierGenerator.GenerateUniqueId(),
            FirstName = form.FirstName,
            LastName = form.LastName,
            Email = form.Email,
            Phone = form.Phone,
            Street = form.Street,
            City = form.City,
            PostalCode = form.PostalCode,
        
        };
    }




    public static User Create(UserEntity entity)
    {
        return new User()
        {
            //Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Phone = entity.Phone,
            Street = entity.Street,
            City = entity.City,
            PostalCode = entity.PostalCode,
        };
    }
}

