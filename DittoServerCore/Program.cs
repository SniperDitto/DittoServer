// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Thread t = new Thread(Test);
        t.Name = "thread 1";
        t.IsBackground = true;//쓰레드 백드라운드 실행 여부(메인 끝나면 같이 끝남)
        t.Start();
        
        Console.WriteLine("waiting for thread to end");
        t.Join();//쓰레드가 끝날 때까지 대기
        
        Console.WriteLine("Hello");
    }

    static void Test()
    {
        while (true)
        {
            Console.WriteLine("Thread 1");

        }
    }    
}


