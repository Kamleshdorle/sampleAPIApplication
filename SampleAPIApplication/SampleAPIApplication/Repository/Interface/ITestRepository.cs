using SampleAPIApplication.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleAPIApplication.Repository.Interface
{
    public interface ITestRepository
    {
        Task<TestModel> ValidateAlphabates(string inputString); 
    }
}
