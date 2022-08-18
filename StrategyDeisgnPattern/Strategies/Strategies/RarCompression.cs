using StrategyDeisgnPattern.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDeisgnPattern.Strategies.Strategies
{
    public class RarCompression : ICompression
    {
        public void CompressFolder(string filePath)
        {
            Console.WriteLine("Folder will be converted to Rar If RarCompression is passed from context here.");
        }
    }
}
