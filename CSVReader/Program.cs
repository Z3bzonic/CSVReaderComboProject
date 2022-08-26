using CSVReader;

var strm = new StreamReader("../../../../telewerkers.csv");
var strmline = new List<string>();
var strmWrt = new StreamWriter("../../../../telewerkerLines.txt");
var cvhndl = new CsvHandler(strm, strmline, strmWrt);

cvhndl.WriteFile();