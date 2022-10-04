# LindaBadurina-HTTP-5112-0NA_Assignment1

# Preliminary Notes:
-Apologies for submitting this after the due date; I'm slowly making my way towards being back on track, and happy to say that I'm almost there (I'm the student who somehow managed to email my life story to your mother instead of you).
-Github got angry at me when I attempted to upload the full project because it had over 100 files. I'm assuming that you want to only see the code we made anyway?
-Ran into some issues due to having one of the newer Macbooks with the M2 chips, which don't allow for bootcamp. Due to the cost of buying the software for a virtual machine, I opted to wrestle with figuring out Visual Studio for Mac instead, with the plan to use a virtual machine only as a last resort. After a bit of confusion due to the differences in the Mac vs Window software and instructions from your videos, it turns out that VS 2022 for Mac actually runs fairly well! No issues (yet).

# Actual Assignment Notes: 

# Question 1: AddTen Controller:
Adds 10 to the input integer, and returns the result.
  Examples of functioning code gathered through testing:
  If 21 is input, 31 is output.
  If -9 is input, 1 is output.
  If a non-integer is input, an error is thrown.

# Question 2: Square Controller
Multiplies the input integer by itself, and returns the result.
  Examples gathered through testing:
  If 2 is input, 4 is output.
  If 25 is input, 625 is output.
  If -5 is input, 25 is output.
  If a non-integer is input, an error is thrown.

# Question 3+4 Greetings Controller:
Successfully returns "Hello World!" when curl -d "" "http://localhost/api/Greeting is input in the terminal.
Returns "Greetings to {id} people!", where {id} is the input number.
  Examples:
  If 5 is input, "Greetings to 5 people!" is output
  If -5 is input, "Greetings to -5 people!" is output, because there was no specification to invalidate negative integer inputs lol.
  If a non-integer is input, an error is thrown.

# Question 5: Number Machine
'n' stands for "number". So our 'int n' is the number we put through our number machine! Multiplies the input number by 7, and subtracts 9 from the result. It is divided by 7 and becomes the remainder of that operation, and then the result is squared.
Examples:
  If 5 is input, 25 is output. (5 * 7 = 35, 35 - 9 = 26, 26 % 7 = 5, 5^2 = 25)
  If -5 is input, 4 is output. (-5 * 7 = -35, -35 - 9 = -44, -44 % 7 = 2, 2^2 = 4)
  If 10 is input, 25 is output. (10 * 7 = 70, 70 - 9 = 61, 61 % 7 = 5, 5^2 = 25)
  Funnily enough, the output is always 4 if the input number is 1 or lower, and the output is always 25, otherwise.
  If a non-integer is input, an error is thrown.

# Question 6: Initiative Question
n stands for number, so our int n is the number we take the value of the input number from to manipulate!
net is net spending: the cost of the web hosting and maintenance before tax.
tax is the HST: 13% of net spending.
total is total spending: net + tax.
Our method takes the input value and makes a decision. If the input value is less than 14, we charge for 1 fortnight.
Otherwise, we charge for 1 fortnight plus the amount returned by dividing the input number by 14. This ensures that if a customer uses the service for 28 days, for instance, they're charged for the extra fortnight period after their first 2 they used up, since using the service on the 28th day enters a 3rd fortnight of use.
We create a double named net, which is the amount of calculated fortnight periods (n) times 5.5 (the price), we create another double, tax, which is the tax rate (0.13) times the price, and we create a 3rd double named total, which is the total net cost plus the total cost in taxes.
We then round total to 2 decimal places (to match example outputs provided in the assignment description), and create the 3 strings described in the assignment description.
We then return an array containing the 3 strings, in order.
  Examples used for testing:
  If 0 is input, "["1 fortnights at %5.50/FN = $5.5CAD","HST 13% = $0.7150000000000001 CAD","Total = $6.22 CAD"]" is output.
  If 28 is input, "["3 fortnights at %5.50/FN = $16.5CAD","HST 13% = $2.145 CAD","Total = $18.64 CAD"]" is output.
  If -56 is input, "["1 fortnights at %5.50/FN = $5.5CAD","HST 13%
  = $0.7150000000000001 CAD","Total = $6.22 CAD"]" is output. This is because the project specification
  never required negative values to be invalidated.
  If 6700 is input, "["479 fortnights at %5.50/FN = $2634.5CAD","HST 13% = $342.485 CAD","Total = $2976.98 CAD"]" is output.
  If a non-integer is input, an error is thrown.

Running code in VS shows no errors for entire project. Runs successfully.
