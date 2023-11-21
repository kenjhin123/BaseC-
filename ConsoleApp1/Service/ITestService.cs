using DreamWebModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamWebService.Service
{
    public interface ITestService
    {
        List<Test> GetAll();
    }
}
