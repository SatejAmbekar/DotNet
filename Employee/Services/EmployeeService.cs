using EMP.Entities;
using EMP.Repositories;
namespace EMP.Services;

public class EmployeeService : IEmployeeService
{

    public EmployeeService()
    {}

    public List<Employee> GetAll()
    {

        List<Employee> employees = new List<Employee>();
        MySqlDBManager mgr = new MySqlDBManager();
        employees = mgr.GetAll();
        return employees;

    }

    public Employee GetById(int id)
    {
        MySqlDBManager mgr = new MySqlDBManager();
        Employee emp = mgr.GetById(id);
        return emp;
    }

    public void Insert(Employee emp)
    {
        MySqlDBManager mgr = new MySqlDBManager();
        mgr.InsertNew(emp);
    }

    public void Update(Employee emp)
    {
        MySqlDBManager mgr = new MySqlDBManager();
        mgr.UpdateEmp(emp);
    }

    public void Delete(int id)
    {
        MySqlDBManager mgr = new MySqlDBManager();
        mgr.DeleteById(id);
    }
}