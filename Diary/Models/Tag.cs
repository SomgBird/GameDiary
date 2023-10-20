using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public required string TagName { get; set; }

        public virtual List<Game> Games { get; set; }
    }
}
