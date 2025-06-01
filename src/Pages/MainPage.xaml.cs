using RPGMaster.Models;
using RPGMaster.PageModels;

namespace RPGMaster.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}