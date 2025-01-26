using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hinamori.Models;

public class Chat
{
    [Key]
    public int ChatID { get; set; }
    [ForeignKey("UserInfo")]
    public int UserID { get; set; }

    public string? Message { get; set; }
    public string? MessageSentTime { get; set; }
    public string? PinnedMessage { get; set; }
}