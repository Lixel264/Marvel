using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Characters
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; }
        public Images.MarvelImage Thumbnail { get; set; }
    }
}
