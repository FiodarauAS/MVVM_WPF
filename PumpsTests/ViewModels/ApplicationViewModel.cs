using PumpsTests.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PumpsTests.ViewModels
{
    public class ApplicationViewModel
    {
        public ObservableCollection<DataModel> DataModels { get; set; } = new ObservableCollection<DataModel>();

        public ApplicationViewModel()
        {
            
        }
    }
}
