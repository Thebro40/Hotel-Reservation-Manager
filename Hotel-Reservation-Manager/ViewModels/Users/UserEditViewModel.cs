using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_Manager.ViewModels.Users
{
    public class UserEditViewModel: UserCreateViewModel
    {
        public string Id { get; set; }
        [DisplayName("Change Password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}
