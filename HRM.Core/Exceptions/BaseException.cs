using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class BaseException
    {
        #region Properties
        public int StatusCode { get; set; }    
        public string Message { get; set; }


        #endregion

        #region Methods
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        #endregion
    }
}
