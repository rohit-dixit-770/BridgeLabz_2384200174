using System;
using System.Reflection;
using Week_4_Assignment_6_Annotion;
class Assignment_6
{
    public static void Main(string[] args)
    {
        //-----------------------------------------------------------------------------------
        Dog dog = new Dog();
        dog.MakeSound();

        //------------------------------------------------------------------------------------
        LegacyAPI legacyAPI = new LegacyAPI();
        legacyAPI.OldFeature();
        legacyAPI.NewFeature();

        //-----------------------------------------------------------------------------------
        UncheckedOperation uncheckedOperation = new UncheckedOperation();
        uncheckedOperation.Operation();

        //----------------------------------------------------------------------------------
        Display display = new Display();
        display.ShowData();

        //-----------------------------------------------------------------------------------
        Check check = new Check();
        check.CheckData();

        //-------------------------------------------------------------------------
        Test test = new Test();
        LogExecutionTimeAttribute.MeasureExecutionTime(Test.Method1, nameof(Test.Method1));
        LogExecutionTimeAttribute.MeasureExecutionTime(Test.Method2, nameof(Test.Method2));

        //--------------------------------------------------------------------------------
        try
        {
            var users = new User("LongUsername123"); // Exceeds max length
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


        //------------------------------------------------------------------------------------
        Userc adminUser = new Userc("ADMIN");
        Userc guestUser = new Userc("GUEST");

        SecureService adminService = new SecureService(adminUser);
        adminService.Invoke("AdminTask"); // Allowed

        SecureService guestService = new SecureService(guestUser);
        guestService.Invoke("AdminTask"); // Access Denied!

        //-------------------------------------------------------------------
        var user = new Usercw { Name = "John Doe", Age = 30 };
        string json = JsonSerializerHelper.SerializeToJson(user);
        Console.WriteLine(json);

        //-------------------------------------------------------------------------------
        var calculator = new ExpensiveCalculator();
        MethodInfo method = typeof(ExpensiveCalculator).GetMethod("Compute");

        Console.WriteLine(CacheHelper.InvokeWithCache(calculator, method, new object[] { 3, 4 }));
        Console.WriteLine(CacheHelper.InvokeWithCache(calculator, method, new object[] { 3, 4 })); // Should return cached result
    }
}

