using System;
using System.Windows.Forms;
using Setup.exe.GameForms;

namespace Setup.exe
{
	public class GameManager
	{
		private static GameManager _instance;

		private readonly Type[] _events =
		{
			typeof (Form_Welcome),
			typeof(Form_Welcome)
		};

		private int _currentEventIndex;

		private GameForm _currentForm;

		public static GameManager Instance
		{
			get
			{
				if (_instance == null)
					_instance = new GameManager();
				return _instance;
			}
		}

		private Type CurrentFormType => _events[_currentEventIndex];

		public void StartGame()
		{
			_currentForm = CreateForm(CurrentFormType);
			_currentForm.Show();
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