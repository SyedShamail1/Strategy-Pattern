using StrategyDeisgnPattern.Strategies.Strategies;
using StrategyDeisgnPattern.StrategyContext;
using System;

namespace StrategyDeisgnPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressionContext compressionContext = new CompressionContext(new RarCompression());
            compressionContext.CreateArchive("asfhasf");

            compressionContext.SetStrategy(new ZipCompression());
            compressionContext.CreateArchive("alsfaslf");

        }
    }
}
