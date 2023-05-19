namespace ExcelDataExtractor.Core.Constants;

internal static class ExceptionMessages
{
    internal static string UnsupportedFileType => "Unsopported file type";
    internal static string SheetIndexNoExists => "File does not contain the indicated sheet number";
    internal static string MissingExcelFieldAttribute => "All fields of returned model must have 'ExcelField' attribute for validations";
    internal static string NoColumnNameFirstRow => "First row must contain columns names";
    internal static string ExcelFieldColumnNameNullEmpty => "Indicate all columns names";

}
