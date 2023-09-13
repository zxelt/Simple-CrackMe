string __key__ = "zxelt_github";
string __value__;
Console.WriteLine("\r\n$$$$$$$$\\                     $$\\   $$\\     \r\n\\____$$  |                    $$ |  $$ |    \r\n    $$  / $$\\   $$\\  $$$$$$\\  $$ |$$$$$$\\   \r\n   $$  /  \\$$\\ $$  |$$  __$$\\ $$ |\\_$$  _|  \r\n  $$  /    \\$$$$  / $$$$$$$$ |$$ |  $$ |    \r\n $$  /     $$  $$<  $$   ____|$$ |  $$ |$$\\ \r\n$$$$$$$$\\ $$  /\\$$\\ \\$$$$$$$\\ $$ |  \\$$$$  |\r\n\\________|\\__/  \\__| \\_______|\\__|   \\____/ \r\n                                            \r\n                                            \r\n                                            \r\n");

Console.Write("Please Enter The Password: ");
__value__ = Console.ReadLine();
if (__value__ == __key__)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Correct !! ");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Incorect Password !");
}
