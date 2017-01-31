using System.Collections.Generic;
using System.IO;

namespace SimpleToster.Shared
{
    public class QuestionnairesDirectoryScanner
    {
        private readonly string directoryPath;

        public QuestionnairesDirectoryScanner(string directoryPath)
        {
            this.directoryPath = directoryPath;
        }

        public IEnumerable<string> GetFileNames()
        {
            if (!Directory.Exists(this.directoryPath))
            {
                throw new DirectoryNotFoundException("Brak podanego folderu: " + this.directoryPath);
            }

            var filePaths = Directory.EnumerateFiles(this.directoryPath);

            foreach (var filePath in filePaths)
            {
                yield return Path.GetFileName(filePath);
            }
        }
    }
}