using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; }
    }
}
