
Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["name"] = "Jane";
cookies["age"] = "25";
cookies["birthday"] = "2021-05-25";
cookies["email"] = "jane@mail.com";

Console.WriteLine(cookies["name"]);

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}

Console.WriteLine("--------------");

foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}