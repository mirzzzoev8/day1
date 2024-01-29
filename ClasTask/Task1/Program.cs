List<string> list = new List<string>();
list.Add("apple");
list.Add("banana");
list.Add("orange");
list.Count();
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
list.Remove("banana");
List<string> list2 = new List<string>();
list2.Add("apple");
list2.Add("banana");
list2.Add("orange");
list2.Insert(0,"grape");
list2.RemoveAt(2);
list2.Sort();
list2.Reverse();
list2.RemoveAll(e => e.Length > 5);
list2.Reverse();
string condition = "a";
int cnt = 0;
foreach (var item in list2)
{
    if(item.StartsWith(condition))
    {
        cnt++;
    }
    
}
System.Console.WriteLine(cnt);
string aa = string.Join("",list2);
System.Console.WriteLine(aa);