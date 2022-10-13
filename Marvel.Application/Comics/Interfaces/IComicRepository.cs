using Marvel.Domain.Comics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Application.Comics.Interfaces
{
    public interface IComicRepository
    {
        List<Comic> GetAllComics();
    }
}
