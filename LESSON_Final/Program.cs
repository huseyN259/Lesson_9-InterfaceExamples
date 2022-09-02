// Default Implementation

interface IDraw
{
	void Erase() // default implementation
	{
		Console.WriteLine("Erase");
	}

	void Draw();
}

class Rectangle : IDraw
{
	public void Erase() => Console.WriteLine("Rectangle Erase");
	public void Draw() => Console.WriteLine("Rectangle Draw");
}

class Circle : IDraw
{
	public void Erase() => Console.WriteLine("Circle Erase");

	public void Draw() => Console.WriteLine("Circle Draw");
}

class Program
{
	static void Main()
	{
		List<IDraw> list = new List<IDraw>();

		list.Add(new Rectangle());
		list.Add(new Circle());

		foreach (var l in list)
			l.Erase();
	}
}