using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            string[] instr = codeBox.Lines;
            List<Instruction> instrList = new List<Instruction>();
            foreach(string inst in instr)
            {
                Instruction DecInstr = CodeAssembler.DecodeInstruction(inst);
                if (DecInstr != null)
                    instrList.Add(DecInstr);
            }
            CodeHandler.InstrList = instrList;
            CodeHandler.Start(this);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
