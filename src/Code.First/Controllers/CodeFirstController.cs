using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Code.First.Models;
using Code.First.Data;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Code.First.Controllers
{
    [Route("api/[controller]")]
    public class CodeFirstController : Controller
    {
        private CodeFirstContext _context;

        public CodeFirstController(CodeFirstContext context)
        {
            _context = context;
        }


        [HttpGet]
        public JsonResult Get()
        {
            var genders = _context.Genders;

            var query = from g in genders
                        select new { g.GenderId, g.GenderName };

            List<Gender> GenderList = new List<Gender>();

            foreach (var item in query)
            {
                Gender gender = new Gender();
                gender.GenderId = item.GenderId;
                gender.GenderName = item.GenderName;
                GenderList.Add(gender);

            }

            return Json(GenderList);
        }
    }
}
