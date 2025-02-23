﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.App.Data
{
    public class Category
    {
        [Key] // Since the key name (CategoryCode) does not include
              // "Id", we have to use an annotation (could also
              // specify this using FluitAPI)
        [MaxLength(15)]
        public required string CategoryCode { get; set; }
        [MaxLength(30)]
        public required string CategoryName { get; set; }
        public List<TrainerCategory>? TrainerCategories { get; set; }// Placeholder for List of Trainer Categories (many side of one-to-many)
    }
}
