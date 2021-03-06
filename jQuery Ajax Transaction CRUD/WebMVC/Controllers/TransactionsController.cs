using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC.Data;
using WebMVC.Models;
using WebMVC.Helper;

namespace WebMVC.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly TransactionDbContext _context;

        public TransactionsController(TransactionDbContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transactions.ToListAsync());
        }
        // GET: Transactions/AddOrEdit
        // GET: Transactions/AddOrEdit/5
        public async Task<IActionResult> AddOrEdit( int id=0)
        {
            if (id == 0)
            {
                //Add new 
                //return View();
                return View(new TransactionModel());
                
            }
            else
            {
                //Update
                var transactionModel = await _context.Transactions.FindAsync(id);
                if (transactionModel == null)
                {
                    return NotFound();
                }
                return View(transactionModel);

            }
                
        }        

        // POST: Transactions/AddOrEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("TransactionId,AccountNumber,BeneficiaryName,BankName,SWIFTCode,Amount,Date")] TransactionModel transactionModel)
        {
            //if (id != transactionModel.TransactionId)
            //{
            //    return NotFound();
            //}
           
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    //Add New
                    transactionModel.Date = DateTime.Now;
                    _context.Add(transactionModel);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    try
                    {
                        _context.Update(transactionModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!TransactionModelExists(transactionModel.TransactionId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }

                //return RedirectToAction(nameof(Index));
                //return Json(new {isValid=true,html=Helper.Helper.RenderRazorViewToString(this,"Index",_context.Transactions.ToList()) });
                var stringtxt = Helper.Helper.RenderRazorViewToString(this, "_ViewAll", _context.Transactions.ToList());
                return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "_ViewAll", _context.Transactions.ToList()) });
            }
            //return View(transactionModel);
            
            return Json(new { isValid = false, html = Helper.Helper.RenderRazorViewToString(this,"AddOrEdit",transactionModel) });
        }

        #region Delete
        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionModel = await _context.Transactions
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (transactionModel == null)
            {
                return NotFound();
            }

            return View(transactionModel);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionModel = await _context.Transactions.FindAsync(id);
            _context.Transactions.Remove(transactionModel);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));

            return Json(new {html = Helper.Helper.RenderRazorViewToString(this, "_ViewAll", _context.Transactions.ToList()) });
        }
        #endregion

        private bool TransactionModelExists(int id)
        {
            return _context.Transactions.Any(e => e.TransactionId == id);
        }
    }
}
