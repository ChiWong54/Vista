using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.App.Data
{
    public class TrainerCategory
    {
        // Has a composite (compound) key that will be defined TrainersDbConext
        [Required]
        public int TrainerId { get; set; }
        [MaxLength(15)]
        public required string CategoryCode { get; set; }
        public Trainer? Trainer { get; set; } // Placeholder a navigation property to Trainer (one side of one-to-many)
        // See TrainersDbConext for Foreign Key (Fluent API) definition
        public Category? Category { get; set; } // Placeholder for a navigation property to Category (one side of one-to-many)
    }
}
