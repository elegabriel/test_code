using System;

class Cooler
{
	public Cooler(float temperature)
	{
		Temperature = temperature;
	}

	public float Temperature
	{
		get{return _Temperature;}
		set{_Temperature = value;}
	}
	private float _Temperature;

	public void OnTemperatureChanged(float newTemperature)
	{
		if (newTemperature > Temperature)
		{
			System.Console.WriteLine("Cooler : On");
		}
		else
		{
			System.Console.WriteLine("Cooler : Off");
		}
	}
}

class Heater
{
	public Heater(float temperature)
	{
		Temperature = temperature;
	}

	public float Temperature
	{
		get{return _Temperature;}
		set{_Temperature = value;}
	}
	private float _Temperature;

	public void OnTemperatureChanged(float newTemperature)
	{
		if (newTemperature < Temperature)
		{
			System.Console.WriteLine("Heater : On");
		}
		else
		{
			System.Console.WriteLine("Heater : Off");
		}
	}
}

public class Thermostat
{
	public Action<float> OnTemperatureChanged {get;set;}

	public float CurrentTemperature
	{
		get{return _CurrentTemperature;}
		set
		{
			if(value != CurrentTemperature)
			{
				_CurrentTemperature = value;

				Action <float> localOnChange = OnTemperatureChanged;
				if(localOnChange != null)
					localOnChange(value);
			}
		}
	}
	private float _CurrentTemperature;
}

class Program
{
	public static void Main()
	{
		Thermostat thermostat = new Thermostat();
		Heater heater = new Heater(60);
		Cooler cooler = new Cooler(80);
//		string temperature;

//		thermostat.OnTemperatureChanged += heater.OnTemperatureChanged;
//		thermostat.OnTemperatureChanged += cooler.OnTemperatureChanged;

		Console.Write("Enter temperature: ");
		string temperature = Console.ReadLine();
		thermostat.CurrentTemperature = int.Parse(temperature);
	}
}