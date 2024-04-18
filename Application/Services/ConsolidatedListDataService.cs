using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Application.Services
{

    public class ConsolidatedListDataService : IDataService<CONSOLIDATED_LIST>
    {
        #region Fields

        private readonly IXmlDataService<CONSOLIDATED_LIST> _xmlDataService;
        private readonly IRepository<ConsolidatedList> _consolidatedListRepository;
        private readonly IMapper<CONSOLIDATED_LIST, ConsolidatedList> _mapper;

        #endregion

        #region Constructors

        public ConsolidatedListDataService(IXmlDataService<CONSOLIDATED_LIST> xmlDataService,
            IRepository<ConsolidatedList> consolidatedListRepository,
            IMapper<CONSOLIDATED_LIST, ConsolidatedList> mapper)
        {
            _xmlDataService = xmlDataService;
            _consolidatedListRepository = consolidatedListRepository;
            _mapper = mapper;
        }

        #endregion

        #region Interfaces

        #region IDataService<CONSOLIDATED_LIST>

        public async Task<CONSOLIDATED_LIST> LoadDataFromFile(string xmlFilePath)
        {
            try
            {
                var result = await _xmlDataService.LoadFromXml(xmlFilePath);

                return result;
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception($"Ошибка. Файл для загрузки не найден: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"При загрузке данных из файла '{xmlFilePath}' произошла ошибка: {ex.Message}");
            }
        }

        public async Task SaveData(CONSOLIDATED_LIST data)
        {
            try
            {
                var consolidatedList = _mapper.Map(data);
                await _consolidatedListRepository.AddAsync(consolidatedList);
            }
            catch (Exception ex)
            {
                throw new Exception($"При сохранении в базу данных произошла ошибка: {ex.Message}");
            }
        }

        #endregion

        #endregion
    }

}