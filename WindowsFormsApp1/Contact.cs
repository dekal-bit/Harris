using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public  abstract class Contact
    {
        //all strings must match the inputs from RDS which been created on AWS.
        public int ContactID { get; set; }
        public string ContactFName { get; set; }
        public string ContactLName { get; set; }
        public string ContactAddress { get; set; }

        public string ContactPostcode { get; set; }
        public string ContactCity { get; set; }
        public string ContactCompany { get; set; }
        public string ContactEmail { get; set; }

        public string ContactTel { get; set; }

        
    }
}
