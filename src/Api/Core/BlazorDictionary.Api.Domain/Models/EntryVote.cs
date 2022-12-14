using System;
using BlazorDictionary.Common.ViewModels;

namespace BlazorDictionary.Api.Domain.Models
{
	public class EntryVote : BaseEntity
	{
		public Guid EntryId { get; set; }
		public VoteType VoteType { get; set; }
		public Guid CreatedById { get; set; }

		public virtual Entry Entry { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}

