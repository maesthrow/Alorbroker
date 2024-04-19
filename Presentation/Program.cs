using Infrastructure.FileProcessors;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{

    public class Program
    {
        #region Fields

        private readonly List<IFileProcessor> _fileProcessors;

        #endregion

        #region Constructors

        public Program(IEnumerable<IFileProcessor> fileProcessors) => _fileProcessors = fileProcessors.ToList();

        #endregion

        #region Methods

        private static async Task Main(string[] args)
        {
            try
            {
                var serviceProvider = DiManager.ConfigureServices();
                var program = serviceProvider.GetRequiredService<Program>();
                await program.Run();
            }
            catch (Exception ex)
            {
                UserCloseApp($"Ошибка во время выполнения: {ex.Message}");
            }
        }

        private static void UserStartProcessFiles()
        {
            Console.WriteLine("\nНажмите Enter для того, чтобы начать обработку файлов");
            Console.ReadLine();
        }

        private static void UserCloseApp(string? afterProcessMessage = null)
        {
            afterProcessMessage ??= string.Empty;
            Console.WriteLine($"{afterProcessMessage}\nДля выхода нажмите любую клавишу");
            Console.ReadKey();
        }

        private async Task Run()
        {
            if (_fileProcessors.Count == 0)
            {
                UserCloseApp("Не указаны файлы для загрузки данных.");

                return;
            }

            UserStartProcessFiles();

            foreach (var processor in _fileProcessors)
            {
                try
                {
                    await processor.ProcessData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            UserCloseApp("\nОбработка всех файлов завершена.");
        }

        #endregion
    }

}