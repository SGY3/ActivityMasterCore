using ActivityMasterCore.Data;
using ActivityMasterCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActivityMasterCore.Controllers
{
    public class ProjectTypeController : Controller
    {
        private readonly DataContext _context;
        public ProjectTypeController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Section of Project Type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            var projectType = _context.ProjectType.ToList();
            return View(projectType);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var projectType = _context.ProjectType.Where(x => x.Id == id).FirstOrDefault();
            return View(projectType);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var projectType = _context.ProjectType.Where(x => x.Id == id).FirstOrDefault();
            return View(projectType);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var projectType = _context.ProjectType.Where(x => x.Id == id).FirstOrDefault();
            return View(projectType);
        }
        /// <summary>
        ///  Post Section of Project Type
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(ProjectType projectType)
        {
            _context.ProjectType.Add(projectType);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(ProjectType projectType)
        {
            _context.ProjectType.Update(projectType);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(ProjectType projectType)
        {
            _context.ProjectType.Remove(projectType);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
