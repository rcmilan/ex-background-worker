using ConsoleWorker.Interfaces;

namespace ConsoleWorker.Services
{
    internal class TextService : InterfaceA
    {
        public string GenerateA(int qtd)
        {
            string text = "";

            for (int i = 0; i < qtd; i++) text += "A";

            return text;
        }
    }
}
