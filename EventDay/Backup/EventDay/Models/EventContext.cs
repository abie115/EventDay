﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventDay.Models
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Event { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<CommentCategory> CommentCategory { get; set; }
    }
}