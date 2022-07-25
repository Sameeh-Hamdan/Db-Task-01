using Company.API.Data;
using Company.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Company.API.Services
{
    public class EmpService : IEmpService
    {
        private readonly ApplicationDbContext _context;
        public EmpService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Employee> GetAllEmps()
        {
            return _context.Employees.ToList();
        }
        public Employee GetEmp(int id)
        {
            return _context.Employees.Find(id);
        }
        public void DeleteEmp(int id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
    }
}
