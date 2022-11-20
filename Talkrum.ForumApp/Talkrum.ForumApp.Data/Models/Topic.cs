namespace Talkrum.ForumApp.Data.Models;

using System.ComponentModel.DataAnnotations;

using Talkrum.ForumApp.Data.Common;

public class Topic : BaseModel<int>
{
    public Topic()
    {
        Interactions = new HashSet<Interaction>();
        TopicComments = new HashSet<TopicComment>();
        ApplicationUsers = new HashSet<ApplicationUser>();
    }

    [Required]
    [MaxLength(200)]
    public string? Title { get; set; }

    [Required]
    [MaxLength(5000)]
    public string? Description { get; set; }

    [Required]
    public string? CreatorId { get; set; }

    public ApplicationUser? Creator { get; set; }

    public ICollection<Interaction>? Interactions { get; set; }

    public ICollection<TopicComment>? TopicComments { get; set; }

    // Participants
    public ICollection<ApplicationUser>? ApplicationUsers { get; set; }
}
