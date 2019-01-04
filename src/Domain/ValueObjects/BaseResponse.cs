using System;
using System.Collections.Generic;

namespace Domain.ValueObjects
{
    public class BaseResponse
    {
        public BaseResponse()
        {
        }

        public bool Success
        {
            get
            {
                if (this.Exception != null)
                    return false;
                else
                    return true;
            }
        }

        public Exception Exception { get; set; }

        public MessageResponse MessageResponse { get; set; }
    }    
}
