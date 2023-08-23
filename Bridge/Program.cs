using Bridge.Plataforms;
using Bridge.Transmissions;

static void StartLive(IPlatform platform)
{
    Console.WriteLine("Aguarde...");

    Live live = new Live(platform);

    live.Boradcasting();
    live.Result();
}

static void StartLiveAdvance(IPlatform platform)
{
    Console.WriteLine("Aguarde...");

    AdvancedLive advancedLive = new AdvancedLive(platform);

    advancedLive.Boradcasting();
    advancedLive.Result();
    advancedLive.Subtitle();
    advancedLive.Comments();
    advancedLive.Record();
}

StartLive(new Youtube());
StartLiveAdvance(new Facebook());
StartLive(new TwitchTV());
StartLiveAdvance(new DeLive());
Console.ReadLine();