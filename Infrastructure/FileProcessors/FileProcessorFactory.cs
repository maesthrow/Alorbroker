using Domain.Interfaces;
using Infrastructure.UserInterfaces;

namespace Infrastructure.FileProcessors
{

    public class FileProcessorFactory : IFileProcessorFactory
    {
        #region Fields

        private readonly IDataService<CONSOLIDATED_LIST> _consolidatedListDataService;
        private readonly IUserInterface _userInterface;

        #endregion

        #region Constructors

        public FileProcessorFactory(IDataService<CONSOLIDATED_LIST> consolidatedListDataService,
            IUserInterface userInterface)
        {
            _consolidatedListDataService = consolidatedListDataService;
            _userInterface = userInterface;
        }

        #endregion

        #region Interfaces

        #region IFileProcessorFactory

        public IFileProcessor CreateProcessor(string filePath)
        {
            var fileName = Path.GetFileName(filePath);

            return fileName switch
            {
                "consolidated-list.xml" =>
                    new ConsolidatedListProcessor(filePath, _consolidatedListDataService, _userInterface),

                var _ => throw new ArgumentException(
                    $"Не найдена реализация интерфейса IFileProcessor для файла '{fileName}'")
            };
        }

        #endregion

        #endregion
    }

}