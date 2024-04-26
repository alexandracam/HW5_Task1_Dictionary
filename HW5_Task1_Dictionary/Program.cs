// Alexandra Camarena
// MIS 3013 HW5 Task 1 Dictionary


Dictionary<string, Client> clientDict;
clientDict = new Dictionary<string, Client>();

string m;
string userInput;

Console.Write("Would you like to input another client? (yes/no) ");
userInput = Console.ReadLine();
userInput = userInput.ToLower();
while (userInput=="yes"||userInput=="y")
{
    m = string.Format($"Please input client {clientDict.Count+1} name: ");
    Console.Write(m);
    string name = Console.ReadLine();

    m = string.Format($"Please input client {clientDict.Count + 1} ID: ");
    Console.Write(m);
    string id = Console.ReadLine();

    m = string.Format($"Please input client {clientDict.Count + 1} balance: ");
    Console.Write(m);
    string balanceStr = Console.ReadLine();
    double balance = Convert.ToDouble(balanceStr);

    m = string.Format($"Please input client {clientDict.Count + 1} age: ");
    Console.Write(m);
    string ageStr = Console.ReadLine();
    int age = Convert.ToInt32(ageStr);

    m = string.Format($"Please input client {clientDict.Count + 1} weight: ");
    Console.Write(m);
    string weightStr = Console.ReadLine();
    double weight = Convert.ToDouble(weightStr);

    Client newClient = new Client();
    newClient.name = name;
    newClient.id = id;
    newClient.balance = balance;
    newClient.age = age;
    newClient.weight = weight;

    clientDict.Add(newClient.id, newClient);

    Console.Write("Would you like to input another client? (yes/no) ");
    userInput = Console.ReadLine();
    userInput = userInput.ToLower();

}

Console.WriteLine("All Clients");
int i = 0;
double sumOfBalance = 0;
foreach (Client client in clientDict.Values)
{
    m = string.Format($"Client {i+1}, Name: {client.name}, ID: {client.id}");
    Console.WriteLine(m);
    sumOfBalance = sumOfBalance + client.balance;
    i++;
}

double aveBalance = sumOfBalance/clientDict.Count;
m = string.Format($"The average balance is {aveBalance:C2}");
Console.WriteLine(m);

Console.WriteLine("Please input a client ID: ");
userInput= Console.ReadLine();
if (clientDict.ContainsKey(userInput))
{
    m = string.Format($"\nName: {clientDict[userInput].name}, ID: {clientDict[userInput].id}, Balance: {clientDict[userInput].balance}, Age: {clientDict[userInput].age}, Weight: {clientDict[userInput].weight:F2}");
    Console.WriteLine(m);
}
else
{
    Console.WriteLine($"Sorry! We do not have a client with ID {userInput}!");
}
public class Client
{
    public string name;
    public string id;
    public double balance;
    public int age;
    public double weight;

}