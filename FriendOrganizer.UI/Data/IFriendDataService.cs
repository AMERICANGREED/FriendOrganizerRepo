using System.Collections.Generic;
using System.Threading.Tasks;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(int friendId);
        Task SaveAsync(Friend friend);
    }
}

//using System.Collections.Generic;
//using FriendOrganizer.Model;

//namespace FriendOrganizer.UI.Data
//{
//    //this interface can be used by our view model 

//    public interface IFriendDataService
//    {
//        IEnumerable<Friend> GetAll();
//    }
//}