using Bridge.Plataforms;

namespace Bridge.Transmissions
{
    public class Live : ITransmission
    {
        private readonly IPlatform _platform;

        public Live(IPlatform platform)
        {
            _platform = platform;
        }

        public void Boradcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma: {_platform}");
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ****");
        }
    }
}
