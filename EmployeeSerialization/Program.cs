using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace EmployeeSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employeeList = EmployeeDeserializer();

            int regime;

            string name;
            string family;
            string patronymic;
            string phone;
            string address;
            
            do {
                Console.WriteLine("Выберете режим: 0 - добавление нового сотрудника, 1 - поиск сотрудников, 2 - выход");
                regime = Console.Read();




            } while (regime != 2);
        }

        public static void EmployeeSerializer(IEnumerable<Employee> collection) {
            using (FileStream fs = new FileStream("Employee.json", FileMode.Create))
            {
                JsonSerializer.SerializeAsync(fs, collection);
            }
        }

        public static IEnumerable<Employee> EmployeeDeserializer() {
            using (FileStream fs = new FileStream("Employee.json", FileMode.Open)) {
                return JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(fs).Result;
            }
                
        }

        public 

        public static void addEmployee() { }

    }
}
