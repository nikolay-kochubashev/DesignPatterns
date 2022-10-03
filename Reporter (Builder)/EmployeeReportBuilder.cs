using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    internal class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;
        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new EmployeeReport();
        }

        public IEmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header = $"EMPLOYEES REPORT ON DATE: {DateTime.Now: dd.MM.yy hh:mm:ss}\n";
            _employeeReport.Header += "\n-------------------------------------------------------------\n";
            return this;
        }
        public IEmployeeReportBuilder BuildTtile()
        {
            _employeeReport.Body = $"------------- {_employeeReport.Title} -----------------";
            return this;
        }

        public IEmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body = String.Join(Environment.NewLine, 
                _employees.Select(e => 
                $"Employee: {e.Name}\t\tSalary: {e.Salary}$"));
            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer = "\n-----------------------------------------------";
            _employeeReport.Footer += 
                $"\nTOTAL EMPLOYEES: {_employees.Count()}." +
                $"TOTAL SALARY: {_employees.Sum(e => e.Salary)}$";
            return this;
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;
            _employeeReport = new();
            return employeeReport;
        }


    }
}
