using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Models
{
    public class DLC
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? Commentary { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual Status? Status { get; set; }
        public virtual required Game Game { get; set; }
    }
}
