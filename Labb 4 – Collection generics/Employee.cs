using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_4___Collection_generics
{
    class Employee
    {
        public int _id;
        public string _name;
        public string _gender;
        public double _salary;

        public Employee(int id, string name, string gender, double salary)
        {
            this._id = id;
            this._name = name;
            this._gender = gender;
            this._salary = salary;
        }
    }
}
