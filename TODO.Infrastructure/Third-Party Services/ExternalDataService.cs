using System.Collections.Generic;
using TODO.Application.Abstractions;

namespace TODO.Infrastructure.Third_Party_Services
{
    internal class ExternalDataService : IExternalDataService
    {
        public List<object> GetData()
        {
            return new List<object>();
        }

        public void PutData(object obj)
        {
            //do something
        }
    }
}