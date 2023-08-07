using System;
using System.IO;
namespace Day5Exe1
{
    internal class Program
    {
        class FileLogger : IDisposable
        {
            private StreamWriter _writer;
            public FileLogger(string filePath)
            {
                _writer = new StreamWriter(filePath, true); // Append to the existing file
            }
            public void Log(string message)
            {
                _writer.WriteLine(message);
            }
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            protected virtual void Dispose(bool disposing)
            {
                if (disposing)
                {
                    if (_writer != null)
                    {
                        _writer.Dispose();
                        _writer = null;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            using (var logger = new FileLogger("log.txt"))
            {
                logger.Log("Log entry 1");
                logger.Log("Log entry 2");
                logger.Log("Log entry 3");
            }
        }
        
    }
}