using System;
using BlazorDictionary.Api.Domain.Models;
using BlazorDictionary.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDictionary.Infrastructure.Persistence.EntityConfigurations.EntryComment
{
	public class EntryCommentFavouriteEntityConfiguration : BaseEntityConfiguration<EntryCommentFavourite>
	{
        public override void Configure(EntityTypeBuilder<EntryCommentFavourite> builder)
        {
            base.Configure(builder);

            builder.ToTable("entrycommentfavourites", BlazorDictionaryContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.EntryComment)
                .WithMany(i => i.EntryCommentFavourites)
                .HasForeignKey(i => i.EntryCommentId);

            builder.HasOne(i => i.CreatedBy)
                .WithMany(i => i.EntryCommentFavourites)
                .HasForeignKey(i => i.CreatedById);
        }
    }
}

