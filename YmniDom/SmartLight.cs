public class SmartLight
{
    private bool isOn = false;

    public void TurnOn(string message)
    {
        if (!isOn)
        {
            isOn = true;
            Console.WriteLine("[Лампочка]! Включена (триггер: движение)");
        }
    }

    public void TurnOff()
    {
        if (isOn)
        {
            isOn = false;
            Console.WriteLine("[Лампочка]! Выключена (прошло время без движения)");
        }
    }
}