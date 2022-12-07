using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Class
{
    static class GeneralClass
    {
        private static User _user = new User();
        private static Employee _employee = new Employee();

        public static User UserLogged
        {
            get { return _user; }
            set { _user = value; }
        }

        public static Employee EmployeeLogged
        {
            get { return _employee; }
            set { _employee = value; }
        }
    }

}
