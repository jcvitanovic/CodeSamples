using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class EmployeeRepository
    {

        private static EmployeeRepository instance = null;
        public List<Employee> listEmployee= new List<Employee>();

        public static EmployeeRepository GetInstance()
        {
            if (instance == null)
                instance = new EmployeeRepository();
            return instance;
        }

        public void Load()
        {
            Employee e = EmployeeFactory.CreateEmployeeProfile("10257841210", "Pero", "Perić", "Financije", "0971245710", "pperic@linkit.hr");
            EmployeeRepository.GetInstance().addEmployee(e);
            e = EmployeeFactory.CreateEmployeeProfile("77812541042", "Mirna", "Mirić", "Računovodstvo", "0911245781", "mmiric@linkit.hr");
            EmployeeRepository.GetInstance().addEmployee(e);
            e = EmployeeFactory.CreateEmployeeProfile("10234781881", "Ana", "Anić", "Prodaja", "09112547801", "aanic@linkit.hr");
            EmployeeRepository.GetInstance().addEmployee(e);
            e = EmployeeFactory.CreateEmployeeProfile("10778125367", "Ivo", "Ivic", "IT", "0911874512", "iivic@linkit.hr");
            EmployeeRepository.GetInstance().addEmployee(e);    
        }

        public Employee getEmployeeByOib(string oib)
        {
            foreach (Employee e in listEmployee)
            {
                if (e.OIB == oib)
                    return e;
            }
            return null;
        }

        public void addEmployee(Employee e)
        {
            this.listEmployee.Add(e);
        }

        public void removeEmployee(Employee e)
        {
            this.listEmployee.Remove(e);
        }

        public int employeeCount()
        {
            if (this.listEmployee == null)
                return 0;
            else
                return this.listEmployee.Count();
        }

    }
}
