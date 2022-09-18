using System;
namespace BlazorDictionary.Api.Domain.Models
{
	public class EntryFavourite : BaseEntity
	{
        public Guid EntryId { get; set; }
        public Guid CreatedById { get; set; }

        public virtual Entry Entry { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}

