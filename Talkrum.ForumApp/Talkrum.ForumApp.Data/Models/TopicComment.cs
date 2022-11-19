namespace Talkrum.ForumApp.Data.Models;

using System.ComponentModel.DataAnnotations;

using Talkrum.ForumApp.Data.Common;

public class TopicComment : BaseModel<int>
{
    public TopicComment()
    {
        this.Interactions = new HashSet<Interaction>();
    }

    [Required]
    [MaxLength(5000)]
    public string? Description { get; set; }

    [Required]
    public string CreatorId { get; set; }

    public ApplicationUser? Creator { get; set; }

    public ICollection<Interaction>? Interactions { get; set; }
}
