using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01539082_Assignment2_w2022.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int totalWays = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i + j) == 10)
                    {
                        totalWays++;
                    }
                }
            }
            
            if (totalWays == 1)
            {
                return "There is " + totalWays + " ways to get the sum 10.";
            }
            else
            {
                return "There are " + totalWays + " ways to get the sum 10.";
            }
        }
    }
}
