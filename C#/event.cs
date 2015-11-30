public class Thermostat
{
	public class TemperatureArgs: System.EventArgs
	{
		public TemperatureArgs(float newTemperature)
		{
			NewTemperature = newTemperature;
		}

		public float NewTemperature{
			get{return _newTemperature;}
			set{_newTemperature = value;}
		}
		private float _newTemperature;
	}

	public delegate void TemperatureChangeHandler(
		object sender, TemperatureArgs newTemperature);

	public event TemperatureChangeHandler OnTemperatureChanged;

	public float CurrentTemperature
	{
		get{return _CurrentTemperature;}
		set
		{
			if(value != CurrentTemperature)
			{
				_CurrentTemperature = value;

				if(OnTemperatureChanged != null)
					OnTemperatureChanged(this, new TemperatureArgs(value ));
			}
		}
	}
	private float _CurrentTemperature;
}