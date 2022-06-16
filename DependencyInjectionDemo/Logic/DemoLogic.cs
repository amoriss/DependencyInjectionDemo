namespace DependencyInjectionDemo.Logic;

public class DemoLogic
{
    public int Value1 { get; private set; } 
    public int Value2 { get; private set; }
    public DemoLogic()
    {
        Value1 = Random.Shared.Next(minValue: 1, maxValue: 1001);
        Value1 = Random.Shared.Next(minValue: 1, maxValue: 1001);
    }
}
