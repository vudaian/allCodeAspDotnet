using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiepNhanThamSo.Models;

namespace TiepNhanThamSo.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>()
        {
            new Student() {StudentId = "101", FullName = "Vu Dai An", Address = "Thai Binh"},
            new Student() {StudentId = "102", FullName = "Nguyễn Xuân Trường", Address = "Nam Định"},
            new Student() {StudentId = "103", FullName = "Phan Đình Trạc", Address = "Hà Nam"},
            new Student() {StudentId = "104", FullName = "Hoàng Mai", Address = "Hà Nội"}
        };
        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }

        ////Tiep nhan tham so
        //public IActionResult Save()
        //{
        //    Student student = new Student();
        //    student.StudentId = Request.Form["StudentId"];
        //    student.FullName = Request.Form["FullName"];
        //    student.Address = Request.Form["Address"];
        //    students.Add(student);
        //    return RedirectToAction("Index");
        //}

        ////2. Su dung IFormCollection
        //public IActionResult Save(IFormCollection form)
        //{
        //    Student student = new Student();
        //    student.StudentId = form["StudentId"];
        //    student.FullName = form["FullName"];
        //    student.Address = form["Address"];
        //    students.Add(student);
        //    return RedirectToAction("Index");
        //}

        ////3. Su dung doi so Action, chi nhan cac tham so trung ten
        public IActionResult Save(string studentId, string fullName, string address)
        {
            Student student = new Student();
            student.StudentId = studentId;
            student.FullName = fullName;
            student.Address = address;
            students.Add(student);
            return RedirectToAction("Index");
        }

        //4. Su dung model 
        // - Tao model chua cac thuoc tinh trung ten vs ten cua cac tham so
        // - Su dung model la doi so cua action de nhan cac tham so trung ten
        //[ActionName("Store")]
        //public IActionResult Save(Student student)
        //{
        //    students.Add(student);
        //    return RedirectToAction("Index");
        //}
    }
}
