interface IFoo
{
	void Foo();
}

interface IBoo : IFoo // Extend
{
	void Boo();
}

struct Any : IBoo
{
	public void Boo() => throw new NotImplementedException();
	public void Foo() => throw new NotImplementedException();
}