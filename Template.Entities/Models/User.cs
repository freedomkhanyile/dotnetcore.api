using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Template.Entities.Models
{
    [Table("users")]
    public class User : IEntity
    {
        [Key]
        [Column("UserId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[Required(ErrorMessage = "Phone Number is required")]
        //public string ContactNumbers { get; set; }

        //[Required(ErrorMessage = "Address is required")]
        //public string AddressLine1 { get; set; }
        //[Required(ErrorMessage = "Address Line 2 is required")]
        //public string AddressLine2 { get; set; }

        //public string AddressLine3 { get; set; }

        //[Required(ErrorMessage = "City is required")]
        //public string City { get; set; }

        //[Required(ErrorMessage = "PostCode is required")]
        //public string PostCode { get; set; }
        //[Required(ErrorMessage = "Identity number is required")]
        //public string IDNumber { get; set; }
        //public string Role { get; set; }
        //public string Benefactor { get; set; }
        //[Required(ErrorMessage = "Create User ID is required")]
        //public string CreateUserId { get; set; }
        //[Required(ErrorMessage = "Create Date is required")]
        //public DateTime CreateDate { get; set; }
        //public string ModifyUserId { get; set; }
        //public DateTime? ModifyDate { get; set; }

        [Required(ErrorMessage = "Status Id is required")]
        public int StatusId { get; set; }
    }
}
