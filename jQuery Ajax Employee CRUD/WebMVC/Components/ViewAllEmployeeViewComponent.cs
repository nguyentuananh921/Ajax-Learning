using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Data;

namespace WebMVC.Components
{
    public class ViewAllEmployeeViewComponent: ViewComponent
    {
        private readonly ApplicationDbContext _appContext;

        public ViewAllEmployeeViewComponent(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var emplist = await _appContext.Employees.ToListAsync();           
            return View(emplist);
        }
    }
}
