using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public class Showroom:IServices
    {
        private List<Vehicle> _vehicle;
        private decimal _cost;
        private Invoice _invoice;

        public Showroom()
        {
            _vehicle = new List<Vehicle>();
           
        }
        public Invoice SellVehicle(decimal cost, out Vehicle _vehicle)
        {
            _vehicle = null;
            return null;
        }
        
        public Invoice RentVehicle(decimal cost, out Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Vehicle MaintainenceService(Invoice invoice, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Vehicle TestDrive()
        {
            throw new NotImplementedException();
        }
        public List<Vehicle> GetVehicles()
        {
            return _vehicle;
        }
    }
}
