
public static class ExampleFactory
{
    private const int DEFAULT = 50;
    public static ExampleFactoryObject getExampleObject(int num = DEFAULT)
    {
        return new ExampleFactoryObject(num);
    }
}
