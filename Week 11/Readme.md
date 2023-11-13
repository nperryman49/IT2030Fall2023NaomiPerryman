For this week's lab, I worked with data validation and what was required for various input values. 
I added data validation to the FirstName and LastName data fields to the ContactModel, so they do not go beyond 30 characters. A custom error message was also 
added to these fields to let the user know that both these values cannot contain more than 30 characters or contain 
special characters or numbers.
THe phone number field was limited to 10 numerical digits using a RegularExpression and includes a custom error  message 
to the user.
In the ProductModel, I added data validation to ProductName, ProductDescription, and ProductImage
so that these fields are required and a custom error message to the user is included. 
For ProductPrice, I used the DataType attribute to apply currency to this field so it will display in decimal format. 
I added a link to an Events page which is part of the HomeController. 
On this Events view, I included a title, heading, and four events using Bootstrap's Card feature with images so that
each event is clearly separated from the other. 
Lastly, I added an action method to the HomeController that will display the Events page view. 
