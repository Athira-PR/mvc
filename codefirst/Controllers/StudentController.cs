using codefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codefirst.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult List()
        {
            StudentContext db = new StudentContext();
            List<Student> li = db.Students.ToList();
            return View(li);
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Student s)
        {
            StudentContext db = new StudentContext();
            db.Students.Add(s);
            db.SaveChanges();

            return RedirectToAction("List");

        }

        public ActionResult delete(Student s)
        {
            StudentContext db = new StudentContext();
            var student = (from st in db.Students
                           where st.id == s.id
                           select st).FirstOrDefault();

            return View(student);
        }
        [HttpPost]
        public ActionResult delete(int id)
        {
            StudentContext db = new StudentContext();
            var student= (from st in db.Students
                          where st.id ==id
                          select st).FirstOrDefault();
            db.Students.Remove(student);
            db.SaveChanges();
            return View();

        }
        public ActionResult edit(int id)
        {
            StudentContext db = new StudentContext();
            var student = (from st in db.Students
                           where st.id ==id
                           select st).FirstOrDefault();

            return View(student);
        }
        [HttpPost]
        public ActionResult edit(Student s)
        {
            StudentContext db = new StudentContext();
            var student = (from st in db.Students
                           where st.id == s.id
                           select st).FirstOrDefault();
            student.Name = s.Name;
            student.place = s.place;
            student.phno = s.phno;
            db.SaveChanges();
            return View(student);
        }
        public ActionResult details(Student s)

        {
            StudentContext db = new StudentContext();
            var student = (from st in db.Students
                           where st.id == s.id
                           select st).FirstOrDefault();

            return View(student);
        }
        public ActionResult search()
        {
            return View();
        }

        public ActionResult Details_PV()

        {
            
            StudentContext db = new StudentContext();
            List<Student> li = db.Students.ToList();

            return PartialView(li);
        }

        
    }
}