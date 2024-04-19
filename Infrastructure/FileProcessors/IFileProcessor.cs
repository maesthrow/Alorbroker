namespace Infrastructure.FileProcessors
{

    public interface IFileProcessor
    {
        #region Properties

        string FullFilePath { get; }

        #endregion

        #region Methods

        Task ProcessData();

        #endregion
    }

}