using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Middlewares.ExceptionMiddleware.Models
{
    internal record ExceptionResponse
    {
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
    }
}
