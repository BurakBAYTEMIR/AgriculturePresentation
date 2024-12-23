﻿using System.Collections.Generic;
using AgriculturePresentation.Business.Abstract;
using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Insert(SocialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void Delete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public void Update(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> GetListAll()
        {
            return _socialMediaDal.GetListAll();
        }
    }
}