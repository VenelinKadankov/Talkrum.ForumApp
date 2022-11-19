namespace Talkrum.ForumApp.Data.Models;

using Microsoft.AspNetCore.Identity;

using Talkrum.ForumApp.Data.Common.Interfaces;

public class ApplicationUser : IdentityUser, IBaseModel
{
    public ApplicationUser()
    {
        Id = Guid.NewGuid().ToString();
        Interactions = new HashSet<Interaction>();
        PersonalMessages = new HashSet<PersonalMessage>();
        TopicsCommentsByUser = new HashSet<TopicComment>();
        ParticipationTopics = new HashSet<Topic>();
    }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }

    public ICollection<Interaction>? Interactions { get; set; }

    public ICollection<PersonalMessage>? PersonalMessages { get; set; }

    public ICollection<TopicComment>? TopicsCommentsByUser { get; set; }

    public ICollection<Topic>? ParticipationTopics { get; set; }

}

