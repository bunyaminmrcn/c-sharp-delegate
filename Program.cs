namespace c_sharp_delegate;


public delegate void MyDelegate();
public delegate void MyDelegateWithParam(string param);

public delegate int MyDelegateWithParamReturn(int num1, int num2);

class Program
{
    static void Main(string[] args)
    {
        CostumerManager costumerManager = new CostumerManager();
        //costumerManager.Alert();
        //costumerManager.Notify();
        MyDelegate myDelegate = costumerManager.Notify;
        myDelegate += costumerManager.Alert;
        myDelegate -= costumerManager.Notify;

        MyDelegateWithParam myDelegateWithParam = costumerManager.Message;


        Math math = new Math();

        MyDelegateWithParamReturn myDelegateWithParamReturn = math.Add;
        myDelegate();
        myDelegateWithParam("Hi");
        Console.WriteLine(myDelegateWithParamReturn(1, 2));
        
    }
}


public class CostumerManager
{
    public void Notify()
    {
        Console.WriteLine("Notifying");
    }

    public void Alert()
    {
        Console.WriteLine("Alerting");
    }
     public void Message(string message)
    {
        Console.WriteLine(message);
    }
}

public class Math {
    public int Add(int num1, int num2) {
        return num1 + num2;
    }

    public int Multiply(int num1, int num2) {
        return num1 * num2;
    }
}