using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataResponse
{
    public class DataResponse
    {
        public object Data { get; set; }
        public int StatusCode { get; set; }
        public DataResponse(object data , int code) {
             Data = data ;
             StatusCode = code;
        }
    }
}
