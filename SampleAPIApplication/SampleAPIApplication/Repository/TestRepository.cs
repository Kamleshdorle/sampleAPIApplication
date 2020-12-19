using SampleAPIApplication.Model;
using SampleAPIApplication.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPIApplication.Repository
{
    public class TestRepository : ITestRepository
    {
        public async Task<TestModel> ValidateAlphabates(string inputString)
        {
            var response = new TestModel();

            var onlyLetters = new String(inputString.ToLower().Where(Char.IsLetter).ToArray());

            response.IsValidString = onlyLetters.Where(Char.IsLetter).ToArray().Distinct().Count() == 26;
                        
            return response;
        }

    }
}
