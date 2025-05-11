using System.ComponentModel.DataAnnotations;

namespace EventMgr.Models
 {
        public class EventItem
        {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Date is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; } = string.Empty;
        [Required(ErrorMessage = "Location is required.")]
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
          // Updated Attendees property to use a list of Attendee records
        public List<Attendee> Attendees { get; set; } = new List<Attendee>();
    }

    // New record type for attendee details
    public record Attendee
    {
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        public string Phone { get; set; } = string.Empty;
    }
}

