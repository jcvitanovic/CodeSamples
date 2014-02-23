using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public static class EmployeeFactory
    {
        public static Employee CreateEmployeeProfile(string oib, string name, string surname, string department, string phone, string mail)
        {
            return new Employee(oib, name, surname, department, phone, mail);
        }
    }
}
