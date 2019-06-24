
using FriendOrganizer.UI.ViewModel;
using System.Windows;

namespace FriendOrganizer.UI
{

    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }
    }
}



//using FriendOrganizer.UI.ViewModel;
//using System.Windows;

//namespace FriendOrganizer.UI
//{

//    public partial class MainWindow : Window
//    {
//        private MainViewModel _viewModel;

//        //on the MainWinodw constructor we will define  a parameter of type MainViewModel 
//        public MainWindow(MainViewModel  viewModel)
//        {
//            InitializeComponent();

//            _viewModel = viewModel;

//            //we need to assign an instance of our MinViewModel to the DataContext Property of our MainWindow 
//            DataContext = _viewModel;

//            //use the loaded event handler for the main window to call the load method of the view model 

//            Loaded += MainWindow_Loaded;

//        }

//        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
//        {
//            //call the load method on the main view 
//            _viewModel.Load();
//        }
//    }
//}
