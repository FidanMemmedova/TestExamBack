using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PeternaBack.Data;
using PeternaBack.Helpers;
using PeternaBack.Models;

namespace PeternaBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ServicesController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Services.ToListAsync());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!service.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("", "File must be image");
                return View();
            }            
            if (!service.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("", "File must be less than 200kb");
                return View();
            }
            string uniqueFileName = UploadedFile(service);
            service.Image = uniqueFileName;
            _context.Add(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private string UploadedFile(Service service)
        {
            string uniqueFileName = null;

            if (service.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + service.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    service.Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Service new_service)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!new_service.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("", "File must be image");
                return View();
            }
            if (!new_service.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("", "File must be less than 200kb");
                return View();
            }
            var old_service = await _context.Services.FindAsync(id);
            if (old_service==null)
            {
                return NotFound();
            }
            var path = Helper.GetPath(_env.WebRootPath, "img", old_service.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            new_service.Image = await new_service.Photo.SaveFileAsync(_env.WebRootPath, "img");
            old_service.Image = new_service.Image;
            old_service.ServiceName = new_service.ServiceName;
            old_service.Comment = new_service.Comment;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            var path = Helper.GetPath(_env.WebRootPath, "img", service.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
