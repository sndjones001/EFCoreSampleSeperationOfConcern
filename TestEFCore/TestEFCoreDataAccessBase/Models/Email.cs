using System;
using System.ComponentModel.DataAnnotations;

namespace TestEFCoreDataAccessBase.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string EmailAddress { get; set; }
    }
}
