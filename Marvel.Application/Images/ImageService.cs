using Marvel.Application.Characters.Interfaces;
using Marvel.Application.Images.Interfaces;
using Marvel.Domain.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Application.Images
{
    internal class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;
        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        public List<MarvelImage> GetAllImages()
        {
            var image = _imageRepository.GetAllImages();

            return image;
        }
    }
}
