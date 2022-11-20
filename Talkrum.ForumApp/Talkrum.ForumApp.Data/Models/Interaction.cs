namespace Talkrum.ForumApp.Data.Models;

using System.ComponentModel.DataAnnotations;
using Talkrum.ForumApp.Data.Common;

public class Interaction : BaseModel<int>
{
    [Required]
    public string? AuthorId { get; set; }

    public ApplicationUser? Author { get; set; }

    // TODO: Make it enumerable - like, dislike, some emojis etc.
    public bool IsLike { get; set; }

    public bool IsDislike { get; set; }

    public int? TopicCommentId { get; set; }

    public TopicComment? TopicComment { get; set; }

    public int? TopicId { get; set; }

    public Topic? Topic { get; set; }

    public int? PersonalMessageId { get; set; }

    public PersonalMessage? PersonalMessage { get; set; }
}
