using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Template.Entities.Models
{
    [Table("policyholder")]
    public class PolicyHolder : IEntity
    {
        [Key]
        [Column("PolicyHolderId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Policy ID is required")]
        public string PolicyId { get; set; }
        [Required(ErrorMessage = "User ID is required")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "PolicyType ID is required")]
        public string PolicyTypeId { get; set; }
        [Required(ErrorMessage = "Policy Name is required")]
        public string PolicyName { get; set; }
        [Required(ErrorMessage = "Sold Date is required")]
        public DateTime SoldDate { get; set; }

        [Required(ErrorMessage = "Premium Amount is required")]
        public double PremiumAmount { get; set; }

        [Required(ErrorMessage = "Create User ID is required")]
        public string CreateUserId { get; set; }
        [Required(ErrorMessage = "Create Date is required")]
        public DateTime CreateDate { get; set; }
        public string ModifyUserId { get; set; }
        public DateTime? ModifyDate { get; set; }

        [Required(ErrorMessage = "Status Id is required")]
        public string StatusId { get; set; }
    }
}
