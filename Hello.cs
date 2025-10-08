using System;
using System.Threading;

namespace ActionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cores para o terminal
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("🚀 Bem-vindo ao Hello World em C#! 🚀\n");
            
            // Animação de loading
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Carregando");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine("\n");
            
            // Mensagem principal com estilo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║        🌟 HELLO WORLD! 🌟            ║");
            Console.WriteLine("║                                      ║");
            Console.WriteLine("║  Desenvolvido com ❤️  em C#         ║");
            Console.WriteLine("║  Data: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "        ║");
            Console.WriteLine("╚══════════════════════════════════════╝\n");
            
            // Interação com o usuário
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Digite seu nome: ");
            Console.ForegroundColor = ConsoleColor.White;
            string nome = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(nome))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n🎉 Olá, {nome}! Seja muito bem-vindo(a)! 🎉");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n🎉 Olá, Visitante! Seja muito bem-vindo(a)! 🎉");
            }
            
            // Informações do sistema
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n📊 Informações do Sistema:");
            Console.WriteLine($"   • Versão do .NET: {Environment.Version}");
            Console.WriteLine($"   • Sistema Operacional: {Environment.OSVersion}");
            Console.WriteLine($"   • Arquitetura: {Environment.OSVersion.Platform}");
            Console.WriteLine($"   • Diretório atual: {Environment.CurrentDirectory}");
            
            // Contagem regressiva
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n⏰ Fechando em:");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"   {i}... ");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n\n👋 Até logo! Obrigado por usar este Hello World! 👋");
            
            // Reset das cores
            Console.ResetColor();
            
            // Pausa antes de fechar
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
