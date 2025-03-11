using System.ComponentModel.DataAnnotations;

namespace NightProject.Entities
{
	public class User
	{
		[Key]
        public Guid Id  { get; set; }

        [Required]
        public string NameSurname { get; set; }
		public string UserName { get; set; }
        public string Password { get; set; }
        public bool Locked { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
