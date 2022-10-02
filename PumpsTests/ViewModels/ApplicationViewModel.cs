using PumpsTests.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PumpsTests.ViewModels
{
    public class ApplicationViewModel
    {
        public ObservableCollection<DataModel> DataModels { get; set; } = new ObservableCollection<DataModel>();

        public ApplicationViewModel()
        {
            for (int i = 0; i < 25; i++)
            {
                DataModels.Add(new DataModel()
                {
                    MyProperty = i.ToString(),
                    MyProperty1 = i.ToString(),
                    MyProperty2 = i.ToString(),
                    MyProperty3 = i.ToString(),
                    MyProperty4 = i.ToString(),
                    MyProperty5 = i.ToString()
                }); ;
            }
        }
    }
}
