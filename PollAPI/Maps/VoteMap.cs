using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PollAPI.Models;

namespace PollAPI.Maps;

public class VoteMap : IEntityTypeConfiguration<Vote>
{
    public void Configure(EntityTypeBuilder<Vote> builder)
    {
        builder.ToTable("Vote");
        builder.HasIndex("Id");
        builder.Property("Id").ValueGeneratedOnAdd();
        builder.HasOne(v => v.Option)
            .WithMany(o => o.VotesList)
            .HasForeignKey(v => v.OptionId)
            .IsRequired();
    }
}