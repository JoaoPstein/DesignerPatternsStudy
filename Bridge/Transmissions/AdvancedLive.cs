using Bridge.Plataforms;

namespace Bridge.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform): base(platform) { }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na live.");
        }

        public void Record()
        {
            Console.WriteLine("Gravação da live iniciada.");
        }
    }
}
