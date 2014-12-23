using System.Collections.Generic;
using System.Collections;

namespace Assignment12
{
    class VehicleCollections : IEnumerable
    {
        /// <summary>
        /// object of vehicle class 
        /// </summary>
        Vehicle obj = new Vehicle();
        List<Vehicle> list;

        /// <summary>
        /// method to maintain a list of vehicles 
        /// </summary>
        public void GetVehicleList()
        {
            list = obj.GetVehicle();
        }

        /// <summary>
        /// method to enumerate through list
        /// </summary>
        
        public IEnumerator GetEnumerator()
        {
            foreach (object vehicle in list)
            {
                yield return vehicle;
            }
        }
    }
}
