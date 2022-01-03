using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.Units
{
    public class ArithmeticLogicUnit : ExecutionUnit
    {
        public override void Execute(Instruction instruction, int cycleCalled)
        {
            occupied = true;
            var timeStart = DateTime.Now.Millisecond;
            int changed = 0;
            /*while (DateTime.Now.Millisecond - timeStart < 200)
                if (Program.cycles - cycleCalled > 0)
                {
                    changed = 1;
                    break;
                }
            if(changed==0)*/
                Program.cycles++;
            occupied = false;
        }
    }
}
