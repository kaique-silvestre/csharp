using FileManagementProgram;

while (true)
{

    Console.WriteLine("\nFile Management Program\n");

    string InitText = "\n[1] - Create a File\n[2] - Add Text\n[3] - Read File\n[4] - Search Text\n[5] - Exit";

    Console.WriteLine(InitText);


    Console.Write("\nSelect an option: \t");
    string? option = Console.ReadLine();


    switch (option)
    {
        case "1":
            Console.WriteLine("\nCreating the file...");
            FileManagement.CreateFile();
            break;
        case "2":
            Console.WriteLine("\nAdd a Line: ");
            string? Text = Console.ReadLine();
            FileManagement.AppendText(Text);
            break;
        case "3":
            Console.WriteLine();
            FileManagement.ReadText();
            break;
        case "4":
            Console.WriteLine();
            FileManagement.SearchText();
            break;
        case "5" or "0":
            Console.WriteLine("\nExiting the Program");
            return;
        default:
            Console.WriteLine("\n[ATENTION]: Invalid Option");
            break;
    }
}