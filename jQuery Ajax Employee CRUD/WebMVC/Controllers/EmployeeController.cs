using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Data;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _appContext;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public EmployeeController(ApplicationDbContext appContext, IWebHostEnvironment hostingEnvironment)
        {
            _appContext = appContext;
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            return View();

        }
        //public IActionResult GetMyViewComponent(int uid) //Ajax Parameter
        //{
        //    return ViewComponent("AddOrUpdateEmployee", new { empid = uid });//it will call Follower.cs InvokeAsync, and pass id to it.
        //}
        //GET
        public IActionResult AddOrEdit(int uid) //Ajax Parameter
        {
            return ViewComponent("AddOrUpdateEmployee", new { empid = uid });//it will call Follower.cs InvokeAsync, and pass id to it.
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int EmployeeID, [Bind("EmployeeID,Name,Position,Office,Salary,ImagePath,ImagePath")] Employee inputEmp)
        {
            if (ModelState.IsValid)
            {
                if (EmployeeID == 0)
                {
                    //Add employee here
                    //transactionModel.Date = DateTime.Now;
                    _appContext.Add(inputEmp);
                    await _appContext.SaveChangesAsync();                    
                }
                else
                {
                    //Update employee here

                    try
                    {
                        _appContext.Update(inputEmp);
                        await _appContext.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!EmployeeModelExists(inputEmp.EmployeeID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    

                }
                return View("Index");
            }
            return ViewComponent("AddOrUpdateEmployee", inputEmp);

        }
        private bool EmployeeModelExists(int id)
        {
            return _appContext.Employees.Any(e => e.EmployeeID == id);
        }

        //public async Task<ActionResult> ViewAll()
        //{
        //    return View(await _appContext.Employees.ToListAsync());

        //}        

        //// GET: EmployeeController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: EmployeeController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: EmployeeController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        ////GET
        //public async Task<IActionResult> AddOrEdit(int empid=0)
        //{
        //    if (empid == 0)
        //    {
        //        //Add new 
        //        //return View();
        //        //return View(new Employee());
        //        return PartialView("_AddOrEdit", new Employee());

        //    }
        //    else
        //    {
        //        //Update
        //        var employeeModel = await _appContext.Employees.FindAsync(empid);
        //        if (employeeModel == null)
        //        {
        //            return NotFound();
        //        }
        //        //return View(employeeModel);
        //        return PartialView("_AddOrEdit", employeeModel);
        //    }            
        //}
        //// GET: EmployeeController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: EmployeeController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: EmployeeController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: EmployeeController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
