using System.ComponentModel.DataAnnotations;
using Talkrum.ForumApp.Data.Models;

namespace Talkrum.ForumApp.InputModels;

public class InputTopicModel
{
    [Required]
    [MaxLength(200)]
    public string? Title { get; set; }

    [Required]
    [MaxLength(5000)]
    public string? Description { get; set; }

    [Required]
    public string? CreatorId { get; set; }
}
