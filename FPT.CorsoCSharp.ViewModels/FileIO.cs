using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FPT.CorsoCSharp.ViewModels
{
    public static class FileIO
    {
        public static Task CopyAsync(string s1, string s2)
        {
            bool ok = false;
            TaskStatus s = TaskStatus.RanToCompletion;

            Task t = new Task(() =>
            {
                try
                {
                    File.Copy(s1, s2, true);
                    ok = true;
                }
                catch (Exception ex)
                {
                    ok = false;
                    throw ex;
                }
            });

            t.ContinueWith(prev => { }, TaskContinuationOptions.OnlyOnFaulted);
            t.ContinueWith(prev => { }, TaskContinuationOptions.OnlyOnRanToCompletion);



            t.Start();
            t.Wait();

            return t;

            //return Task.Run(() =>
            //{
            //    File.Copy(s1, s2, true);

            //});
        }
    }
}