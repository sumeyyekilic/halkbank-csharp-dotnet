using AbstractVSInterface;

WordDocument word = new WordDocument();
PdfDocument pdf = new PdfDocument();
ExcelDocument excel = new ExcelDocument();

PrinterComponent printer= new PrinterComponent();
printer.Print(word);
//printer.Print(pdf);
printer.Print(excel);
