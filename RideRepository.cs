using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        //Dictionary to store userID an Rides int List
        Dictionary<string, List<Ride>> userRides = null;
        
        //Constructor to create dictionary
        
        public RideRepository()
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }

        //Function to add ridelist to specified userID
        public void AddRide(string userID, Ride[] rides)
        {
            bool rideList = this.userRides.ContainsKey(userID);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(userID, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, " rides are Null");
            }
        }
    }
}
