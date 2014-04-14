using System;

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

    public void Do(int x, int y)
    {
        var bar = this.barFactory.CreateBar(x, y);
    }
}

public interface IBarFactory
{
    Bar CreateBar(int x, int y);
}

public class Bar
{
    public Bar(int y, int x)
    {
    }
}
