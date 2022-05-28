ICommandLine commandLine = new CommandLine(new ComponentB(), new Persistence());

char input = ' ';
while (input != 'x' && input != 'X') {
    Console.WriteLine("r/R = read file, w/W = write File with content, x = close Program");
    input = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (input == 'r' || input == 'R') {
        commandLine.ReadConent();
    }

    else if (input == 'w' || input == 'W') {
        commandLine.Input();
    }
}

