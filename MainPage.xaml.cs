using FlyoutProject.Models;

namespace FlyoutProject;

public partial class MainPage : FlyoutPage
{
	public MainPage()
	{
		InitializeComponent();

		flyoutPage.listView.ItemSelected += ListView_ItemSelected;
	}

	private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
        var item = e.SelectedItem as FlyoutPageItem;
        if (item != null)
        {
            Page page = (Page)Activator.CreateInstance(item.TargetType);
            Detail = new NavigationPage(page);
            //flyoutPage.listView.SelectedItem = null;
            //IsPresented = false;
        }
    }
}

