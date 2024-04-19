using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UserInterfaces
{
    public class ConsoleUserInterface : IUserInterface
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
