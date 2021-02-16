using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace GitExampleConsoleApp
{
    public class CBaseClass:INotifyPropertyChanged
    {
        public int ID { get; set; }

        private bool isOn;
        public bool IsOn
        {
            get { return isOn; }
            set
            {
                isOn = value;
                RaisePropertyChanged("BaseClass:IsOn");
            }
        }

        public CBaseClass(int iD, bool ison)
        {
            ID = iD;
            IsOn = ison;
        }


        public async Task Run()
        {
            Console.WriteLine(ID.ToString() + " running");

            await Task.Delay(5000);

            SetFalse();

        }
        public void SetFalse()
        {
            Console.WriteLine("SetFalse being called on: " + ID.ToString());
            IsOn = false;
            Console.WriteLine(IsOn.ToString());
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
