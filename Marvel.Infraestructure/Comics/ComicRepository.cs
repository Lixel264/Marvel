using Marvel.Application.Comics.Interfaces;
using Marvel.Domain.Comics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Infraestructure.Comics
{
    public class ComicRepository : IComicRepository
    {
        private List<Comic> comics = new List<Comic>();
        public List<Comic> GetAllComics()
        {
            return comics;
        }
    }
}
