using System;
using System.Threading;
using System.Windows.Forms;

namespace Setup.exe.GameForms
{
    public class GameForm : Form
    {
        private readonly Action _updateAction;
        private Thread _updateThread;
        private volatile bool _shouldStop;

        public GameForm()
        {

        }

        //Set the update function directly in the constructor.
        public GameForm(Action updateAction)
        {
            _updateAction = updateAction;
        }

        public void SetupUpdateThread()
        {
            _updateThread = new Thread(DoUpdate);
            _updateThread.Start();
        }

        private void DoUpdate()
        {
            while (!_shouldStop)
            {
                try
                {
                    Invoke(_updateAction);
                }
                catch
                {
                    Console.WriteLine("Exeption caught in Update Action");
                }
                Thread.Sleep(16);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            StopUpdateThread();
            base.OnFormClosed(e);
        }

        private void StopUpdateThread()
        {
            _shouldStop = true;
            _updateThread.Join();
        }
    }
}