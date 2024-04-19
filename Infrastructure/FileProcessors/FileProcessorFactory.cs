using Domain.Interfaces;
using Infrastructure.UserInterfaces;

namespace Infrastructure.FileProcessors
{

    public class FileProcessorFactory : IFileProcessorFactory
    {
        #region Fields

        private readonly IDataService<CONSOLIDATED_LIST> _dataService;
        private readonly IUserInterface _userInterface;

        #endregion

        #region Constructors

        public FileProcessorFactory(IDataService<CONSOLIDATED_LIST> dataService, IUserInterface userInterface)
        {
            _dataService = dataService;
            _userInterface = userInterface;
        }

        #endregion

        #region Interfaces

        #region IFileProcessorFactory

        public IFileProcessor CreateProcessor(string fullFilePath)
        {
            if (fullFilePath.EndsWith("consolidated-list.xml", StringComparison.Ordinal))
                return new ConsolidatedListProcessor(fullFilePath, _dataService, _userInterface);

            throw new ArgumentException(
                $"Не найдена реализация интерфейса IFileProcessor для файла '{Path.GetFileName(fullFilePath)}'");
        }

        #endregion

        #endregion
    }

}