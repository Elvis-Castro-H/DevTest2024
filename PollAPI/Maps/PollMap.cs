using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PollAPI.Models;

namespace PollAPI.Maps;

public class PollMap : IEntityTypeConfiguration<Poll>
{
    public void Configure(EntityTypeBuilder<Poll> builder)
    {
        builder.ToTable("Poll");
        builder.HasIndex("Id");
        builder.Property("Id").ValueGeneratedOnAdd();
        builder.HasMany(p => p.Options)
            .WithOne(o => o.Poll)
            .HasForeignKey(o => o.PollId);
    }
}