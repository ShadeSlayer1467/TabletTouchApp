using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletTouchApp.ViewModels
{
    public class USBViewModel : ObservableObject
    {
        private string status;

        public string Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }

        public Command ConnectCommand { get; }

        public USBViewModel()
        {
            ConnectCommand = new Command(ExecuteConnect);
            Status = "Disconnected";
        }

        private void ExecuteConnect()
        {
            Status = "Connecting...";
            // Logic to handle USB connection
        }
    }
}

