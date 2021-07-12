﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLBasic.Data.GraphQL
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }
        public int? Chapters { get; set; }
    }
}
