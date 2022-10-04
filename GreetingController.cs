using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BadurinaLinda_HTTP5112_Assignment1C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        /*
        Returns "Hello World!" when 
        curl -d "" "http://localhost/api/Greeting"
        is input in the terminal. 
        */
        public String Post() 
        {
           return "Hello World!";
        }

        [Route("{id}")]
        /*
        Returns "Greetings to {id} people!", where {id} is the input number.
        Examples:
        If 5 is input, "Greetings to 5 people!" is output
        If -5 is input, "Greetings to -5 people!" is output, because there was no specification to invalidate negative integer inputs lol.
        If a non-integer is input, an error is thrown.
        */
        public String Post(int id) 
        {
            String greeting = "Greetings to " + id + " people!";
            return greeting;
        }
    }
}
