namespace ShellTabBug;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(DetailView), typeof(DetailView));
        Routing.RegisterRoute(nameof(AssistantPage), typeof(AssistantPage));
    }
}