




//Date date1 = new Date(2022, 2, 11);
//Console.WriteLine(date1);

try
{
	Console.WriteLine(new Date(2024, 1, 31));
	Console.WriteLine(new Date(2022, 10, 1));
	Console.WriteLine(new Date(2022, 2, 19));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}

Console.Read();

