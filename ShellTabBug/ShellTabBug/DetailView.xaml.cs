using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTabBug;

public partial class DetailView : ContentPage
{
    public DetailView()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(AssistantPage)}");
    }
}