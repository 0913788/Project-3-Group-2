using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace Kickstart_Rotterdam__Real_
{
    public class Main_Program
    {
        private int State; //Defines which part (form) of the program should be shown to the user.
        private bool Busy; //Defines if the program is "Busy" showing content to the user.

        public Main_Program()
        {
            State = 0;
            Busy = false;
        }
        
        public bool _Busy
        {
            get {return Busy;}
            set {Busy = value;}
        }

        public int _State
        {
            get{return State;}
            set{State = value;}
        }

        // Main loop for the program, relies on this.State and this.Busy to open a new form or let the thread sleep for a moment.
        public void Run()
        {
            var looping = true;
            while (looping)
            {
                if (State == 9)
                {
                    return;
                }
                else
                {
                    if (!Busy)
                    {
                        Busy = true;
                        Thread.Sleep(50);
                        Task.Factory.StartNew(()=>Subform());
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            }
        }

        // Creates a new thread on which a form will be shown.
        private void Subform()
        {

            switch (State)
            {
                case 0: // Launch <Main_Menu>
                    Task.Factory.StartNew(() => Application.Run(new Main_Menu(this)));
                    break;
                case 1: // Launch <Sub_Form_Bicycle_Theft>
                    Task.Factory.StartNew(() => Application.Run(new Sub_Bicycle_Theft(this)));
                    break;
                case 2: // Launch <Sub_Form_Weather>
                    Task.Factory.StartNew(() => Application.Run(new Sub_Form_Weather(this)));
                    break;
                case 3: // Launch <Sub_Form_Weather_Bicycle>
                    Task.Factory.StartNew(() => Application.Run(new Sub_Form_Correlation(this)));
                    break;
                case 4: // Launch  <Sub_Form_Complaints>                                             
                    Task.Factory.StartNew(() => Application.Run(new Sub_Form_Complaints(this)));
                    break;
                case 5: // Launch <Sub_Form_Traffic_Density>
                    Task.Factory.StartNew(() => Application.Run(new Sub_Form_Traffic_Density(this)));
                    break;
                case 6: // Launch <Sub_Form_Park_Ride>
                    Task.Factory.StartNew(() => Application.Run(new Sub_Form_PR(this)));
                    break;
            }
        }
    }
}
