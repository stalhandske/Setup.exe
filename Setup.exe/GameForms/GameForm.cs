using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace Setup.exe.GameForms
{
	public class GameForm : Form
	{
		private Thread _updateThread;
		private readonly Action _updateAction;
		private volatile bool _shouldStop;

		public GameForm()
		{
			_updateAction=Update;
		}

		private void SetupUpdateThread()
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

		public virtual void OnGameUpdate()
		{
			
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			StopUpdateThread();
			base.OnFormClosed(e);
		}

		private void StopUpdateThread()
		{
			_shouldStop = true;
			//_updateThread.Join();
		}
	}
}