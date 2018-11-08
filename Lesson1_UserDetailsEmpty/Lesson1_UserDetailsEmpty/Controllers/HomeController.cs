using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lesson1_UserDetailsEmpty.Models;

namespace Lesson1_UserDetailsEmpty.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView {id = 1, FirstName = "Иван", SurName = "Иванов", Patronymic = "Иванович", Age = 22, BirthDate = "07.07.1997", Position = "Стажер", Unit = "Техподдержка"},
            new EmployeeView {id = 2, FirstName = "Борис", SurName = "Борисов", Patronymic = "Борисович", Age = 21, BirthDate = "08.08.1998", Position = "Стажер", Unit = "Техподдержка"},
            new EmployeeView {id = 3, FirstName = "Василий", SurName = "Васечкин", Patronymic = "Васильевич", Age = 40, BirthDate = "01.01.1977", Position = "Начальник отдела", Unit = "Техподдержка"},
            new EmployeeView {id = 4, FirstName = "Петр", SurName = "Петров", Patronymic = "Петрович", Age = 33, BirthDate = "02.02.1986", Position = "Младший бухгалтер", Unit = "Бухгалтерия"},
            new EmployeeView {id = 5, FirstName = "Карпен", SurName = "Карпенко", Patronymic = "Карпенович", Age = 48, BirthDate = "03.03.1970", Position = "Старший Бухгалтер", Unit = "Бухгалтерия"},
            new EmployeeView {id = 6, FirstName = "Николай", SurName = "Николаев", Patronymic = "Николаевич", Age = 22, BirthDate = "04.04.1997", Position = "Стажер", Unit = "Отдел разработки"},
            new EmployeeView {id = 7, FirstName = "Александр", SurName = "Александров", Patronymic = "Александрович", Age = 35, BirthDate = "05.06.1985", Position = "Старший программист", Unit = "Отдел разработки"},
            new EmployeeView {id = 8, FirstName = "Вадим", SurName = "Вадимов", Patronymic = "Вадимович", Age = 43, BirthDate = "09.10.1975", Position = "Ведущий проекта", Unit = "Отдел разработки"},
        };

        public IActionResult Index()
        {
            return View(_employees);
            //return Content("Hello from controller!");
        }

        public IActionResult Details(int id)
        {
            return View(_employees.Where(item=>item.id.Equals(id)).First());
        }
    }
}