using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PollAPI.Models;

namespace PollAPI.Maps;

public class OptionMap : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder.ToTable("Option");
        builder.HasIndex("Id");
        builder.Property("Id").ValueGeneratedOnAdd();
        builder.HasMany(o => o.VotesList)
            .WithOne(v => v.Option)
            .HasForeignKey(v => v.OptionId)
            .IsRequired();

        builder.HasOne(o => o.Poll)
            .WithMany(p => p.Options)
            .HasForeignKey(o => o.PollId)
            .IsRequired();
    }
}