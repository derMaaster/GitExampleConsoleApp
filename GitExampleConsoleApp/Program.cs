using System;

namespace GitExampleConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BLevelClass bLevelClass = new BLevelClass();
            bLevelClass.PropertyChanged += BLevelClass_PropertyChanged;

            Console.WriteLine("Enter value 0 or 1");

            int rowID = Convert.ToInt32(Console.ReadLine());
            if(rowID==0 || rowID == 1)
            {
                bLevelClass.Run(rowID);
                Console.WriteLine("Run will auto terminate in 5 seconds, and should notify via propetyChanged");
            }
            else
            {
                Console.Write("failed to enter correct input");
            }


            Console.Read();
        }

        private static void BLevelClass_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("Run has terminated, and set to false");
            Console.WriteLine("Press Enter to exit");
            Console.Read();
        }
    }
}
