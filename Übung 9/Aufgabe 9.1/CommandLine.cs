public class CommandLine : ICommandLine
{
    private IComponent _Component;
    private IPersistence _Persistence;

    public CommandLine(IComponent component, IPersistence persistence) => (_Component, _Persistence) = (component, persistence);
    public void ReadConent()
    {
        Console.WriteLine("Enter filename to read from: ");
        string fileName = Console.ReadLine();
        while (!File.Exists(fileName)) {
            Console.WriteLine("Specified filename does not exist. Please enter again: ");
            fileName = Console.ReadLine();
        }
        Console.WriteLine(_Persistence.Read(fileName));
    }


    public void Input()
    {
        Console.WriteLine("Enter the input: ");
        string input = Console.ReadLine();
        string inputAfterLogic = _Component.Operation(input);
        Console.WriteLine("Enter filname for file to store entered input: ");
        string fileName = Console.ReadLine();
        _Persistence.Write(inputAfterLogic, fileName);
    }
}