using Microsoft.UI;
using Uno.Toolkit.UI;

namespace DrawerControlSafeAreaTest.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void OpenDrawer_Click(object sender, RoutedEventArgs e)
    {
        this.Drawer.FitToDrawerContent = true;
        var popup = new Grid();
        popup.Background = new SolidColorBrush(Colors.Red);
        popup.Width = 200;
        popup.Height = 200;
        this.Drawer.OpenDirection = DrawerOpenDirection.Up;
        this.Drawer.DrawerContent = popup;
        this.Drawer.IsOpen = true;
        return;
    }
}
