using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CalculatorController : Controller
    {
        private IUserService _userService;

        public CalculatorController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("discountcalculator")]
        
        public decimal DiscountCalculator(GoldDetailModel goldDetailModel)
        {
            var users = _userService.GetAll();
            decimal returnVal = 0.0M;
            if(goldDetailModel.Discount.Value==0 || goldDetailModel.Discount==null)
            {
                returnVal = goldDetailModel.GoldWeight * goldDetailModel.GoldPrice;
            }
            else
            {
                returnVal = goldDetailModel.GoldWeight * goldDetailModel.GoldPrice;
               decimal discountVal = returnVal * (goldDetailModel.Discount.Value / 100);
                returnVal = returnVal - discountVal;
            }
           
            return returnVal;
        }

    }
}
