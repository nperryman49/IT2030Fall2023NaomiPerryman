Weekly Summary

For this weeks's lab, after creating a link to the products page on the Layout file, I created the ProductModel file to store the properties of each of the items. Another model class was created to store the products in a list using the List<T> generic collection class. In this model, there are two methods- one that displays a list of all products and one that accepts the product id to return the specific product. 
After the model classes, a views were created. One view was to list the products and one was to display a detailed view of each product. 
Both of these views use tables to display information that are responsive and have hover settings. The header of both tables were changed to a different color using the Bootstrap CSS classes. Below the product list table is a button to direct the user back to the home page. Below the product detail page is a button to direct the user back to the list of products view.
A product controller was added that brought together both the model and views. Two action methods were added. One listed all products from the ProductData class and returns a view. 
The other action method accepted an id number for a product and returns the detail view for the particular product.
