using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BadurinaLinda_HTTP5112_Assignment1C.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class NumberMachineController : ControllerBase
    {
        /*
        n stands for "number". So our int n is the number we put through our number machine!
        Multiplies the input number by 7, and subtracts 9 from the result. It is divided by 7 and becomes the remainder of that operation, and then the result is squared.
        Examples:
        If 5 is input, 25 is output. (5 * 7 = 35, 35 - 9 = 26, 26 % 7 = 5, 5^2 = 25)
        If -5 is input, 4 is output. (-5 * 7 = -35, -35 - 9 = -44, -44 % 7 = 2, 2^2 = 4)
        If 10 is input, 25 is output. (10 * 7 = 70, 70 - 9 = 61, 61 % 7 = 5, 5^2 = 25)
        Funnily enough, the output is always 4 if the input number is 1 or lower, and the output is always 25, otherwise.
        If a non-integer is input, an error is thrown.
        */
        public int Get(int id) 
        {
            int n = id;
            n *= 7;
            n -= 9;
            n = n % 7;
            n *= n;
            return n;
        }
    }
}
