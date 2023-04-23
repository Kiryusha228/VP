using System.Text;

namespace FileLib
{
    public class MyFile : IDisposable
    {
        public string Path { get; private set; }
        private FileStream? _stream;
        private StreamReader? _reader;
        private StreamWriter? _writer;
        private bool _isDisposed;
        public MyFile()
        {
            Path = @"C:\Users\Kirill\source\repos\VP_LR10\File.txt";
            Open();
        }
        public MyFile(string path)
        {
            Path = path;
            Open();
        }

        private void Open()
        {
            _stream = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            _reader = new StreamReader(_stream);
            _writer = new StreamWriter(_stream);
        }

        public string? ReadText()
        {
            //_stream.Position = 0;
            _reader!.DiscardBufferedData();
            _stream!.Seek(0, SeekOrigin.Begin);
            string? result = _reader!.ReadToEnd();
            return result;
        }

        public string? ReadText(int count)
        {
            _stream!.Seek(0, SeekOrigin.Begin);
            _reader!.DiscardBufferedData();
            //_stream.Position = 0;
            char[] buffer = new char[count];
            _reader!.Read(buffer, 0, count);
            return new string(buffer);
        }

        public void WriteText(string str)
        {
            //_stream.Seek(0, SeekOrigin.End);
            _writer!.WriteLine(str);
            _writer.Flush();
        }


        public void WriteText(string str, int count)
        {
           //_stream.Seek(0, SeekOrigin.End);
            for (int i = 0; i < count; i++)
            {
                _writer!.Write(str[i]);
            }
            _writer!.Write("\n");
            _writer.Flush();
        }

        

        public void Close()
        {
            _stream!.Flush();
            _writer!.Flush();
            _stream!.Dispose();
        }

        ~MyFile()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                _stream!.Flush();
                _stream!.Dispose();
                _stream.Close();

                _isDisposed = true;
            }
        }



    }
}