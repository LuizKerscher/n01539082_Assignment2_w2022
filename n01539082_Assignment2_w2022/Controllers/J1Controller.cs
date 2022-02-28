using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01539082_Assignment2_w2022.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int calories = 0;
            switch (burger)
            {
                case 1:
                    calories = calories + 461;
                    break;
                case 2:
                    calories = calories + 431;
                    break;
                case 3:
                    calories = calories + 420;
                    break;
                default:
                    break;
            }

            switch (drink)
            {
                case 1:
                    calories = calories + 130;
                    break;
                case 2:
                    calories = calories + 160;
                    break;
                case 3:
                    calories = calories + 118;
                    break;
                default:
                    break;
            }

            switch (side)
            {
                case 1:
                    calories = calories + 100;
                    break;
                case 2:
                    calories = calories + 57;
                    break;
                case 3:
                    calories = calories + 70;
                    break;
                default:
                    break;
            }

            switch (dessert)
            {
                case 1:
                    calories = calories + 167;
                    break;
                case 2:
                    calories = calories + 266;
                    break;
                case 3:
                    calories = calories + 75;
                    break;
                default:
                    break;
            }

            return "Your total calorie count is " + calories;
        }
    }
}
