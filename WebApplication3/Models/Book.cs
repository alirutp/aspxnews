﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Book

    {

        public int BookID { get; set; }

        public string Category { get; set; }

        public string Name { get; set; }

        public int Numberofcopies { get; set; }

        public int AuthorID { get; set; }

        public decimal Price { get; set; }

        public DateTime PublishDate { get; set; }

    }
    public class BookDBContext : DbContext

    {

        public DbSet<Book> Books { get; set; }

    }
}