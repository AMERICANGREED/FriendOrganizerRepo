using Autofac;
using FriendOrganizer.DataAccess;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.ViewModel;
using Prism.Events;

namespace FriendOrganizer.UI.Startup
{
    public class Bootstrapper // this class is responsible to create  the autofac container 
                             //the container knows all the types and it's used to create instances 
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder(); // creat a container 

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();
            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>(); //the container will create an instance of the friendsdata service class whenever an Ifrienddataservice is rrequired
            return builder.Build(); //this statement returns the ocntainer from this bootstrap method 
        }
    }
}



//using Autofac;
//using FriendOrganizer.DataAccess;
//using FriendOrganizer.UI.Data;
//using FriendOrganizer.UI.ViewModel;

//namespace FriendOrganizer.UI.Startup
//{
//    //the bootstrapper class is responsible to create the autofac container 
//    //the container knows about all the types and is used to create instances 
//    public class Bootstrapper
//    {
//        public IContainer Bootstrap()
//        {
//            var builder = new ContainerBuilder();

//            //then register your types to the container builder 


//            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();

//            //with autofac we can also register concrete types that don't implement an interface if we want to resolve the concrete types from the container 
//            builder.RegisterType<MainWindow>().AsSelf();
//            builder.RegisterType<MainViewModel>().AsSelf();
//            builder.RegisterType<FriendDataService>().As<IFriendDataService>(); //this mean i want to use a frienddate service wheenever an Ifrienddataservice is required 
//            //so the container will automatically create an instance of frienddataservice whenever Ifrienddataservice is required 

//            //then we can create the container by calling the build method on the container builder
//            return builder.Build();
//        }
//    }
//}
