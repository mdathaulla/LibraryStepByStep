﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement1.Data.Model
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required, MinLength(3),MaxLength(50)]  //validation with csv
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
