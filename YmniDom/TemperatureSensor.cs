class TemperatureSensor {
    public event TemperatureEventHandler OnOverheat;

    public void CheckTemperature(int currentTemp) {

        if (currentTemp > 30) {
            OnOverheat?.Invoke($"! Температура критическая:  {currentTemp} C!");
        }
    }
}