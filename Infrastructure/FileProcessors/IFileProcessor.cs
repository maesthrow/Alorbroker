namespace Infrastructure.FileProcessors
{

    public interface IFileProcessor
    {
        #region Properties

        string FilePath { get; }

        #endregion

        #region Methods

        Task ProcessData();

        #endregion
    }

}