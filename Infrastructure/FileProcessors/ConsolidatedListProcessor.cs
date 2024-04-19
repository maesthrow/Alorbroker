using Domain.Interfaces;
using Infrastructure.UserInterfaces;

namespace Infrastructure.FileProcessors
{

    public class ConsolidatedListProcessor : IFileProcessor
    {
        #region Fields

        private readonly IDataService<CONSOLIDATED_LIST> _dataService;
        private readonly IUserInterface _userInterface;

        #endregion

        #region Constructors

        public ConsolidatedListProcessor(IDataService<CONSOLIDATED_LIST> dataService, IUserInterface userInterface)
        {
            _dataService = dataService;
            _userInterface = userInterface;
        }

        #endregion

        #region Interfaces

        #region IFileProcessor

        public async Task ProcessData(string fullFilePath)
        {
            var filePath = Path.GetFileName(fullFilePath);
            _userInterface.ShowMessage($"Загрузка данных из файла '{filePath}'...");
            var data = await _dataService.LoadDataFromFile(fullFilePath);

            _userInterface.ShowMessage("Сохранение в базу данных...");
            await _dataService.SaveData(data);

            _userInterface.ShowMessage($"Файл '{filePath}' обработан успешно.");
        }

        #endregion

        #endregion
    }

}