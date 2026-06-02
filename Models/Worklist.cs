using System.ComponentModel.DataAnnotations;

namespace IsmasPrototype.Models
{
    public class WorkList
    {
        public int Id { get; set; }

        [Display(Name = "Име на списъка")]
        public string Name { get; set; }

        [Display(Name = "Спонсор")]
        public string Sponsor { get; set; }

        [Display(Name = "Работодател")]
        public string Employer { get; set; }

        [Display(Name = "Щат")]
        public string State { get; set; }

        [Display(Name = "Капацитет")]
        public int Capacity { get; set; }

        [Display(Name = "Сезон")]
        public int Season { get; set; }
    }
}