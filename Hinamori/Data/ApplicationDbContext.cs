using System;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;
using Hinamori.Models;

namespace Hinamori.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Models.Channel> Channels { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<UserInfo> UserInfos { get; set; }
    public DbSet<LogInfo> LogInfos { get; set; }
}