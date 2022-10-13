using Marvel.Application.Images.Interfaces;
using Marvel.Domain.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Infraestructure.Images
{
    public class ImageRepository : IImageRepository
    {
        private List<MarvelImage> images = new List<MarvelImage>();
        public List<MarvelImage> GetAllImages()
        {
            return images;
        }
    }
}
