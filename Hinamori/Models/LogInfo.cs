using System;
using System.ComponentModel.DataAnnotations;

namespace Hinamori.Models;

public class LogInfo
{
    [Key]
    public int LogID { get; set; }

    public bool Online { get; set; }
    public bool readChat { get; set; }
}
