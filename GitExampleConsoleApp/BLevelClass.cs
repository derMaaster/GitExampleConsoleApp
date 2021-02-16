using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using GitExampleConsoleApp.Helpers;
using System.Threading.Tasks;

namespace GitExampleConsoleApp
{
    public class BLevelClass:INotifyPropertyChanged
    {
        // Can this be changed to a basic Collection<>?:
        public ExObservableCollection<CBaseClass> ClassesOfA;

        public BLevelClass()
        {
            ClassesOfA = new ExObservableCollection<CBaseClass>();

            CBaseClass firstClassA = new CBaseClass(0, true);
            CBaseClass secondClassA = new CBaseClass(1, true);

            ClassesOfA.Insert(0, firstClassA);
            ClassesOfA.Insert(1, secondClassA);
        }

        public void Run(int row)
        {
            Task.Run(()=> ClassesOfA[row].SetTrue());
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
