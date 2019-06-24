
using System.ComponentModel.DataAnnotations;

namespace FriendOrganizer.Model
{
    public class Friend //this is out model class 
    {
        public int Id { get; set; }

        [Required]  //these are called annotations. so we are setting annotations for our properties 
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}


//using System.ComponentModel.DataAnnotations;

//namespace FriendOrganizer.Model
//{
//    public class Friend
//    {
//        [Key]
//        public int Id { get; set; }

//        [Required]
//        [StringLength(50)]
//        public string FirstName { get; set; }

//        [StringLength(50)]
//        public string LastName { get; set; }

//        [StringLength(50)]
//        public string Email { get; set; }

//    }
//}
