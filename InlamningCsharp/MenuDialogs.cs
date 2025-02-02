//**********************************************************
//User IDs are saved as GUIDs in the JSON file,
//but for the view, I don't display them. They are only saved in the file 
//*******************************************************************

using InlamningCsharp.Factories;
using InlamningCsharp.Models;

namespace InlamningCsharp.Services
{
    public class MenuDialogs : IMenuDialogs
    {


        private readonly UserService _userService = new UserService();

        public void Show()
        {
            while (true)
            {

                WelcomeMenu();
                //Console.Clear();
                //string option = WelcomeMenu();

                //if (!string.IsNullOrEmpty(option))
                //{
                //    MenuOptionSelector(option);
                //}
                //else
                //{
                //    Console.WriteLine("You must enter a valid option.");
                //    Console.ReadKey();

                //}




            }
        }

        private void WelcomeMenu()
        {
            Console.WriteLine("Welcome to the AddressBook");
            Console.WriteLine("1. Create a contact");
            Console.WriteLine("2. Show all contacts");
            Console.WriteLine("3. Exit");
            Console.Write("Choose your menu option: ");
            var option = Console.ReadLine()!;

            //return option;
            switch (option)
            {
                case "1":
                    CreateOption();
                    break;
                case "2":
                    ViewOption();
                    break;
                case "3":
                    QuitOption();
                    break;
                default:
                    //Console.WriteLine("Invalid option, please enter 1, 2, or 3.");
                    InvalidOption();
                    break;
            }


        }

        //private void MenuOptionSelector(string option)
        //{
        //    switch (option)
        //    {
        //        case "1":
        //            CreateOption();
        //            break;
        //        case "2":
        //            ViewOption();
        //            break;
        //        case "3":
        //            Console.WriteLine("Exiting program...");
        //            Environment.Exit(0); 
        //            break;
        //        default:
        //            //Console.WriteLine("Invalid option, please enter 1, 2, or 3.");
        //            InvalidOption();
        //            break;
        //    }
        //}
       
        private void CreateOption()
        {
            UserRegistrationForm userRegistrationForm = UserFactory.Create();

            Console.Clear();
            Console.WriteLine("Create a contact");

            Console.Write("Enter First Name: ");
            userRegistrationForm.FirstName = Console.ReadLine() ?? "";

            Console.Write("Enter Last Name: ");
            userRegistrationForm.LastName = Console.ReadLine() ?? "";

            Console.Write("Enter Email : ");
            userRegistrationForm.Email = Console.ReadLine() ?? "";

            Console.Write("Enter Phone : ");
            userRegistrationForm.Phone = Console.ReadLine() ?? "";

            Console.Write("Enter Street : ");
            userRegistrationForm.Street = Console.ReadLine() ?? "";

            Console.Write("Enter PostalCode: ");
            userRegistrationForm.PostalCode = Console.ReadLine() ?? "";

            Console.Write("Enter City: ");
            userRegistrationForm.City = Console.ReadLine() ?? "";

           var result = _userService.Create(userRegistrationForm);
            Console.ReadKey();



        }

        private void ViewOption()
        {
            Console.WriteLine("Show all contacts :");
            var users = _userService.GetAll();

            Console.Clear();


            Console.Clear();

            foreach (var user in users)
            {
                //Console.WriteLine($"Id: {user.Id}");
                Console.WriteLine($"Name: {user.FirstName} {user.LastName}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Phone: {user.Phone}");
                Console.WriteLine($"Street: {user.Street}");
                Console.WriteLine($"City: {user.City}");
                Console.WriteLine($"Postal Code: {user.PostalCode}");
                Console.WriteLine("___________");
            }

            Console.ReadKey();
        }
        private void QuitOption()
        {
            Console.Clear();
            Console.Write("Do you want to exit this application (y/n): ");
            var option = Console.ReadLine();

            if (option?.Equals("y", StringComparison.CurrentCultureIgnoreCase) == true)
            {
                Environment.Exit(0);
            }
        }



        private void InvalidOption()
        {
            Console.WriteLine("You must enter a valid option.");
            Console.ReadKey();
        }

    }
}

