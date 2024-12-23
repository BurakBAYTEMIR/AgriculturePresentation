﻿using System.Collections.Generic;
using AgriculturePresentation.Business.Abstract;
using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.Business.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public void Insert(Image t)
        {
            _imageDal.Insert(t);
        }

        public void Delete(Image t)
        {
            _imageDal.Delete(t);
        }

        public void Update(Image t)
        {
            _imageDal.Update(t);
        }

        public Image GetById(int id)
        {
            return _imageDal.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return _imageDal.GetListAll();
        }
    }
}