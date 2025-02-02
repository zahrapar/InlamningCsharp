//*********************************************************
//User IDs are saved as GUIDs in the JSON file,
//but for the view, I don't display them. They are only saved in the file 
//*******************************************************************

using InlamningCsharp.Services;
//var menu = new MenuDialogs();




//menu.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

IMenuDialogs menu = new MenuDialogs();
menu.Show();