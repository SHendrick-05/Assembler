using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembler
{
    public static class CodeHandler
    {
        public static Main usedForm;
        public static Control stateBox
        {
            get
            {
                return usedForm.Controls.Find("State", true)[0];
            }
        }
        public static TextBox Output
        {
            get
            {
                return (TextBox)usedForm.Controls.Find("Output", true)[0];
            }
        }
        public static int[] Memory = new int[1000];
        public static Dictionary<string, int> Labels = new Dictionary<string, int>();
        public static List<Instruction> InstrList = new List<Instruction>();
        public static int ACC = 0;
        public static int IAR = 0;
        public static bool HLT = false;

        public static void Start(Main form)
        {
            usedForm = form;
            Output.Clear();
            // Labelling
            foreach (Instruction instr in InstrList.Where(x => x.Opcode == 10))
            {
                if (!Labels.ContainsKey(instr.Label))
                    Labels.Add(instr.Label, InstrList.IndexOf(instr));
                else if (Labels[instr.Label] != InstrList.IndexOf(instr))
                    throw new Exception();
            }

            // Run instructions
            while (!HLT)
            {
                RunInstruction();
            }
            stateBox.Text = "EXECUTION FINISHED: PROGRAM HALTED";

            //Return program to previous state
            ACC = 0;
            IAR = 0;
            HLT = false;
            Labels.Clear();
            for (int i = 0; i < 100; i++)
            {
                Memory[i] = 0;
            }
        }

        public static void RunInstruction()
        {
            if (IAR >= InstrList.Count)
            {
                HLT = true;
                return;
            }
            Instruction instr = InstrList[IAR];
            switch (instr.Opcode)
            {
                case 0: // INP
                    ACC = TakeInput();
                    break;
                case 1: // MOV
                    int val = GetValue(instr.Operands[0]);
                    string loc = instr.Operands[1];
                    if (loc == "ACC") ACC = val;
                    else
                    {
                        if (loc[0] == '%') loc = string.Join("", loc.Skip(1));
                        int locI = int.Parse(loc);
                        Memory[locI] = val;
                    }
                    break;

                case 2: // OUT
                    TextBox output = (TextBox)usedForm.Controls.Find("Output", true)[0];
                    List<string> lines = output.Lines.ToList();
                    lines.Add(GetValue(instr.Operands[0]).ToString());
                    output.Lines = lines.ToArray();
                    break;

                case 3: // ADD
                    ACC += GetValue(instr.Operands[0]);
                    break;

                case 4: // SUB
                    ACC -= GetValue(instr.Operands[0]);
                    break;

                case 5: // BRA
                    if (Labels.ContainsKey(instr.Label))
                        IAR = Labels[instr.Label];
                    else throw new Exception();
                    break;

                case 6: // BEZ
                    if (ACC == 0)
                        if (Labels.ContainsKey(instr.Label))
                            IAR = Labels[instr.Label];
                        else throw new Exception();
                    break;

                case 7: // BGZ
                    if (ACC > 0)
                        if (Labels.ContainsKey(instr.Label))
                            IAR = Labels[instr.Label];
                        else throw new Exception();
                    break;

                case 8: // BLZ
                    if (ACC < 0)
                        if (Labels.ContainsKey(instr.Label))
                            IAR = Labels[instr.Label];
                        else throw new Exception();
                    break;

                case 9: // HLT
                    HLT = true;
                    break;

                default: // ???
                    break;
            }
            IAR++;
        }

        public static int TakeInput()
        {
            stateBox.Text = "AWAITING USER INPUT..";
            return int.Parse( Prompt.ShowDialog("Please enter a numerical value.", "Input") );
        }

        public static int GetValue(string operand)
        {
            if (operand == "ACC") return ACC;
            if (operand[0] == '%')
            {
                string addressS = string.Join("", operand.Skip(1));
                int address = int.Parse(addressS);
                return (Memory[address]);
            }
            else return int.Parse(operand);
        }
    }
}
