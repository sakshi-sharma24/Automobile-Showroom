using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    interface IServices
    {
        Invoice SellVehicle(decimal cost,out Vehicle vehicle);
        Invoice RentVehicle(decimal cost,out Vehicle vehicle);
        Vehicle MaintainenceService(Invoice invoice,Vehicle vehicle);
        Vehicle TestDrive();

    }
}
