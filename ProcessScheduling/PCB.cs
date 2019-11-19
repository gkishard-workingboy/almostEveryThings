using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduling
{
    public enum Status{
        E = 0 ,
        R = 1
    }
    public class PCB
    {
        public string Pname { get; set; }
        public int pointer { get; set; }
        public int timeNeeded { get; set; }
        public int priority { get; set; }
        public Status status;
        static Random r = new Random((int)DateTime.Now.Ticks);


        public PCB(){
            this.priority = r.Next(0,11);
            this.timeNeeded = r.Next(1, 11);
            this.status = Status.R;
        }

        public PCB(string name)
        {
            this.Pname = name;
            this.priority = r.Next(0, 11);
            this.timeNeeded = r.Next(1, 11);
            this.status = Status.R;
        }




    }
}
