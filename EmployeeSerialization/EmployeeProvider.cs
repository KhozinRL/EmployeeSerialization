using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EmployeeSerialization
{
    
    class EmployeeListJsonProvider : IProvider<List<Employee>>
    {
        private readonly string _fileName;

        private JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        public EmployeeListJsonProvider(string fileName)
        {
            _fileName = fileName;
        }

        public void Save(List<Employee> employees)
        {
            string json = JsonSerializer.Serialize(employees, _options);
            File.WriteAllText(_fileName, json);
        }

        public List<Employee> Load()
        {
            string json = File.ReadAllText(_fileName);
            return JsonSerializer.Deserialize<List<Employee>>(json, _options);
        }
    }
    
}
