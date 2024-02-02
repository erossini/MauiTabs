namespace MauiTabs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        //private void radio_CheckedChanged(object sender, CheckedChangedEventArgs e)
        //{
        //    if (((RadioButton)sender).IsChecked)
        //    {
        //        string option = ((RadioButton)sender).BindingContext.ToString();
        //        if (labelSelection != null)
        //            labelSelection.Text = option;
        //    }
        //}
    }
}