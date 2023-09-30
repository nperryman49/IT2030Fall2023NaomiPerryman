In this week's lab, some changes and items were added to the web application. The homepage was set to two columns and the nav bar's 
background was changed according to bootstrap's CSS context classes.The "Welcome" heading was changed to reflect the name of the store.
A new view was added to add in an about page with the store's history, mission, and vision. In order to make the new About link work,
'I added an action method for the About Us page to the HomeController file. Following this, I added a model class for the ContactModel file
that holds string data for when a customer inputs their information using the DataAnnotations namespace and validation error messages.
I also added another view for the Contact Us page using a strongly typed view linking it to the model.The validation messages are set to 
display in red and title and heading were included for the Contact page. Also added were the store hours, number, email, and address.
Lastly, a new controller was added for the Contact page and two Index action methods were added. One of these uses the HttpGet attribute
and returns the Contact view; the other uses an HttpPost attribute and accepts the ContactModel object for the input, then returns 
a view of that model. 
