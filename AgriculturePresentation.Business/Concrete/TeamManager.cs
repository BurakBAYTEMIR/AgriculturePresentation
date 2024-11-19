using System.Collections.Generic;
using AgriculturePresentation.Business.Abstract;
using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.Business.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }


        public void Insert(Team t)
        {
            _teamDal.Insert(t);
        }

        public void Delete(Team t)
        {
            _teamDal.Delete(t);
        }

        public void Update(Team t)
        {
            _teamDal.Update(t);
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _teamDal.GetListAll();
        }
    }
}