using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PumpsTests.Services.Interfaces
{

    public interface IComHandler
    {
        void OpenPort();
        void ClosePort();
        Task<List<string>> GetPorts();
    }
}
