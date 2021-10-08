project steps:
2021-10-02  8:30pm
-Review my product"soap"  and conduct an investigation into this  object's unique characteristics, structure, and attributes.
-Find a perfect name for the website -> I have named it "soapure".
-finding attributes to my project-> name /fetured ingredients/ color/ price / rate 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-03 9:42pm
- start to build my web app with individual user acounts autherntication and configure for https.
- adding helloWorldController.
- modify the HelloWorldController class to use Razor view files.
-modify Views/shared/_Layout.cshtml and add the website in the left side of the navigation bar + adding "our soaps" to the navigation bar to explore the products.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-04  1:32pm
-Examine the Views/_ViewStart.cshtml file
-Examine the Views/HelloWorld/Index.cshtml view file
-In Views/HelloWorld/Index.cshtml view file I've set the Title property of the ViewData dictionary to "Soap List" and set the h2 also to Soap List.(part 3 of the toturial)
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-06 9:33am
(part3 of the toturial)
-reviewing HelloWorldController.cs and changing the Welcome method to add a Message and NumTimes value to the ViewData dictionary.
-Creating a Welcome view template named Views/HelloWorld/Welcome.cshtml that create a loop in the Welcome.cshtml view template that displays "Hello" NumTimes. 
(part 4 of the toturial)
- add a model class and name it Soap.cs and adding five attributes(Id, ProductName,MainIngredient,Color, Price,Rate).
-Adding NuGet packages.
-Scaffolding soap pages.
-Examine the generated database context class and registration.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-07 9:32pm
-examine appsettings.json.
-Examine the Migrations/{timestamp}_InitialCreate.cs migration file.
- logging sql statment in appsettings.development.json.
(part5 of the toturial)
-Examine the database.//can't find soap table:(
-Create a new class named SeedData in the Models folder and seed the database with 10 records.
-Add the seed initializer in  Program.cs .
(Part6 of the toturial)
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-08 9:38Am
- Change the display name to some atribute in soap.cs ,also adding data annotation to the price.
- Review Views/Soaps/Index.cshtml file.
- make changes in view/soaps/ pages to remove the colomn of image url and just diplay the image in details.
(Part7 of the toturial)
2021-10-08 11:16am
-Updating the Index method found inside Controllers/MoviesController.cs .
-Opening the Views/Movies/Index.cshtml file, and adding the <form> markup.
-Adding the following SoapMainIngredientViewModel class to the Models folder to search by main ingredient of the soap
-Update Index.cshtml found in Views/Movies/ to Add search by main ingredient to the Index view
(Part 8 of the toturial)
