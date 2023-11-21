using DreamWebModel;
using DreamWebModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamWebService.Service
{
    public class TestService:ITestService
    {
       private readonly AppDbContext _appDbContext;
        public TestService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Test> GetAll()
        {
            return _appDbContext.Tests.ToList();
        }
    }
}
