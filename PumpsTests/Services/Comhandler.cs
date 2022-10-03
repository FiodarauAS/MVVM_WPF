using PumpsTests.Services.Interfaces;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;

namespace PumpsTests.Services
{
    public class Comhandler : IComHandler
    {
        public void OpenPort()
        {

        }

        public void ClosePort()
        {

        }

        public Task<List<string>> GetPorts()
        {
            return Task.Run(() => 
            {
                return SerialPort.GetPortNames().ToList();
            });
        }
    }
}
