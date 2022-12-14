string data = ReadString("Введите данные через запятую:");
string[] stringData = data.Split(new char[] { ',' });
string[] stringRezult = StringFilter(stringData);
Console.WriteLine("Ваши данные с длиной строки меньше 4 символов:");
WriteArray(stringRezult);

string[] StringFilter(string[] strlst)
{
    string k = "";
    for (int i = 0; i < strlst.Length; i++)
    {
        if (strlst[i].Length < 4)
        {
            if (i == strlst.Length - 1)
            {
                k += strlst[i];
            }
            else
            {
                k += strlst[i] + ",";
            }
        }
    }
    string[] stringRezult = k.Split(new char[] { ',' });
    return stringRezult;
}


string ReadString(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}


void WriteArray(string[] strlst)
{
    for (int i = 0; i < strlst.Length; i++)
    {
        {
            if (i == strlst.Length - 1)
            {
                Console.Write(strlst[i]);
            }
            else
            {
                Console.Write(strlst[i] + ",");
            }
        }
    }
}
