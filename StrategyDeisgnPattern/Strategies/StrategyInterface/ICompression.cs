using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDeisgnPattern.StrategyInterface
{
    public interface ICompression
    {
        void CompressFolder(string filePath);
    }
}
