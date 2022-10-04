using BadurinaLinda_HTTP5112_Assignment1C.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BadurinaLinda_HTTP5112_Assignment1C.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class AddTenController : ControllerBase
    {
        /*
        Adds 10 to the input integer, and returns the result. 
        Examples:
        If 21 is input, 31 is output. 
        If -9 is input, 1 is output.
        If a non-integer is input, an error is thrown.
        */
        public int Get(int id)
        {
            return id + 10;
        }

    }
}
