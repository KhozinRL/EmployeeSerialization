using System;
using System.Collections;
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

        public Employee() { }

        public Employee(string name, string family, string patronymic, string phone, string address) {
            FirstName = name;
            LastName = family;
            Patronymic = patronymic;
            Phone = phone;
            Address = address;
        }

        public string this[int index] {
            get {
                switch (index)
                {
                    case 0: return FirstName;
                    case 1: return LastName;
                    case 2: return Patronymic;
                    case 3: return Phone;
                    case 4: return Address;
                }

                throw new IndexOutOfRangeException();
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set {
                if (FirstName is null)
                    _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (LastName is null)
                    _lastName = value;
            }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set
            {
                if (Patronymic is null)
                    _patronymic = value;
            }
        }

        public string Phone
        {
            get { return _phone; }
            set => _phone = value;
        }

        public string Address
        {
            get { return _address; }
            set => _address = value;
        }

        override public string ToString() {
            return string.Format("\nИмя: {0}\nФамилия: {1}\nОтчество: {2}\nТелефон: {3}\nАдрес: {4}", FirstName, LastName, Patronymic, Phone, Address);
        }
    }
}
