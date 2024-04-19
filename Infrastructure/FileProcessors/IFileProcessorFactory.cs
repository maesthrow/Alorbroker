namespace Infrastructure.FileProcessors
{

    public interface IFileProcessorFactory
    {
        #region Methods

        IFileProcessor CreateProcessor(string fullFilePath);

        #endregion
    }

}