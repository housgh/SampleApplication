using System.Collections.Generic;

namespace TODO.Application.Abstractions
{
    public interface IExternalDataService
    {
        List<object> GetData();
        void PutData(object obj);
    }
}