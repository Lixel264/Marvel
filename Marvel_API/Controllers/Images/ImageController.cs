using Marvel.Application.Images.Interfaces;
using Marvel.Domain.Images;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Marvel_API.Controllers.Images
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        public ActionResult<List<MarvelImage>> Get()
        {
            var imagesFromService = _imageService.GetAllImages();

            return Ok(imagesFromService);
        }


    }
}
