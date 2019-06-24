
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendOrganizer.UI.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //helper method to raise the event 
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //check if the event is not null then raises the event 
        }
    }
}

//using System.ComponentModel;
//using System.Runtime.CompilerServices;

//namespace FriendOrganizer.UI.ViewModel
//{
//    public class ViewModelBase : INotifyPropertyChanged
//    {
//        public event PropertyChangedEventHandler PropertyChanged;

//        //because we would want to use this method from subclasses we will make it protected 
//        //because we would want sublcasses to override it we will make it virtual 
//        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
//        {
//            //we first check if the PropertyChanged event is not null before we raise it by calling the invoke method 
//            //the sender is our mainviewmodel(represented as this)  and the argument is the name of the property that has changed 
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//        }
//    }
//}
