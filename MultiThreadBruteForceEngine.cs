using System;
using System.Threading.Tasks;

namespace PasswordResetBruteForce
{
    public class MultiThreadBruteForceEngine
    {
        private BruteForceGenerator generator =
            new BruteForceGenerator();

        private PasswordValidator validator =
            new PasswordValidator();

        private string foundPassword = "";

        private bool stopSearch = false;

        public string FoundPassword
        {
            get { return foundPassword; }
        }

        public void Stop()
        {
            stopSearch = true;
        }

        public bool Search(string targetHash)
        {
            foundPassword = "";
            stopSearch = false;

            string characters =
                generator.Characters;

            int workerCount =
                Environment.ProcessorCount - 1;

            if (workerCount < 1)
            {
                workerCount = 1;
            }

            Task[] tasks =
                new Task[workerCount];

            int charsPerWorker =
                (int)Math.Ceiling(
                    (double)characters.Length /
                    workerCount);

            for (int worker = 0;
                 worker < workerCount;
                 worker++)
            {
                int start =
                    worker * charsPerWorker;

                int end =
                    Math.Min(
                        start + charsPerWorker,
                        characters.Length);

                tasks[worker] = Task.Run(() =>
                {
                    for (int i = start;
                         i < end;
                         i++)
                    {
                        if (stopSearch)
                        {
                            return;
                        }

                        char firstChar =
                            characters[i];

                        for (int length = 1;
                             length <= 6 && !stopSearch;
                             length++)
                        {
                            Generate(
                                firstChar.ToString(),
                                length,
                                targetHash);
                        }
                    }
                });
            }

            Task.WaitAll(tasks);

            return foundPassword != "";
        }

        private void Generate(
            string current,
            int targetLength,
            string targetHash)
        {
            if (stopSearch)
            {
                return;
            }

            if (current.Length == targetLength)
            {
                if (validator.IsMatch(
                    current,
                    targetHash))
                {
                    foundPassword = current;
                    stopSearch = true;
                }

                return;
            }

            foreach (char c in generator.Characters)
            {
                if (stopSearch)
                {
                    return;
                }

                Generate(
                    current + c,
                    targetLength,
                    targetHash);
            }
        }
    }
}