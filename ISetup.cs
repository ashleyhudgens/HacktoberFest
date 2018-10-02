using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacktober
{
    interface ISetup
    {
        string userId { get; set; }
        string getUserId();
        string firstName { get; set; }
        string getFirstName();
        string lastName { get; set; }
        string getLastName();
        string emailAddress { get; set; }
        string getEmailAddress();
        int postOrder { get; set; }
        int getPostOrder();
    }
}
