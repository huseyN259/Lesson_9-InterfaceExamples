// Interface (can do, multiple base)
// Inheritance (is a), Association (has a, part)

namespace Lesson_9_1;

interface IFighter
{
	void Attack();
	void Fire();
	void Shot();
}

interface IKiller
{
	void Kill();
}

interface IManage
{
	void Control();
	void CompleteMission();
	void GatherPeople();
}

class Fighter : IFighter, IKiller
{
	public void Attack() => Console.WriteLine("Attack !");

	public void Fire() => Console.WriteLine("Fire !");

	public void Kill() => Console.WriteLine("Kill !");

	public void Shot() => Console.WriteLine("Shot !");
}

class Commander : Fighter, IManage
{
	public void CompleteMission() => Console.WriteLine("Complete Mission !");

	public void Control() => Console.WriteLine("Control !");

	public void GatherPeople() => Console.WriteLine("Gather People !");
}

class Program
{
	static void Main()
	{
		
	}
}