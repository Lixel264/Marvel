using Marvel.Application.Comics.Interfaces;
using Marvel.Domain.Comics;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Marvel_API.Controllers.Comics
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController : ControllerBase
    {
        private readonly IComicService _comicService;

        public ComicController(IComicService comicService)
        {
            _comicService = comicService;
        }

        [HttpGet]
        public ActionResult<List<Comic>> Get()
        {
            var comicFromService = _comicService.GetAllComics();

            return Ok(comicFromService);
        }


    }
}
