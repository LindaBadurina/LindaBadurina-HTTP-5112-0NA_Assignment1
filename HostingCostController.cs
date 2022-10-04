using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BadurinaLinda_HTTP5112_Assignment1C.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class HostingCostController : ControllerBase
    {
        /*
        n stands for number, so our int n is the number we take the value of the input number from to manipulate!
        net is net spending: the cost of the web hosting and maintenance before tax.
        tax is the HST: 13% of net spending. 
        total is total spending: net + tax.


        Our method takes the input value and makes a decision. If the input value is less than 14, we charge for 1 fortnight.
        Otherwise, we charge for 1 fortnight plus the amount returned by dividing the input number by 14. This ensures that if a customer uses the service for 28 days, for instance, 
        they're charged for the extra fortnight period after their first 2 they used up, since using the service on the 28th day enters a 3rd fortnight of use.
        We create a double named net, which is the amount of calculated fortnight periods (n) times 5.5 (the price), we create another double, tax, which is the tax rate (0.13) times the price,
        and we create a 3rd double named total, which is the total net cost plus the total cost in taxes.
        We then round total to 2 decimal places (to match example outputs provided in the assignment description), and create the 3 strings described in the assignment description.
        We then return an array containing the 3 strings, in order.

        Examples:
        
        If 0 is input, "["1 fortnights at %5.50/FN = $5.5CAD","HST 13% = $0.7150000000000001 CAD","Total = $6.22 CAD"]" is output.

        If 28 is input, "["3 fortnights at %5.50/FN = $16.5CAD","HST 13% = $2.145 CAD","Total = $18.64 CAD"]" is output.

        If -56 is input, "["1 fortnights at %5.50/FN = $5.5CAD","HST 13% = $0.7150000000000001 CAD","Total = $6.22 CAD"]" is output. This is because the project specification never required negative values to be invalidated.

        If 6700 is input, "["479 fortnights at %5.50/FN = $2634.5CAD","HST 13% = $342.485 CAD","Total = $2976.98 CAD"]" is output.

        If a non-integer is input, an error is thrown.
        */
        public String[] Get(int id) 
        {
            int n;
            if (id < 14)
            {
                n = 1;
            }
            else 
            {
                n = (id / 14) + 1;
            }
            double net = n * 5.5;
            double tax = net * .13;
            double total = tax + net;
            total = Math.Round(total, 2);
            String statement1 = n + " fortnights at %5.50/FN = $" + net + "CAD";
            String statement2 = "HST 13% = $" + tax + " CAD";
            String statement3 = "Total = $" + total + " CAD";
            return new string[] { statement1, statement2, statement3 };
        }
    }
}
