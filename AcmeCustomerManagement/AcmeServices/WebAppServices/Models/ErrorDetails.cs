using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppServices.Models
{
    public class ErrorDetails
    {
        #region "Properties"

        public int StatusCode { get; set; }
        public string Message { get; set; }

        #endregion

        #region "Functionality"

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        #endregion
    }
}
