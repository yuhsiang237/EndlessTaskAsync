using System;
using System.Threading.Tasks;

namespace EndlessTaskAsync
{
    class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        /// <returns></returns>
        public static async Task Main()
        {
            var endlessTask1 = EndlessTask(1);
            var endlessTask2 = EndlessTask(2);

            await PreventToStop();
        }

        /// <summary>
        /// 製作無止盡的 while task
        /// </summary>
        /// <param name="number">編號</param>
        /// <returns></returns>
        private static Task EndlessTask(int number)
        {
            Console.WriteLine("Start EndlessTask" + number);
            var endlessTask = Task.Run(async () =>
            {
                while (true)
                {
                    Console.WriteLine("EndlessTask" + number);
                    await Task.Delay(100);
                }
            });
            return Task.CompletedTask;
        }

        /// <summary>
        /// 避免視窗關閉，使用ReadKey();
        /// </summary>
        /// <returns></returns>
        private static Task PreventToStop()
        {
            Console.ReadKey();
            return Task.CompletedTask;
        }
    }
}
