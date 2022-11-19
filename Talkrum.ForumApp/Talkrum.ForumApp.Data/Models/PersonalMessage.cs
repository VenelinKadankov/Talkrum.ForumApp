namespace Talkrum.ForumApp.Data.Models;

using System.ComponentModel.DataAnnotations;

using Talkrum.ForumApp.Data.Common;

public class PersonalMessage : BaseModel<int>
{
    public PersonalMessage()
    {
        this.Interactions = new HashSet<Interaction>();
    }

    [Required]
    [MaxLength(2000)]
    public string? Content { get; set; }

    [Required]
    public string? SenderId { get; set; }

    //public ApplicationUser? Sender { get; set; }

    [Required]
    public string? ReceiverId { get; set; }

   // public ApplicationUser? Receiver { get; set; }

    public ICollection<Interaction> Interactions { get; set; }
}
