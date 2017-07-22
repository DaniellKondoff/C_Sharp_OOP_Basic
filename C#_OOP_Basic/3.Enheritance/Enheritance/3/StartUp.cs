using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var studentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            try
            {
                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                Worker worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));
                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
