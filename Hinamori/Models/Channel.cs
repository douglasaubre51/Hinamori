using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hinamori.Models;

public class Channel
{
    [Key]
    public int ChannelID { get; set; }
    [ForeignKey("Chat")]
    public int ChatID { get; set; }

    public string? ChannelName { get; set; }
    public string? ChannelDescription { get; set; }
    public string? Course { get; set; }
    public string? Semester { get; set; }
}