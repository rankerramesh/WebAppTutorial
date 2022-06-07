using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTutorial.EntityDAL;

namespace WebAppTutorial.Controllers
{
    public class EmployeeController : Controller
    {
        EntityContext _context;
        public EmployeeController(EntityContext context)
        {
            _context = context;
        }

        #region Posts 
        public IActionResult Posts()
        {
            List<Post> posts = _context.Posts.ToList();
            return View(posts);
        }
        public IActionResult PostCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostCreate(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return RedirectToAction("Posts");
        }

        public IActionResult PostEdit(int Id)
        {
            Post post = _context.Posts.Find(Id);
            return View(post);
        }
        [HttpPost]
        public IActionResult PostEdit(Post post)
        {
            _context.Attach<Post>(post);
            _context.Entry(post).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Posts");
        }
        public IActionResult PostDelete(int Id)
        {
            Post post = _context.Posts.Find(Id);
            return View(post);
        }
        [HttpPost]
        public IActionResult PostDelete(Post post)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges();
            return RedirectToAction("Posts");
        }
        #endregion

        #region Employee

        public IActionResult Employees()
        {
            List<PersonInfo> personInfos = _context.Persons.Include(x => x.Post).ToList();
            return View(personInfos);
        }
        public IActionResult EmployeeCreate()
        {
            ViewBag.PostId = new SelectList(_context.Posts.ToList(), "PostId", "PostName");
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeCreate(PersonInfo employee)
        {
            _context.Persons.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Employees");
        }

        public IActionResult EmployeeEdit(int Id)
        {
            PersonInfo person = _context.Persons.Find(Id);
            ViewBag.PostId = new SelectList(_context.Posts.ToList(), "PostId", "PostName", person.PostId);
            return View(person);
        }
        [HttpPost]
        public IActionResult EmployeeEdit(PersonInfo employee)
        {
            _context.Attach<PersonInfo>(employee);
            _context.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Employees");
        }
        public IActionResult EmployeeDelete(int Id)
        {
            PersonInfo person = _context.Persons.Include(x => x.Post).Where(x=>x.PersonId==Id).FirstOrDefault();
            return View(person);
        }
        [HttpPost]
        public IActionResult EmployeeDelete(PersonInfo person)
        {
            _context.Persons.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Employees");
        }
        #endregion
    }
}
