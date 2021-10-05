using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Data;
using WebMVC.Models;

namespace WebMVC.Components
{
    public class AddOrUpdateEmployeeViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _appContext;

        public AddOrUpdateEmployeeViewComponent(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(int empid = 0)
        {
            if (empid == 0)
            {
                //Add new 
                //return View();
                return View(new Employee());
                //return PartialView("_AddOrEdit", new Employee());

            }
            else
            {
                //Update
                var employeeModel = await _appContext.Employees.FindAsync(empid);
                //if (employeeModel == null)
                //{
                //    return NotFound();
                //}
                return View(employeeModel);
                //return PartialView("_AddOrEdit", employeeModel);
            }            
        }
    }
}
