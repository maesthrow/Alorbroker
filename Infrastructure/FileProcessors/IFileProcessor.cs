using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FileProcessors
{

    public interface IFileProcessor
    {
        Task ProcessData(string filePath);
    }
}
