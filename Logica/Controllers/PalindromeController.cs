using Microsoft.AspNetCore.Mvc;
using Logica.Models;
using Logica.Datos;

namespace Logica.Controllers
{
    public class PalindromeController : Controller
    {
        Logical _Logical = new Logical();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckPalindrome(PalindromeModel model)
        {
            if (ModelState.IsValid)
            {
                string word = model.Word.Replace(" ", string.Empty).ToLower();
                bool isPalindrome = _Logical.IsPalindrome(word);

                ViewBag.IsPalindrome = isPalindrome;
                ViewBag.Word = model.Word;

                return View("Result");
            }
            return View("Index");
        }

        public IActionResult Result()
        {
            return View();
        }


    }
}
