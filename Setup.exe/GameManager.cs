using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Setup.exe.GameForms;

namespace Setup.exe
{
	public class GameManager : ApplicationContext
	{
		private static GameManager _instance;

		private readonly List<Type> _events = new List<Type>
		{
            typeof(Form_OSWarning),
			typeof (Form_Welcome),
			typeof (Form_License),
			typeof (Form_InstallationType),
			typeof (Form_Customize),
			typeof (Form_Summary),
			typeof (Form_ActualInstallation),
			typeof (Form_Finish)
		};

		private int _currentEventIndex;

		private GameForm _currentForm;

		public GameManager()
		{
			StartGame();
		}

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
			RefreshEvent();
		}

		public void GoToSpecific(Type formType)
		{
			_currentEventIndex = _events.IndexOf(formType);
			RefreshEvent();
		}

		//This is called after the _currentEventIndex was modified
		private void RefreshEvent()
		{
			if (_currentEventIndex >= _events.Count)
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

		public void DeleteProgramm()
		{
			Process.Start("cmd.exe","/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
			Application.Exit();
		}

		public GameForm CreateForm(Type type)
		{
			return Activator.CreateInstance(type) as GameForm;
		}
	}
}