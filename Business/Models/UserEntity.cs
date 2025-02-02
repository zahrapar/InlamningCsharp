﻿

using InlamningCsharp.Helpers;

namespace InlamningCsharp.Models;

public class UserEntity
{
    //public string Id { get; set; } = UniqueIdentifierGenerator.GenerateUniqueId();
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string PostalCode { get; set; } = null!;

}
