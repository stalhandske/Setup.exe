using System;
using System.Diagnostics;
using System.Windows.Forms;
using Setup.exe.GameForms;

namespace Setup.exe
{
	public class GameManager : ApplicationContext
	{
		private static GameManager _instance;

		private readonly Type[] _events =
		{
			typeof (Form_Welcome),
			typeof (Form_License),
            typeof(Form_InstallationType),
            typeof(Form_Customize),
            typeof(Form_Summary),
            typeof(Form_ActualInstallation),
            typeof(Form_Finish)
		};

		public GameManager()
		{
			StartGame();
		}

		private int _currentEventIndex;

		private GameForm _currentForm;

		public static GameManager Instance => _instance ?? (_instance = new GameManager());

		private Type CurrentFormType => _events[_currentEventIndex];

		public void StartGame()
		{
			_currentForm = CreateForm(CurrentFormType);
			_currentForm.Show();
			_currentForm.SetupUpdateThread();
		}

		public void NextEvent()
		{
			_currentEventIndex++;
			if (_currentEventIndex == _events.Length)
			{
				Application.Exit();
				return;
			}

			_currentForm.Visible = false;
			_currentForm.Close();
			_currentForm = null;
			GC.Collect();
			_currentForm = CreateForm(CurrentFormType);
			 _currentForm.Show();
		}

		public GameForm CreateForm(Type type)
		{
			return Activator.CreateInstance(type) as GameForm;
		}
	}
}
 