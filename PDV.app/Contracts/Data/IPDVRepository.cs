using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.app.Contracts.Data
{
    public interface IPDVRepository
    {
        bool Login(string username, string password);
    }
}
