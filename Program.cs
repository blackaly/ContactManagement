using Autofac;
using DbContext;
using Files;
using Modules;
using Repository;
using Services;
using Validation;

public class Program
{
    static void Main(string[] args)
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule(new AppModule());
        var container = builder.Build();


        var excel = container.Resolve<ExcelFile>();

        Console.WriteLine(@"_________                __                 __       _____                                                             __   
\_   ___ \  ____   _____/  |_  ____   _____/  |_    /     \ _____    ____ _____     ____   ____   _____   ____   _____/  |_ 
/    \  \/ /  _ \ /    \   __\/ __ \ /    \   __\  /  \ /  \\__  \  /    \\__  \   / ___\_/ __ \ /     \_/ __ \ /    \   __\
\     \___(  <_> )   |  \  | \  ___/|   |  \  |   /    Y    \/ __ \|   |  \/ __ \_/ /_/  >  ___/|  Y Y  \  ___/|   |  \  |  
 \______  /\____/|___|  /__|  \___  >___|  /__|   \____|__  (____  /___|  (____  /\___  / \___  >__|_|  /\___  >___|  /__|  
        \/            \/          \/     \/               \/     \/     \/     \//_____/      \/      \/     \/     \/      ");

        Console.WriteLine(@" __      __       .__                               
/  \    /  \ ____ |  |   ____  ____   _____   ____  
\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \ 
 \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/ 
  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >
       \/       \/          \/            \/     \/ ");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Enter the full path name of the file: ");
        excel.Path = Console.ReadLine();
        if (string.IsNullOrEmpty(excel.Path))
        {
            Console.WriteLine("No input!");
            return;
        }
        excel.AddContactToDatabase();

        excel.PrintContacts();

    }
}