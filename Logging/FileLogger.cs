namespace FixturesDemo.Logging;

public static class FileLogger
{
    private const string FilePath = @"output.log";
    private static readonly object LockObject = new object();

    static FileLogger()
    {
        lock (LockObject)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
        }
    }

    public static void Log(string message)
    {
        lock (LockObject)
        {
            File.AppendAllText(FilePath, $"{message}{Environment.NewLine}");
        }
    }
}