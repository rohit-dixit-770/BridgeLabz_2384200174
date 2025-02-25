using System;
using Week_5_Assignment_1;
class Assignment_1
{
    public static void Main(string[] args)
    {
        ReadCSVFile readCSVFile = new ReadCSVFile();
        readCSVFile.ReadFile();

        //--------------------------------------------------------------------------
        WriteDataInCsvFile writeDataInCsvFile = new WriteDataInCsvFile();
        writeDataInCsvFile.WriteFile();

        //------------------------------------------------------------------
        CountRowInCSVFIle countRow = new CountRowInCSVFIle();
        countRow.CountRow();

        //--------------------------------------------------------------------------
        FilterRrecord filterRrecord = new FilterRrecord();
        filterRrecord.FilterStudent();

        //----------------------------------------------------------
        SearchEmployee searchEmployee = new SearchEmployee();
        searchEmployee.EmployeeSearch();

        //-----------------------------------------------------------------------------

        SortCsvFileBySalary sortCsvFileBySalary = new SortCsvFileBySalary();
        sortCsvFileBySalary.SalarySort();
        //-----------------------------------------------------------------------
        ModifyValue modifyValue = new ModifyValue();
        modifyValue.ValueModify();

        //-----------------------------------------------------------------------------------
        ValidateCsvData validateCsvData = new ValidateCsvData();
        validateCsvData.DataValidate();

        //---------------------------------------------------------------------------------------
        CSVDataIntoJavaObject cSVDataIntoJavaObject = new CSVDataIntoJavaObject();
        cSVDataIntoJavaObject.ConvertIntoJavaObject();

        //-----------------------------------------------------------------------------------------------
        MergeTwoCSV mergeTwoCSV = new MergeTwoCSV();
        mergeTwoCSV.TwoCsvMerge();

        //--------------------------------------------------------------------------------------
        ReadLargeCsvFile readLargeCsvFile = new ReadLargeCsvFile();
        readLargeCsvFile.LargeRead();

        //-------------------------------------------------------------------------------------------
        DetectDuplicate detectDuplicate = new DetectDuplicate();
        detectDuplicate.Duplicate();

        //-------------------------------------------------------------------------------------------
        CsvReportFromDatabase csvReportFromDatabase = new CsvReportFromDatabase();
        csvReportFromDatabase.Database();
        //---------------------------------------------------------------------------------------
        JsonToCsvConvert json = new JsonToCsvConvert();
        json.ConvertJsonToCsv();

        //----------------------------------------------------------------------------------------------------------
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();
        encryptDecrypt.EncryptAndDecrypt();
    }
}