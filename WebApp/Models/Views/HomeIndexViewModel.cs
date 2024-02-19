using WebApp.Models.Sections;

namespace WebApp.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Ultimate Task Management Assistant";
    public ShowcaseViewModel Showcase { get; set; } = new ShowcaseViewModel
    {
        Id = "overview",
        ShowcaseImage = new() { ImageUrl = "/images/showcase-image.svg", AltText = "task management assistant image" },
        Title = "Task Management Assistant You're Going To Love",
        Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool",
        Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
        BrandsText = "Largest companies use our tool to work efficiently",
        Brands =
                [
                    new() { ImageUrl = "/images/showcase-first-logo.svg", AltText = "brand 1" },
                    new() { ImageUrl = "/images/showcase-second-logo.svg", AltText = "brand 2" },
                    new() { ImageUrl = "/images/showcase-third-logo.svg", AltText = "brand 3" },
                    new() { ImageUrl = "/images/showcase-fourth-logo.svg", AltText = "brand 4" }
                ]
    };


    public FeaturesViewModel Features { get; set; } = new FeaturesViewModel
    {
        Id = "features",
        Title = "What Do You Get With Our Tool?",
        Text = "Make sure all your tasks are organized so you can set the priorities and focus on what's important.",
        FeatureBoxes =
                [
                    new() { IconSource = "/images/icons/chat.svg", Title = "Comment on Tasks", Description = "Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
                    new() { IconSource = "/images/icons/presentation.svg", Title = "Tasks Analytics", Description = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate." },
                    new() { IconSource = "/images/icons/add-group.svg", Title = "Multiple Assignees", Description = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris." },
                    new() { IconSource = "/images/icons/bell.svg", Title = "Notifications", Description = "Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra." },
                    new() { IconSource = "/images/icons/test.svg", Title = "Sections & Subtasks", Description = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus." },
                    new() { IconSource = "/images/icons/shield.svg", Title = "Data Security", Description = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras." }
                ]

    };

    public LightDarkViewModel LightDark { get; set; } = new LightDarkViewModel
    {
        Id = "light-dark",
        Image = new() { ImageUrl = "/images/slider.svg", AltText = "light and dark mode image" }
    };

}
