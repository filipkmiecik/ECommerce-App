using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Test v2
namespace ECommerce.Models
{
    public class OpinionRepository : IOpinionRepository
    {

        private readonly AppDbContext _appDbContext;

        public OpinionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void addOpinion(Opinion opinon)
        {
            _appDbContext.Opinions.Add(opinon);
        }
    }
}
