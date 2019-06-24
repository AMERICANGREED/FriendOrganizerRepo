using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<Friend> GetByIdAsync(int friendId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().SingleAsync(f=>f.Id == friendId);
            }
        }

        public async Task SaveAsync(Friend friend)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Friends.Attach(friend);
                ctx.Entry(friend).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
                
        }
    }


}



//using FriendOrganizer.DataAccess;
//using FriendOrganizer.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace FriendOrganizer.UI.Data
//{
//    //frienddataservice is our data service that for now provides fake data . but later we will use it to provide real data from a database 
//    public class FriendDataService : IFriendDataService
//    {
//        private Func<FriendOrganizerDbContext> _contextCreator;

//        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
//        {
//            _contextCreator = contextCreator;
//        }

//        public IEnumerable<Friend> GetAll() //the getall method will return all the friends in our collection 
//        {
//            //instead of using an actual database , here we will just use a yield statement to return a couple of friends 
//            //TODO: later we would want to load data from a real database 
//            //yield return new Friend { FirstName = "Thomas", LastName = "Huber" };
//            //yield return new Friend { FirstName = "Andreas", LastName = "Boehler" };
//            //yield return new Friend { FirstName = "Julia", LastName = "Huber" };
//            //yield return new Friend { FirstName = "Chrissi", LastName = "Egin" };


//            using (var ctx = _contextCreator())
//            {
//                return ctx.Friends.AsNoTracking().ToList();
//            }

//        }
//    }
//}
