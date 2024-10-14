using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;

namespace Lambda_Expertion.Controllers
{
    public class MyFuncController : Controller
    {
        public IActionResult Index()
        {

            string res= Calculator(Devision).ToString();

            return Content(res);
        }



        public int Calculator(Func<int,int,int> func)
        {
            int res= func.Invoke(20, 5);
            return res;
        }
        private int Sum(int x , int y)
        {
            return x + y;
        }
        private int Devision(int x, int y)
        {
            return x / y;
        }





    }
}
