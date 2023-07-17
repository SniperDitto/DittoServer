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
                //끝나지 않도록 5개 실행해서 남는 알바가 없도록 만든다
                ThreadPool.QueueUserWorkItem(state => { while (true) { } });
            }
            //남는 알바가 없어서 고용 불가
            ThreadPool.QueueUserWorkItem(Test);//단기알바고용

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




