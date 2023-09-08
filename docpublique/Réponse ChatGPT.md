To create detail views for Bob, Alice, and Cedric, you'll need to make several modifications to your HTML and controller code. It looks like you're working with ASP.NET Core, so I'll provide a step-by-step guide for achieving this.

**1. Create a Model:**

First, create a model class to represent your robots. Assuming you have a model class named `Robot`:

```csharp
public class Robot
{
    public int Id { get; set; }
    public string Name { get; set; }
    // Add other properties as needed
}
```

**2. Create a Controller:**

Next, create a controller (e.g., `RobotsController`) to handle requests for viewing robot details:

```csharp
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class RobotsController : Controller
{
    private readonly List<Robot> _robots = new List<Robot>
    {
        new Robot { Id = 1, Name = "Bob" },
        new Robot { Id = 2, Name = "Alice" },
        new Robot { Id = 3, Name = "Cedric" },
    };

    public IActionResult Index()
    {
        return View(_robots);
    }

    public IActionResult Detail(int id)
    {
        var robot = _robots.FirstOrDefault(r => r.Id == id);
        if (robot == null)
        {
            return NotFound();
        }

        return View(robot);
    }
}
```

In this controller, we have an `Index` action to list all robots and a `Detail` action to display details for a specific robot based on its `Id`.

**3. Create Views:**

Create the corresponding views for your actions. In the `Views/Robots` folder, create two views: `Index.cshtml` and `Detail.cshtml`.

`Index.cshtml` (List all robots):

```html
@model List<Robot>

@{
    ViewData["Title"] = "Robot List";
}

<h1>Robot List</h1>

<ul>
    @foreach (var robot in Model)
    {
        <li><a href="@Url.Action("Detail", "Robots", new { id = robot.Id })">@robot.Name</a></li>
    }
</ul>
```

`Detail.cshtml` (Display details for a single robot):

```html
@model Robot

@{
    ViewData["Title"] = "Robot Details";
}

<h1>Robot Details</h1>

<p>ID: @Model.Id</p>
<p>Name: @Model.Name</p>

<!-- Add other robot details here as needed -->
```

**4. Update Your HTML:**

Modify your existing HTML page to link to the robot details:

```html
<!DOCTYPE html>
<html lang="fr">
<head>
    <!-- ... (your existing head content) -->
</head>
<body>
    <style>
        /* ... (your existing styles) */
    </style>
    <div class="vertical-menu">
        <p>Robot</p>
        <ul>
            <li><a href="@Url.Action("Detail", "Robots", new { id = 1 })" title="voir Bob">Bob</a></li>
            <li><a href="@Url.Action("Detail", "Robots", new { id = 2 })" title="voir Alice">Alice</a></li>
            <li><a href="@Url.Action("Detail", "Robots", new { id = 3 })" title="voir Cedric">Cedric</a></li>
        </ul>
    </div>
    <div class="rectangle">
        <!-- This is where the details will be displayed -->
    </div>
</body>
</html>
```

Now, when you click on the links for Bob, Alice, or Cedric, it will take you to the respective detail views where you can display additional information about each robot. Make sure that the controller and view names match the naming conventions in your ASP.NET Core application.