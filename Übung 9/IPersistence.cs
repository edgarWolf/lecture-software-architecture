public interface IPersistence {
    void Write(string output, string fileName);

    string Read(string fileName);
}