using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class DepartmentsApi
    {

        LittleTicketSystemContext _contextDepartments = new LittleTicketSystemContext();



        public List<Departments> GetDepartments()
        {
            var departments = new List<Departments>();

            departments = _contextDepartments.Departments.ToList();

            return departments;
        }

        public Departments GetDepartment(int id)
        {
            var departmentQuery = _contextDepartments.Departments.Where(d => d.Id == id);
            var entityData = departmentQuery.FirstOrDefault();

            return entityData != null ? entityData : null;
        }

        public void AddDepartment(Departments department)
        {
            var departmentQuery = _contextDepartments.Departments.Where(d => d.DepartmentName == department.DepartmentName);
            var entityData = departmentQuery.FirstOrDefault();

            if (entityData != null)
            {
                Departments newDepartment = new Departments();

                newDepartment.DepartmentName = department.DepartmentName;

                _contextDepartments.Departments.Add(newDepartment);
                _contextDepartments.SaveChanges();

            }

        }

        public void UpdateDepartment(Departments department)
        {
            var departmentQuery = _contextDepartments.Departments.Where(d => d.DepartmentName == department.DepartmentName);
            var entityData = departmentQuery.FirstOrDefault();

            if (entityData != null)
            {
                _contextDepartments.Attach(entityData);
                entityData.DepartmentName = department.DepartmentName;

                _contextDepartments.SaveChanges();
            }

        }

        public void DeleteDepartment(int id)
        {
            var departmentQuery = _contextDepartments.Departments.Where(d => d.Id == id);
            var dataEntity = departmentQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                _contextDepartments.Departments.Remove(dataEntity);

                _contextDepartments.SaveChanges();
            }

        }
    }
}
