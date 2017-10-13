namespace Forms.Driving.Infrastructure
{
    public interface IPlatformFileLocator
    {
        string GetLocalFilePath(string filename);
    }
}