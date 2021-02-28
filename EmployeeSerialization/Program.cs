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
            string file = "EmployeeList.json";
            EmployeeListJsonProvider provider = new EmployeeListJsonProvider(file);
            List<Employee> employeeList = new List<Employee>();

            try
            {
                employeeList = provider.Load();
            }
            catch {}
            
            string regime;

            do {
                Console.WriteLine("\nВыберете режим: 0 - добавление нового сотрудника, 1 - поиск сотрудников. Для выхода нажмите любую клавишу.");

                regime = Console.ReadLine();

                switch (regime) {
                    case "0":
                        {
                            Console.WriteLine("Введите данные нового сотрудника.");

                            if (employeeList is not null)
                                employeeList.Add(entrance());
                            break;
                        }
                    case "1": 
                        {
                            Console.WriteLine("Введите данные сотродника для поиска. Enter - пропуск поля.");

                            Employee employeeToFind = entrance();

                            List<Employee> foundList = employeeList.FindAll(e => searchFunction(e, employeeToFind));

                            Console.WriteLine("\nНайденные сотрудники: ");

                            foreach (Employee e in foundList) {
                                Console.WriteLine(e.ToString());
                            }
                            break;
                        } 
                    default:
                        {
                            provider.Save(employeeList);
                            return;
                        }

                }
            } while (true);
        }

        static public Employee entrance() {
            Employee newEmployee = new Employee();
            Console.Write("\nИмя: ");
            newEmployee.FirstName = Console.ReadLine();
            Console.Write("Фамилия: ");
            newEmployee.LastName = Console.ReadLine();
            Console.Write("Отчество: ");
            newEmployee.Patronymic = Console.ReadLine();
            Console.Write("Телефон: ");
            newEmployee.Phone = Console.ReadLine();
            Console.Write("Адрес: ");
            newEmployee.Address = Console.ReadLine();

            return newEmployee;
        }

        static public bool searchFunction(Employee e1, Employee e2) {
            if (e2.FirstName == "" && e2.LastName == "" && e2.Patronymic == "" && e2.Phone == "" && e2.Address == "")
                return false;

            for (int i = 0; i < 5; i++) {
                if (e2[i] != "") {
                    if (e1[i] == e2[i])
                        continue;
                    else {
                        return false;
                    }

                }
            }

            return true;
        }
    }
}
