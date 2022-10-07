using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException:Exception
    {
       
        //enum for declaring custom exception constant
        public enum ExceptionType
        {
            
            INVALID_DISTANCE,
            INVALID_RIDE_TYPE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }
        ExceptionType type; 
        //paramaterized constructor for custom exception
        public CabInvoiceException(ExceptionType type, string msg) : base(msg)
        {
            this.type = type;
        }
    }
}
