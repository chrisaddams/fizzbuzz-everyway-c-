using System;


string line;
int counter = 0;
decimal sum = 0;
decimal avg = 0;

// Read the file and display it line by line.  
for (int i = 1; i <= 5; i++)
{
    System.IO.StreamReader file = new System.IO.StreamReader(@"./" + i);

    while ((line = file.ReadLine()) != null)
    {
        decimal val = Convert.ToDecimal(line);
        sum = sum + val;
        counter++;
    }
    file.Close();
    avg = sum / counter;
    string test = "";
    switch (i)
    {
        case 1:
            test = "Switch ";
            break;
        case 2:
            test = "IfElseCont";
            break;
        case 3:
            test = "If Else";
            break;
        case 4:
            test = "If Only";
            break;
        case 5:
            test = "If Cont";
            break;
        default:
            break;
    }

    Console.WriteLine("Average Speed of " + test + " is \t\t" + Math.Round(avg, 2) + " ms");
}

