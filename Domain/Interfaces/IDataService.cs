namespace Domain.Interfaces
{

    public interface IDataService<T> where T : class
    {
        #region Methods

        Task<T> LoadDataFromFile(string xmlFilePath);

        Task SaveData(T data);

        #endregion
    }

}