using System.ComponentModel.DataAnnotations;

namespace IsmasPrototype.Models
{
    public class Student
    {
        public int Id { get; set; }

        // Основна информация
        [Required]
        [Display(Name = "Име")]
        public string FirstNameBg { get; set; }

        [Required]
        [Display(Name = "Презиме")]
        public string MiddleNameBg { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string LastNameBg { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstNameEn { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleNameEn { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastNameEn { get; set; }

        [Required]
        [Display(Name = "Държава на гражданство")]
        public string CitizenshipCountry { get; set; } = "BULGARIA (BG)";

        [Display(Name = "Номер на лична карта")]
        public string? IdCardNumber { get; set; }

        [Display(Name = "Лична карта издадена на")]
        public DateTime? IdCardIssueDate { get; set; }

        [Display(Name = "Лична карта издадена от")]
        public string? IdCardIssuedBy { get; set; }

        [Display(Name = "Номер на паспорт")]
        public string? PassportNumber { get; set; }

        [Display(Name = "Дата на издаване на паспорта")]
        public DateTime? PassportIssueDate { get; set; }

        [Display(Name = "Дата на раждане")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(10)]
        [Display(Name = "ЕГН")]
        public string? NationalIdNumber { get; set; }

        [Display(Name = "Години")]
        public int? Age { get; set; }

        [Required]
        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Семеен статус")]
        public string MaritalStatus { get; set; } = "Single";

        [Required]
        [Display(Name = "Град на раждане")]
        public string BirthCity { get; set; }

        [Required]
        [Display(Name = "Държава на раждане")]
        public string BirthCountry { get; set; }

        [Required]
        [Display(Name = "Националност")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name = "Телефонен код")]
        public string PhoneCountryCode { get; set; } = "+359";

        [Required]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Имейл")]
        public string Email { get; set; }

        // Постоянен адрес
        [Required]
        [Display(Name = "Държава - постоянен адрес")]
        public string PermanentCountry { get; set; } = "BULGARIA";

        [Display(Name = "Град - постоянен адрес")]
        public string? PermanentCity { get; set; }

        [Display(Name = "Село - постоянен адрес")]
        public string? PermanentVillage { get; set; }

        [Required]
        [Display(Name = "Пощенски код - постоянен адрес")]
        public string PermanentPostalCode { get; set; }

        [Display(Name = "Квартал")]
        public string? PermanentDistrict { get; set; }

        [Display(Name = "Улица")]
        public string? PermanentStreet { get; set; }

        [Display(Name = "Номер")]
        public string? PermanentStreetNumber { get; set; }

        [Display(Name = "Блок")]
        public string? PermanentBlock { get; set; }

        [Display(Name = "Вход")]
        public string? PermanentEntrance { get; set; }

        [Display(Name = "Етаж")]
        public string? PermanentFloor { get; set; }

        [Display(Name = "Апартамент")]
        public string? PermanentApartment { get; set; }

        // Адрес на пребиваване
        [Required]
        [Display(Name = "Държава - адрес на пребиваване")]
        public string CurrentCountry { get; set; } = "BULGARIA";

        [Display(Name = "Град - адрес на пребиваване")]
        public string? CurrentCity { get; set; }

        [Display(Name = "Село - адрес на пребиваване")]
        public string? CurrentVillage { get; set; }

        [Required]
        [Display(Name = "Пощенски код - адрес на пребиваване")]
        public string CurrentPostalCode { get; set; }

        [Display(Name = "Квартал / ж.к.")]
        public string? CurrentDistrict { get; set; }

        [Display(Name = "Улица")]
        public string? CurrentStreet { get; set; }

        [Display(Name = "Номер")]
        public string? CurrentStreetNumber { get; set; }

        [Display(Name = "Блок")]
        public string? CurrentBlock { get; set; }

        [Display(Name = "Вход")]
        public string? CurrentEntrance { get; set; }

        [Display(Name = "Етаж")]
        public string? CurrentFloor { get; set; }

        [Display(Name = "Апартамент")]
        public string? CurrentApartment { get; set; }

        // Спешен контакт
        [Required]
        [Display(Name = "Име - спешен контакт")]
        public string EmergencyFirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия - спешен контакт")]
        public string EmergencyLastName { get; set; }

        [Required]
        [Display(Name = "Телефонен код - спешен контакт")]
        public string EmergencyPhoneCountryCode { get; set; } = "+359";

        [Required]
        [Display(Name = "Телефон - спешен контакт")]
        public string EmergencyPhoneNumber { get; set; }

        // Университет
        [Required]
        [Display(Name = "Държава на университета")]
        public string UniversityCountry { get; set; } = "BULGARIA";

        [Required]
        [Display(Name = "Град на университета")]
        public string UniversityCity { get; set; }

        [Required]
        [Display(Name = "Университет")]
        public string UniversityName { get; set; }

        [Required]
        [Display(Name = "Специалност")]
        public string Major { get; set; }

        [Required]
        [Display(Name = "Начало на обучението")]
        public DateTime UniversityStartDate { get; set; }

        [Required]
        [Display(Name = "Край на обучението")]
        public DateTime UniversityEndDate { get; set; }

        [Required]
        [Display(Name = "Вид обучение")]
        public string DegreeType { get; set; }

        [Required]
        [Display(Name = "Предишно образование")]
        public bool HasPreviousEducation { get; set; }

        public string? PreviousUniversityName { get; set; }
        public string? PreviousMajor { get; set; }
        public string? PreviousEducationPeriod { get; set; }
        public string? PreviousDegreeType { get; set; }

        // Визи
        [Required]
        [Display(Name = "Кандидатствал ли е за виза преди")]
        public bool HasAppliedForVisaBefore { get; set; }

        [Display(Name = "Брой предишни J1 визи")]
        public int? PreviousJ1VisaCount { get; set; }

        [Display(Name = "Бележки за предишни визи")]
        public string? PreviousVisaNotes { get; set; }

        // Системна информация
        [Display(Name = "Сезон")]
        public int Season { get; set; } = 2026;

        [Display(Name = "Офис")]
        public string Office { get; set; } = "Sofia";

        [Display(Name = "Статус")]
        public string Status { get; set; } = "Active";
    }
}