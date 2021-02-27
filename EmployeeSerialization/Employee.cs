using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSerialization
{
    class Employee
    {
        string _firstName;
        string _lastName;
        string _patronymic;
        string _phone;
        string _address;

        public Employee(string family, string name, string patronymic, string phone, string address) {
            _firstName = name;
            _lastName = family;
            _patronymic = patronymic;
            _phone = phone;
            _address = address;
        }

        string FirstName {
            get { return _firstName; }
        }

        string LastName
        {
            get { return _lastName; }
        }

        string Patronymic
        {
            get { return _patronymic; }
        }

        string Phone
        {
            get { return _phone; }
        }

        string Address
        {
            get { return _address; }
        }
    }
}
