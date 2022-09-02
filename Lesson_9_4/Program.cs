// SOLID
// Interface Segregation Principle

interface IAudioPlayer
{
	void PlayAudio();
}

interface IVideoPlayer
{
	void PlayVideo();
}

class DivMediaPlayer : IAudioPlayer, IVideoPlayer
{
	public void PlayAudio() => Console.WriteLine("Play Audio");

	public void PlayVideo() => Console.WriteLine("Play Video");
}

class WinApp : IAudioPlayer
{
	public void PlayAudio() => Console.WriteLine("Just Audio");
}

class VideoPlayer : IVideoPlayer
{
	public void PlayVideo() => Console.WriteLine("Just Video");
}

class Program
{
	static void Main()
	{
		List<IAudioPlayer> players = new();

		players.Add(new DivMediaPlayer());
		players.Add(new WinApp());
		//players.Add(new VideoPlayer()); // not work !

		foreach (var player in players)
			player.PlayAudio();
	}
}