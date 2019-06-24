
using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Startup;
using FriendOrganizer.UI.ViewModel;
using System;
using System.Windows;

namespace FriendOrganizer.UI
{

    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper(); // create a boostrapper 
            var container = bootstrapper.Bootstrap(); //create a container by calling the Bootsrap method on the bootstrapper 
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Unexpected erro occured" + Environment.NewLine + e.Exception.Message, "Unexpected error");
            e.Handled = true;
        }
    }
}


//using Autofac;
//using FriendOrganizer.UI.Data;
//using FriendOrganizer.UI.Startup;
//using FriendOrganizer.UI.ViewModel;
//using System.Windows;

//namespace FriendOrganizer.UI
//{

//    public partial class App : Application
//    {
//        private void Application_Startup(object sender, StartupEventArgs e)
//        {
//            //create an istance of Bottsrapper
//            var bootstrapper = new Bootstrapper();

//            //then call the bootsrapper method on the bootsrpaper
//            var container = bootstrapper.Bootstrap();

//            //then resolve the MainWindow
//            var mainWindow = container.Resolve<MainWindow>();
//            //the resolve method will got to the MainWindow constructor and it will see the it has to create a MainViewModel
//            //and it will go the MainViewModel constructor and it sees it has to create an IfriendDataService

//            ////instead of injecting all thiese dependencies manullay we are going to use a dependency injection framework 
//            //var mainWindow = new MainWindow(new MainViewModel(new FriendDataService()));
//            //mainWindow.Show();
//        }
//    }
//}
