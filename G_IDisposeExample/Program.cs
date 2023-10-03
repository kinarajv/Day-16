using System;
using System.IO;

public class ResourceHandler : IDisposable
{
    private MemoryStream memoryStream;
    private FileStream fileStream;
    private bool disposed = false;

    public ResourceHandler(string filePath)
    {
        memoryStream = new MemoryStream();
        fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    }

    public void WriteToMemory(string content)
    {
        if (disposed)
        {
            throw new ObjectDisposedException("ResourceHandler");
        }

        byte[] data = System.Text.Encoding.UTF8.GetBytes(content);
        memoryStream.Write(data, 0, data.Length);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                    memoryStream = null;
                }
            }
            if (fileStream != null)
            {
                fileStream.Close();
                fileStream = null;
            }

            disposed = true;
        }
    }

    ~ResourceHandler()
    {
        Dispose(false);
    }
}