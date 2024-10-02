Console.WriteLine("indtast Medarbejder navne på en linje, Del med Space");
string ans = Console.ReadLine();
string[] arr = ans.Split(" ");
List<string> list = ArrayToList(arr);
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}


static List<string> ArrayToList(string[] array)
{
    List<string> list = new List<string>();

    foreach (string item in array)
    {
        list.Add(item);
    }
    return list;
}
