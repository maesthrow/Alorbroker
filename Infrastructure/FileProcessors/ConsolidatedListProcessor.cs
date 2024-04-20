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

        public ConsolidatedListProcessor(string filePath, IDataService<CONSOLIDATED_LIST> dataService,
            IUserInterface userInterface)
        {
            FilePath = filePath;
            _dataService = dataService;
            _userInterface = userInterface;
        }

        #endregion

        #region Interfaces

        #region IFileProcessor

        public string FilePath { get; }

        public async Task ProcessData()
        {
            var fileName = Path.GetFileName(FilePath);
            _userInterface.ShowMessage($"Загрузка данных из файла '{fileName}'...");
            var data = await _dataService.LoadDataFromFile(FilePath);

            _userInterface.ShowMessage("Сохранение в базу данных...");
            await _dataService.SaveData(data);

            _userInterface.ShowMessage($"Файл '{fileName}' обработан успешно.");
        }

        #endregion

        #endregion
    }

}