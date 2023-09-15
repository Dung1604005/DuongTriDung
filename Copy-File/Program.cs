public static class Main
{
    private static void CopyFileUsingFileInfo(FileInfo fileinf, FineInfo des)
    {
        fileinf.CopyTo(des.FullName, true);

    }
    private static void CopyFileUsingStream(FileInfo fileinf, FineInfo des)
    {
        StreamReader read = null;
        StreamWriter write = null;
        try
        {
            reader = new StreamReader(source.FullName);
            writer = new StreamWriter(des.FullName);
            Char[] buffer = new Char[1024];
            int length;
            while ((length = reader.Read(buffer)) > 0)
            {
                writer.Write(buffer, 0, length);
            }

        }
        finally
        {
            read.Close();
            read.Dispose();
            write.Close();
            write.Dispose();
        }
    }
    static void Main(string[] args)
    {
        
    }

}