using Domain.Interfaces;
using Infrastructure.FileProcessors;
using Infrastructure.UserInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{

    public class Program
    {
        #region Fields

        // словарь для хранения соответствий для файлов и их обработчиков: { имя_файла, IFileProcessor }
        private readonly Dictionary<string, IFileProcessor> _fileSourceDict = new();

        #endregion

        #region Constructors

        public Program(IDataService<CONSOLIDATED_LIST> dataService)
        {
            _fileSourceDict.Add("consolidated-list.xml",
                new ConsolidatedListProcessor(dataService, new ConsoleUserInterface()));
        }

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

        private static void UserStartProcessFile()
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
            if (_fileSourceDict.Count == 0)
            {
                UserCloseApp("Не указаны файлы для загрузки данных.");

                return;
            }

            UserStartProcessFile();

            foreach (var kvp in _fileSourceDict)
            {
                var filePath = kvp.Key;
                var processor = kvp.Value;

                try
                {
                    var fullFilePath = Path.Combine(Directory.GetCurrentDirectory(), filePath);
                    await processor.ProcessData(fullFilePath);
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