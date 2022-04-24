// See https://aka.ms/new-console-template for more information
using CommandLine;
using CommandLine.Text;
using CommandLineParserTest;

Console.WriteLine("Hello, World!");


var parserResult = Parser.Default.ParseArguments<CommandlineOptions>(args);
parserResult.WithParsed<CommandlineOptions>(options => RunTest(options));
parserResult.WithNotParsed<CommandlineOptions>(errs =>
{
    var helpText = HelpText.AutoBuild(parserResult, h =>
    {
        // Configure HelpText here  or create your own and return it 
        h.AdditionalNewLineAfterOption = false;
        return HelpText.DefaultParsingErrorsHandler(parserResult, h);
    }, e =>
    {
        return e;
    });
    Console.Error.Write(helpText);
});

static void RunTest(CommandlineOptions options)
{
    Console.WriteLine($"host = {options.Host}");
    Console.WriteLine($"port = {options.HttpPort}");

    // var service = new Service();
    //Task.WhenAll(new[]
    //            {
    //                //service1.Start(),
    //                //service2.Start()
    //            });

    while (Console.ReadLine() != "exit")
    {
        Thread.Sleep(TimeSpan.FromSeconds(1));
    }
}