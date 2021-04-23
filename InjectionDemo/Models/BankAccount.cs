using System.ComponentModel.DataAnnotations;

namespace InjectionDemo.Models
{
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public float Balance { get; set; }
    }
}