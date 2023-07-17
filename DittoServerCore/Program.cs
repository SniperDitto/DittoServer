namespace DittoServerCore
{
    class Program
    {
        //휘발성 데이터이므로 어셈블리 최적화 방지 -> while 꼬이는 것 방지(잘 안씀)
        //디버그 모그와 일반 실행 차이 발생 방지
        volatile static bool _stop = false;

        static void ThreadMain()
        {
            Console.WriteLine("thread 1 start");

            while (_stop==false)
            {
                //_stop이 true가 될 때까지 계속 실행
                
            }
            
            Console.WriteLine("thread 1 end");
        }
        
        static void Main(string[] args)
        {
            Task t = new Task(ThreadMain);
            t.Start();
            
            Thread.Sleep(1000);//1초 대기
            _stop = true;

            Console.WriteLine("쓰레드 종료 대기");
            
            t.Wait();//쓰레드가 종료될 때까지 대기

            Console.WriteLine("쓰레드 종료됨");
        }
    }
}




