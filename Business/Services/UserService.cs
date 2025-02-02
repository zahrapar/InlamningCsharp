
using InlamningCsharp.Factories;
using InlamningCsharp.Helpers;
using InlamningCsharp.Models;
using System.Diagnostics;

namespace InlamningCsharp.Services;

public class UserService
{
    private  List<UserEntity> _users = new List<UserEntity>();
    private readonly FileService _fileService = new FileService();
    public bool Create(UserRegistrationForm form)
    {
        try
        {
            UserEntity userEntity = UserFactory.Create(form);
            userEntity.Id = UniqueIdentifierGenerator.GenerateUniqueId();


            _users.Add(userEntity);
            _fileService.SaveListToFile(_users);

            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }


    //public IEnumerable<UserEntity> GetAll()
    //{
    //    return _users;
    //}

    public IEnumerable<User> GetAll()
    {
        _users = _fileService.LoadListFromFile() ?? new List<UserEntity>(); 


        //var list = new List<User>();
        //foreach (var userEntity in _users)
        //    list.Add(UserFactory.Create(userEntity));
        //return list;


        //_users = _fileService.LoadListFromFile();
        //return _users;

        return _users.Select(UserFactory.Create);
    }



}

