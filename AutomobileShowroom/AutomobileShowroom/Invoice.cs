using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public class Invoice
    {
        public string CustomerName { get; private set; }
        public string CustomerAddress { get; private set; }
        public long ContactNumber { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime DueDate { get; private set; }
        //TO DO:
        //item purchased info
        public Invoice(string customername,string customeraddress,long contctnumber,DateTime issuedate,DateTime duedate)
        {
            CustomerName = customername;
            CustomerAddress = customeraddress;
            ContactNumber = contctnumber;
            IssueDate = issuedate;
            DueDate = duedate;
        }
    }
}
