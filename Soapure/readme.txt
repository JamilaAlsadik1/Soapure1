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
-modify Views/shared/_Layout.cshtml and add the website in the left side of the navigation bar + adding "our product" to the navigation bar to explore the products.
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
- add a model class and name it Soap.cs and adding five attributes(Id, ProductName,MainIngredient,Color, Price,ImageUrl).
-Adding NuGet packages.
-Scaffolding soap pages.
-Examine the generated database context class and registration.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-07 9:32pm
-examine appsettings.json.
-Examine the Migrations/{timestamp}_InitialCreate.cs migration file.
- logging sql statment in appsettings.development.json.
(part5 of the toturial)
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
-Updating the Index method found inside Controllers/SoapsController.cs .
-Opening the Views/Soaps/Index.cshtml file, and adding the <form> markup.
-Adding the following SoapMainIngredientViewModel class to the Models folder to search by main ingredient of the soap
-Update Index.cshtml found in Views/Soaps/ to Add search by main ingredient to the Index view
(Part 8 of the toturial)
-Add a Rating Property to the Soap Model in  Models/Soap.cs.
-update the [Bind] attribute for both the Create and Edit action methods to include the Rating property in SoapsController.cs.
-Edit the /Views/Soaps/Index.cshtml file and add a Rating field.
Update the /Views/Soaps/Create.cshtml with a Rating field.
-Failed to migrat ->used Update-Database -Context SoapureContext and add-migration Rating -Context SoapureContext to solve it 
(Part9 of the toturial)
-adding validation rules to the soap model
//////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-12 9:52pm
- adding some content in about us and main page.
-adding some styles to the pages.
- change the header layout from _Layout.cshtml by making 
-Change the link for the website name to be linked to the home page not to the product table
//////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-13 9:29Am
- trying to add style to website name.
- I've added an inline style to the website name because it was the only way that's work.
-publish it in Azure
- When I try to open it in new device , I have to update database and aply migration ->used Update-Database -Context SoapureContext and add-migration  -Context SoapureContext to solve it 
-https://soapure.azurewebsites.net azure link
////////////////////////////////////////////////////////////////////////////////////////////////////////
2021-10-13 9:13pm
-Adding main readMe to github

