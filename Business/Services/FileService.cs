using InlamningCsharp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InlamningCsharp.Services
{
    public class FileService
    {
        private readonly string _directoryPath;
        private readonly string _filePath;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public FileService(string directoryPath = "Data", string fileName = "list.json")
        {
            _directoryPath = directoryPath;
            _filePath = Path.Combine(_directoryPath, fileName);
            _jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
        }

        public void SaveListToFile(List<UserEntity> list)
        {
            try
            {
                if (!Directory.Exists(_directoryPath))
                    Directory.CreateDirectory(_directoryPath);

                var json = JsonSerializer.Serialize(list, _jsonSerializerOptions);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error with file: {ex.Message}");
            }
        }


        public List<UserEntity> LoadListFromFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                    //return new List<User>();
                    return [];

                var json = File.ReadAllText(_filePath);
                var list = JsonSerializer.Deserialize<List<UserEntity>>(json, _jsonSerializerOptions);
                return list ?? [];
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error : {ex.Message}");
                return []; 
            }
        }
    }
}