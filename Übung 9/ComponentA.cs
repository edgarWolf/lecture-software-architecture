public class ComponentA : IComponent
{
    public string Operation(string input)
    {
        if (string.IsNullOrEmpty(input)) {
            throw new ArgumentNullException(input);
        }

        return input.ToUpper();
    }
}