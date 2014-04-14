/// <summary>
/// Ninject factory reference exampale.
/// IOC performed by factory extension.
/// </summary>
public class Foo
{
    readonly IBarFactory barFactory;

    public Foo(IBarFactory barFactory)
    {
        this.barFactory = barFactory;
    }

    public Bar Do(int x, int y)
    {
        var bar = this.barFactory.CreateBar(x, y);
        return bar;
    }
}

public interface IBarFactory
{
    Bar CreateBar(int x, int y);
}

public class Bar
{
    public int Height { get; set; }
    public int Length { get; set; }

    public Bar(int y, int x)
    {
        Height = y;
        Length = x;
    }
}
