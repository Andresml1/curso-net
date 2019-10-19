using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using TGL.WebApp.Data;
using TGL.WebApp.Models;
using TGL.WebApp.Pages.Students;

namespace TGL.WebApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        public StudentStore StudentStore { get; set; }
        public List<Student> Students { get; set; }
        public IndexModel(StudentStore studentStore)
        {
            StudentStore = studentStore;
            Students = StudentStore.GetStudents();

        }

        public IActionResult OnPostDelete(Guid id)
        {
            StudentStore.DeleteStudent(id);
            return RedirectToPage();
        }
        public void OnGet()
        {


        }
    }
}
