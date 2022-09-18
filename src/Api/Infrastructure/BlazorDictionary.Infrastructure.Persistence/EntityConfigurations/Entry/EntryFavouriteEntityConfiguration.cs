using System;
using BlazorDictionary.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDictionary.Infrastructure.Persistence.EntityConfigurations.Entry
{
	public class EntryFavouriteEntityConfiguration : BaseEntityConfiguration<Api.Domain.Models.EntryFavourite>
    {
        public override void Configure(EntityTypeBuilder<Api.Domain.Models.EntryFavourite> builder)
        {
            base.Configure(builder);

            builder.ToTable("entryfavourite", BlazorDictionaryContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.Entry)
                .WithMany(i => i.EntryFavourites)
                .HasForeignKey(i => i.EntryId);

            builder.HasOne(i => i.CreatedBy)
                .WithMany(i => i.EntryFavourites)
                .HasForeignKey(i => i.CreatedById);
        }
    }
}

