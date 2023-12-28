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
        public int? TotalSize { get; set; }
        public DataResponse(object data , int code, int? totalSize = null) {
             Data = data ;
             StatusCode = code;
            TotalSize = totalSize;
        }
    }
}
