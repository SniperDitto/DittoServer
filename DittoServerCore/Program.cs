namespace DittoServerCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.SetMinThreads(1, 1);//최소1개
            ThreadPool.SetMaxThreads(5, 5);//최대5개

            for (int i = 0; i < 5; i++)
            {
                //thread + threadPool 장점을 가짐
                Task task = new Task(() => { while (true) { } }, TaskCreationOptions.LongRunning);//오래 걸리는 작업임을 암시 -> 따로 빼서 작업함
                task.Start();
            }
            //따로 빼서 작업했으므로 추가로 알바 고용 가능
            ThreadPool.QueueUserWorkItem(Test);
            Console.WriteLine("Hello");
        }

        static void Test(object? o)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread 1");
            }
        }    
    }
}




