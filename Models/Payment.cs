using System.ComponentModel.DataAnnotations;

namespace IsmasPrototype.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Display(Name = "Студент")]
        public int StudentId { get; set; }

        public Student Student { get; set; }

        [Display(Name = "Сума")]
        public decimal Amount { get; set; }

        [Display(Name = "Тип плащане")]
        public string PaymentType { get; set; }

        [Display(Name = "Дата на плащане")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Бележка")]
        public string Note { get; set; }
    }
}