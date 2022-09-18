﻿using System;
namespace BlazorDictionary.Api.Domain.Models
{
	public class EntryCommentFavourite : BaseEntity
	{
        public Guid EntryCommentId { get; set; }
        public Guid CreatedById { get; set; }

        public virtual EntryComment EntryComment { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}

