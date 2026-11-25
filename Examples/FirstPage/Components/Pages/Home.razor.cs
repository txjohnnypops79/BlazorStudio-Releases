namespace StudioStock.Components.Pages;

public partial class Home
{
    private string message = "Ready to check stock.";
    private int checks;

    private void CheckStock()
    {
        checks++;
        message = $"Stock checked {checks} time(s).";
    }
}
