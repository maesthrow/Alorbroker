namespace Infrastructure.UserInterfaces
{

    public class ConsoleUserInterface : IUserInterface
    {
        #region Interfaces

        #region IUserInterface

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        #endregion

        #endregion
    }

}