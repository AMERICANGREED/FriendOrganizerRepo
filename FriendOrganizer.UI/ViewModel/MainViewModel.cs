using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
       



        public MainViewModel(INavigationViewModel navigationViewModel , IFriendDetailViewModel friendDetailViewModel)
        {
            NavigationViewModel = navigationViewModel;
            FriendDetailViewModel = friendDetailViewModel;
            
        }

        public INavigationViewModel NavigationViewModel { get; }
        public IFriendDetailViewModel FriendDetailViewModel { get; set; }

        public async Task LoadAsync() //method that specifies where you want to load your firends 
        {

            await NavigationViewModel.LoadAsync();
            
        }

    }
}



//using FriendOrganizer.Model;
//using FriendOrganizer.UI.Data;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FriendOrganizer.UI.ViewModel
//{
//    public class MainViewModel : ViewModelBase
//    {

//        //this is the Firends property 
//        public ObservableCollection<Friend> Friends { get; set; }

//        //we also need a selected freind property 
//        private Friend _selectedFriend;

//        public Friend SelectedFriend
//        {
//            get { return _selectedFriend; }
//            set
//            {
//                _selectedFriend = value;

//                //we can call the onproperty changed method in several ways 
//                // 1) OnPropertyChanged(nameof(SelectedFriend));
//                // 2) OnPropertyChanged("SelectedFriend");
//                // 3) OnPropertyChanged()  //can cll it without a paramter when we use CallerMeber name attribute and make the propertyName parameter optional 
//                //then compiler will automatically pass in the member name of the caller . in this case the meber name of the caller is SelectedFriend

//                OnPropertyChanged();
//                //when the selectedfriend poperty is set we need to notify the databindin that it has changed so that the UI elements can be updated 
//                //so we need to raise a property changed event in the setter 
//                //to nitify the databindings we need to implement Inotifyproperty changed on our view model (n this case MainViewModel)
//                //as we would need the property change event in different view models it might be a good idea to put its defineition in a base class including 
//                //the OnPropertychanged Helper method 
//            }
//        }


//        private IFriendDataService _friendDataService;



//        public MainViewModel(IFriendDataService friendDataService)
//        {
//            //initialize the Friends propery in the constructor 
//            Friends = new ObservableCollection<Friend>();
//            _friendDataService = friendDataService;
//        }

//        //create a load method to load your friends 
//        public void Load()
//        {
//            //get all your friends by claling the getall method on the data service 
//            var friends = _friendDataService.GetAll();

//            //call clear method on observable collection so you don't have duplicates if the load method is claled twice 
//            Friends.Clear(); 
//            foreach(var friend in friends)
//            {
//                //add each friend to observable collection 
//                Friends.Add(friend);
//            }
//        }

//        //this is a helper method to raise the  event (  public event PropertyChangedEventHandler PropertyChanged;) that the Inofiyproperty changed interface froces us to implement
//        //we can call this method from the setter of our properties 
//        //we can make the propertyName paramter optional and then use the caller member name attribute 
//        //private void OnPropertyChanged([CallerMemberName] string propertyName = null)
//        //{
//        //    //we first check if the PropertyChanged event is not null before we raise it by calling the invoke method 
//        //    //the sender is our mainviewmodel(represented as this)  and the argument is the name of the property that has changed 
//        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//        //}


//    }
//}
