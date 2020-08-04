using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TransactionModel
    {

        [Key]
        public int TransactionId { get; set; }


        [Required(ErrorMessage ="This field is required.")]
        [Column(TypeName = "nvarchar(13)")]
        [DisplayName("AccountNumber")]

        public string AccountNumber { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(120)")]
        [DisplayName("BeneficiaryName")]

        public string BeneficiaryName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("BankName")]

        public string BankName { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("SwiftCode")]


        public string SwiftCode { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Amount")]

        public int Amount { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime Date { get; set; }
    }
}
