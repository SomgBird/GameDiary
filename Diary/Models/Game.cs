using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Models
{
    public class Game
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? UserCommentary { get; set; }

        public virtual List<Tag> Tags { get; set; }
        public virtual Company Developer { get; set; }
        public virtual Company Publisher { get; set; }

        public virtual Status GameStatus { get; set; }
    }
}
