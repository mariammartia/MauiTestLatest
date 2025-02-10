using MauiTestLatest.Models;
using MauiTestLatest.PageModels;

namespace MauiTestLatest.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    //protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //  base.OnNavigatedTo(args);

    //  // Check and request permissions when the page is navigated to
    //  await CheckAndRequestPermissions();
    //}
    private async void OnCheckPermissionsClicked(object sender, EventArgs e)
    {
      await CheckAndRequestPermissions();
    }

    private async Task CheckAndRequestPermissions()
    {
      // Camera permission
      var cameraStatus = await Permissions.CheckStatusAsync<Permissions.Camera>();
      //if (cameraStatus != PermissionStatus.Granted)
      //{
        cameraStatus = await Permissions.RequestAsync<Permissions.Camera>();
        if (cameraStatus != PermissionStatus.Granted)
        {
          await DisplayAlert("Permission Denied", "Camera permission is required.", "OK");
          return;
        }
      //}

      // Storage read permission
      var storageReadStatus = await Permissions.CheckStatusAsync<Permissions.StorageRead>();
      if (storageReadStatus != PermissionStatus.Granted)
      {
        storageReadStatus = await Permissions.RequestAsync<Permissions.StorageRead>();
        if (storageReadStatus != PermissionStatus.Granted)
        {
          await DisplayAlert("Permission Denied", "Storage permission is required.", "OK");
          return;
        }
      }

      // Proceed with functionality after permissions are granted
      ProceedWithAppFunctionality();
    }

    private void ProceedWithAppFunctionality()
    {
      // Your app's functionality
    }
  }
}