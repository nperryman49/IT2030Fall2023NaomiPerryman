In this lab, I made a link to an FAQ page and created the view for a frequently asked questions page using an accordian layout which I have seen on various websites. 
I also added code for required session state services to the Program.cs file. 
For the session data, I first added a MySession model to declare four variables before adding a link to the Tools view. 
In the HomeController file, I added two methods. One is to set and get the four values assigned to the four variables in the MySession model. This method had to be cancelled out due to errors when the Display 
Session Variables button was clicked. 
The second method displays the Tools view without the session variables. This second action method also had to be commented out due to conflicting routes when the project ran. 
The last step was to add a Tools view using a strongly typed view with the MySession model class. The four variables are displayed in a form much like the contact page. Two buttons were added. 
One is to display the session variables when clicked and the other button clears any data from the form. 
