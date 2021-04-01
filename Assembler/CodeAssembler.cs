using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    public class Instruction
    {
        public short Opcode;
        public string[] Operands;
        public string Label = "";
    }
    static class CodeAssembler
    {
        public static Dictionary<string, short> Opcodes = new Dictionary<string, short>()
        {
            { "INP", 0 }, // Take user input, 0 operands
            { "MOV", 1 }, // Move value from A to B, 2 operands
            { "OUT", 2 }, // Output value of address to the console, 1 operand
            { "ADD", 3 }, // Add value to ACC, 1 operand
            { "SUB", 4 }, // Subtract value from ACC, 1 operand
            { "BRA", 5 }, // Branch to label, 1 operand
            { "BEZ", 6 }, // Branch if ACC is equal to 0, 1 operand
            { "BGZ", 7 }, // Branch if ACC is greater than 0, 1 operand
            { "BLZ", 8 }  // Branch if ACC is less than 0, 1 operand.
            // 10 = Label
        };

        public static Instruction DecodeInstruction(string input) // Convert the opcode mnemonics, parse instruction.
        {
            // Sanitise string
            if (string.IsNullOrWhiteSpace(input)) 
                return null;
            Instruction result = new Instruction(); // Init a new instruction class
            string[] splitInput = input.Split(' ');
            splitInput = splitInput.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            // Get the opcode of the instruction
            string opc = splitInput[0].ToUpper();
            if (Opcodes.ContainsKey(opc))
                result.Opcode = Opcodes[opc];
            else
            {
                result.Opcode = 10;
                result.Label = opc;
            }

            // Get appropiate labels if it is a branch instruction
            if (result.Opcode >= 5 && result.Opcode <= 8)
            {
                result.Label = splitInput[1];
            }
            

            // Get the operand(s) of the instruction, if any.
            else if (splitInput.Length != 1)
            {
                string[] opds = splitInput.Skip(1).ToArray();
                List<string> opdsList = new List<string>();
                foreach (string s in opds)
                {
                    opdsList.Add(s.ToUpper());
                }
                // Check if operands are memory references
                result.Operands = opdsList.ToArray();
            }

            // Return the completed instruction
            return result;
        }
    }
}
