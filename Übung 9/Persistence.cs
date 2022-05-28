public class Persistence : IPersistence
{
    public void Write(string output, string fileName)
    {
        if (string.IsNullOrEmpty(output)) {
            throw new ArgumentNullException(nameof(output));
        }

        if (string.IsNullOrEmpty(fileName)) {
            throw new ArgumentNullException(nameof(fileName));
        }

        File.WriteAllText(fileName, output);
    }

    public string Read(string fileName)
    {
        return File.ReadAllText(fileName);
    }
}