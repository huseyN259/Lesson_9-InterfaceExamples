// Implicit and Explicit

interface IA
{
	void Get();
}

interface IB
{
	void Get();
}

class Some : IA, IB 
{
	// public void Get() => Console.WriteLine("IA and IB"); // implicit

	
	// explicit
	void IA.Get() => Console.WriteLine("IA");
	void IB.Get() => Console.WriteLine("IB");
} 

class Program
{
	static void Main()
	{
		Some some = new Some();
		
		// some.Get(); // not access
		((IA)some).Get();
		((IB)some).Get();
	}
}