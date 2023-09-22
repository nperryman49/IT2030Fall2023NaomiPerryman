-In this lab, we had a tip calculator to debug and fix using various tools including the error list window, developer tools, breakpoints, and the Internal Server Error page. 

After downloading the program, I used the error list in VS to fix the syntax errors which included: 
  -the HomeController.cs file contained mulitple viewBag statements, but one of these had "viewbag" instead of "viewBag". Here I changed the lowercase "b" to an uppercase "B". 
  -in the TipCalculator.cs page, line 16, within the if statement, was missing a semi-colon after the return tip statement.
  -a return statement was added in the homecontroller.cs page in the public IActionResult Index() method

On the Internal Service Error page, it contained an error with a stack trace leading to: 
  -the index.cshtml file in line 16 where "Fifteem" should be corrected to "Fifteen"

In the developer tools:
  -in the CSS file, "width" was mispelled and was corrected 

In the tipcalculator.cs page: 
  -a breakpoint was set to step through the code and discover the math error that led to the incorrect tip amount
  -instead of "/ percent", the code was changed to "* percent" to display the correct tip amount

After these corrections were made nad saved: 
  -the tip calculator displayed the correct tip amount for the entered amount of cost
