abstract class Human
{
	public string? Name { get; set; }
	public string? Surname { get; set; }
	public DateOnly Birthday { get; set; }

	public override string ToString()
		=> $@"{Name}
{Surname}
{Birthday}";
}

abstract class Employee : Human
{
	public string? Position { get; set; }
	public double Salary { get; set; }

	public override string ToString()
		=> $@"{base.ToString()}
{Position}
{Salary}";
}

interface IWorker
{
	bool IsWorking { get; set; }
	void Work();
}

interface IManager
{
	void Organize();
	void Control();
	void MakeBudget();
}

class Seller : Employee, IWorker
{
	public bool IsWorking { get; set; }
	public void Work() => Console.WriteLine("Seller Work");
}

class Cashier : Employee, IWorker
{
	public bool IsWorking { get; set; }
	public void Work() => Console.WriteLine("Cashier Work");
}

class Director : Employee, IWorker, IManager
{
	public bool IsWorking { get; set; }
	public void Work() => Console.WriteLine("Director Work");

	public void Control() => Console.WriteLine("Director Control");

	public void MakeBudget() => Console.WriteLine("Director Budget");

	public void Organize() => Console.WriteLine("Director Organize");

}

class Program
{
	static void Main()
	{
		List<IWorker> workers = new List<IWorker>();

		workers.Add(new Seller());
		workers.Add(new Cashier());
		workers.Add(new Director());

		foreach (var worker in workers)
			worker.Work();
	}
}