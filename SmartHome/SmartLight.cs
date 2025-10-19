class SmartLight
{
    public bool IsOn { get; private set; }
    public int Brightness { get; private set; }

    public event Action<bool> OnStateChanged;

    public SmartLight()
    {
        IsOn = false;
        Brightness = 50;
    }

    public SmartLight(bool isOn, int brightness)
    {
        IsOn = isOn;
        Brightness = brightness;
    }

    public void Toggle()
    {
        IsOn = !IsOn;
        OnStateChanged?.Invoke(IsOn);
    }

    public void SetBrightness(int brightness)
    {
        if (brightness < 0) brightness = 0;
        if (brightness > 100) brightness = 100;

        Brightness = brightness;
        Console.WriteLine($"Яркость установлена: {Brightness}");
    }

    public void PrintStatus()
    {
        string status = IsOn ? "вкл" : "выкл";
        Console.WriteLine($"Состояние: {status}, Яроксть: {Brightness}");
    }
}