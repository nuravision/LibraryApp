using LibraryApp.Controllers;
using Service.Enums;
using Service.Helpers.Extentions;

LibraryController libraryController=new LibraryController();
while (true)
{
    GetMenues();
    Operation: Console.Write("Enter choice:");
    string operationStr=Console.ReadLine();
    int operation;
    bool iCorrectOperation=int.TryParse(operationStr, out operation);   
    if (iCorrectOperation)
    {
        switch (operation) { 
            case (int)OperationTypes.LibraryCreate:
                libraryController.Create();
                break;
            case (int)OperationTypes.LibraryDelete:
                Console.WriteLine("Delete");
                break;
            case (int)OperationTypes.LibraryGetAll:
               libraryController.GetAll();
                break;
            default:
                ConsoleColor.Red.WriteConsole("Operation is wrong,please try again:");
                goto Operation;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Operation format is wrong,please try again: ");
        goto Operation;
    }

}
static void GetMenues()
{
    ConsoleColor.Cyan.WriteConsole("Library operations: 1-Create 2-Delete 3-GetAll");

}