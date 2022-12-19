using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ItStep
{
    internal class Paralel
    {
        public async static void Paralelnoe() 
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            CancellationToken token = cancellationToken.Token;
            // Это отмена ! Хдыщь
            //new Task(() =>
            //{
            //    Thread.Sleep(400);
            //    cancellationToken.Cancel();
            //}).Start();
            List<Task> list = new List<Task>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(new Task(() =>
                {


                    try
                    {
                        Thread.Sleep(2000);
                        token.ThrowIfCancellationRequested();
                        Console.WriteLine("Hi NIGGERSSTEP");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());

                    }



                }, token));
                list[i].Start();
            }     
               if(token.IsCancellationRequested ) { cancellationToken.Dispose(); }
               else { Task.WaitAll(list.ToArray()); cancellationToken.Dispose(); }
            
        }
    }
}
