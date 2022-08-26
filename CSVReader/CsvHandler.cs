namespace CSVReader
{
    public class CsvHandler
    {
        public StreamReader Strm { get; set; }
        public List<string> Strmline { get; }
        public StreamWriter StrmWrt { get; }

        public CsvHandler(StreamReader strm, List<string> strmline, StreamWriter strmWrt)
        {
            Strm = strm;
            Strmline = strmline;
            StrmWrt = strmWrt;
        }

        public void WriteFile()
        {
            while (!Strm.EndOfStream)
            {
                var line = Strm.ReadLine();
                if (line != null)
                {
                    Strmline.Add(line);
                }
            }
            foreach (var line in Strmline)
            {
                StrmWrt.WriteLine(line);
            }
        }
    }
}