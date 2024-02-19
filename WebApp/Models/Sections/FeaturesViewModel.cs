using WebApp.Models.Components;

namespace WebApp.Models.Sections;

public class FeaturesViewModel
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? Text { get; set; }
    public List<FeatureBoxViewModel>? FeatureBoxes { get; set; }

}
