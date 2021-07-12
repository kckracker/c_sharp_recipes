# Recipe App
___
## Summary

This application makes use of the MVC model of C# web applications and can best be understood by a brief description of each of its MVC components.

The Recipe model was added in the Models folder to define a get / set column storage for Title, Ingredients, Instructions, Cook Time, and Image Path. Cook Time is the only int type to record the number of minutes a particular recipe will require to cook.

The views Create, Details, Edit, Index, and Delete were all added to the Views folder via EF Core scaffolding tool as detailed at https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-5.0&tabs=visual-studio-mac. In generating a controller utilizing the ```dotnet-aspnet-codegenerator controller``` command, the CRUD views were placed inside the new Recipes folder under Views. I have customized the Index page to utilize Jumbotron and Cards from Bootstrap ( syntax sourced from https://getbootstrap.com/docs/4.0/components/jumbotron/ and https://getbootstrap.com/docs/4.0/components/card/ ) to display a full list of all stored recipes. The Details view also utilizes the Jumbotron classes from Bootstrap to layout a larger version of each recipe view. Edit places the selected recipe into an editable form to allow for re-submission of existing recipe. Create initializes an empty form for submission of a new recipe, including a form group syntax for File Browser ( syntax sourced from https://getbootstrap.com/docs/4.0/components/forms/ ). 

The RecipeController was also generated from the ```dotnet-aspnet-codegenerator controller``` command and placed inside the Controller folder. The file handles routing actions requested by user navigation. The navigation links found throughout the application views have been edited using ```asp-action``` and ```asp-route-id``` to allow the RecipeController to update the view and take appropriate action based on the URL. The Controller methods have built in error handling to re-route a request to NotFound(), for instance, if a recipe ID is requested for edit that does not exist in the database. The Controller contains ```Task<IActionResult>``` methods for each of the CRUD operations.

## Final Notes

The database is handled by a basic SQLite .db file and was established utilizing the codegenerator tool which placed reference to the newly created MvcRecipeContext within the ConfigureServices call within Startup.cs. Syntax for this was established in the CLI call but referenced at https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-5.0&tabs=visual-studio-code for better understanding.

In addition to Jumbotron, Cards, and File Browser, I referenced button and nav classes for the navigation buttons found on Index and Details ( sourced at https://getbootstrap.com/docs/4.0/components/navs/ and https://getbootstrap.com/docs/4.0/components/buttons/ ).

Thank you for reading me!
