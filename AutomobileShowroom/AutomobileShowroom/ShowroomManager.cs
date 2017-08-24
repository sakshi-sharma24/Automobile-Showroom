using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public class ShowroomManager 
    {
        private Showroom _showroom;
        public ShowroomManager()
        {
            _showroom = new Showroom();
        }
        public void SellVehicle(decimal cost,out Vehicle newVehicle)
        {
            _showroom.SellVehicle(cost,out newVehicle);
        }
        public void RentVehicle(decimal cost,out Vehicle vehicle)
        {
            _showroom.RentVehicle(cost, out vehicle);
        }
        public void MaintainenceService(Invoice invoice, Vehicle vehicle)
        {
            _showroom.MaintainenceService(invoice, vehicle);
        }

        public void TestDrive()
        {
            _showroom.TestDrive();
        }

    }
}
