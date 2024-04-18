using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{

    public class Program
    {
        #region Fields

        private readonly IDataService<CONSOLIDATED_LIST> _dataService;

        #endregion

        #region Constructors

        public Program(IDataService<CONSOLIDATED_LIST> dataService) => _dataService = dataService;

        #endregion

        #region Methods

        private static async Task Main(string[] args)
        {
            var serviceProvider = DiManager.ConfigureServices();
            var program = serviceProvider.GetRequiredService<Program>();
            await program.Run();
        }

        private static void UserStartProcessFile(string filePath)
        {
            Console.WriteLine($"Нажмите Enter для того, чтобы начать обработку файла '{filePath}'");
            Console.ReadLine();
        }

        private static void UserCloseApp()
        {
            Console.WriteLine("\nДля выхода нажмите любую клавишу");
            Console.ReadLine();
        }

        private async Task Run()
        {
            await ProcessFile("consolidated-list.xml");
        }

        private async Task ProcessFile(string filePath)
        {
            try
            {
                UserStartProcessFile(filePath);

                Console.WriteLine("Получение данных из файла...");
                var fullFilePath = Path.Combine(Directory.GetCurrentDirectory(), filePath);
                var data = await _dataService.LoadDataFromFile(fullFilePath);

                Console.WriteLine("Сохранение в базу данных...");
                await _dataService.SaveData(data);

                Console.WriteLine("Операция выполнена успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                UserCloseApp();
            }
        }

        #endregion
    }

}