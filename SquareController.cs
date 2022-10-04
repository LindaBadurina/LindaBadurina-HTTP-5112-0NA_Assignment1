using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BadurinaLinda_HTTP5112_Assignment1C.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class SquareController : ControllerBase
    {
        /*
        Multiplies the input integer by itself, and returns the result.
        Examples: 
        If 2 is input, 4 is output.
        If 25 is input, 625 is output.
        If -5 is input, 25 is output. 
        If a non-integer is input, an error is thrown.
        */
        public int Get(int id)
        {
            return id * id;

        }
    }
}
