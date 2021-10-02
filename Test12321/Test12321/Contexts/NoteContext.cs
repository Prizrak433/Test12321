using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test12321.Models;

namespace Test12321.Contexts
{
    public class NoteContext:DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> option) : base(option)
        {

        }

        public DbSet<Note> Notes { get; set; }

    }
}
