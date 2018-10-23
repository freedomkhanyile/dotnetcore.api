using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Template.Entities.Models
{
    [Table("account")]
    public class Account : IEntity
    {        
        [Key]
        [Column("AccountId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Account Holder is required")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Account Name is required")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Sold Dateis required")]
        public DateTime SoldDate { get; set; }

        [Required(ErrorMessage = "Installment is required")]
        public decimal Installment { get; set; }
        [Required(ErrorMessage = "Status Id is required")]
        public int StatusId { get; set; }
    }
}
