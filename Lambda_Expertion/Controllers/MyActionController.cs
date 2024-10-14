using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Lambda_Expertion.Controllers
{
    public class MyActionController : Controller
    {
        public IActionResult Index()
        {
            SayHello(Name);
            SayHello((x) => { Console.WriteLine("Hello " + x); });
            Calculator((x, y) => { Console.WriteLine($"{x} + {y} = {x + y}"); },5,6);
            Calculator((x, y) => { Console.WriteLine($"{x} / {y} = {x / y}"); }, 5, 6);
            Calculator((x, y) => { Console.WriteLine($"{x} * {y} = {x * y}"); }, 5, 6);
            Calculator((x, y) => { Console.WriteLine($"{x} - {y} = {x - y}"); }, 5, 6);


            return Content("ok");
        }

        public void SayHello(Action<string> action)
        {
            action.Invoke("Mohammadreza");
        }

        private void Name(string name)
        {

            Console.WriteLine("Hello " + name);
        }


        public void Calculator(Action<int,int> action,int x, int y)
        {
            action.Invoke(x, y);
        }

        //private void Sum(int x, int y)
        //{
        //    Console.WriteLine($"{x} + {y} = {x + y}");
        //}
        //private void Devision(int x, int y)
        //{
        //    Console.WriteLine($"{x} / {y} = {x / y}");
        //}

    }
}
