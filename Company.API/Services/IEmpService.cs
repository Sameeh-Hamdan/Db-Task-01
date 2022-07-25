using Company.API.Models;
using System.Collections.Generic;

namespace Company.API.Services
{
    public interface IEmpService
    {
        void DeleteEmp(int id);
        List<Employee> GetAllEmps();
        Employee GetEmp(int id);
    }
}