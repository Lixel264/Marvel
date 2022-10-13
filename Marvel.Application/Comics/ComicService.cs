using Marvel.Application.Characters.Interfaces;
using Marvel.Application.Comics.Interfaces;
using Marvel.Domain.Comics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Application.Comics
{
    public class ComicService : IComicService
    {
        private readonly IComicRepository _comicRepository;
        public ComicService(IComicRepository comicRepository)
        {
            _comicRepository = comicRepository;
        }

        public List<Comic> GetAllComics()
        {
            var comics = _comicRepository.GetAllComics();

            return comics;
        }
    }
}
