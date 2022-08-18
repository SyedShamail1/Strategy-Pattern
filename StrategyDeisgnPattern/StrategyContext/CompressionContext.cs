using StrategyDeisgnPattern.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDeisgnPattern.StrategyContext
{
    public class CompressionContext
    {
        private ICompression compression;

        public CompressionContext(ICompression _compression)
        {
            this.compression = _compression;
        }

        public void SetStrategy(ICompression _compression)
        {
            this.compression = _compression;
        }

        public void CreateArchive(string filePath)
        {
            compression.CompressFolder(filePath);
        }
    }
}
