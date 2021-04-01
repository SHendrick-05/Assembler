namespace Assembler
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeBox = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.TextBox();
            this.StateLab = new System.Windows.Forms.Label();
            this.OutputLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(12, 12);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(254, 643);
            this.codeBox.TabIndex = 0;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(273, 13);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(256, 54);
            this.Run.TabIndex = 1;
            this.Run.Text = "Run Code";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Courier New", 12F);
            this.Output.Location = new System.Drawing.Point(275, 131);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(256, 524);
            this.Output.TabIndex = 2;
            // 
            // State
            // 
            this.State.Font = new System.Drawing.Font("Courier New", 12F);
            this.State.Location = new System.Drawing.Point(273, 86);
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Size = new System.Drawing.Size(256, 26);
            this.State.TabIndex = 3;
            // 
            // StateLab
            // 
            this.StateLab.AutoSize = true;
            this.StateLab.Location = new System.Drawing.Point(269, 70);
            this.StateLab.Name = "StateLab";
            this.StateLab.Size = new System.Drawing.Size(74, 13);
            this.StateLab.TabIndex = 6;
            this.StateLab.Text = "Program State";
            // 
            // OutputLab
            // 
            this.OutputLab.AutoSize = true;
            this.OutputLab.Location = new System.Drawing.Point(272, 115);
            this.OutputLab.Name = "OutputLab";
            this.OutputLab.Size = new System.Drawing.Size(39, 13);
            this.OutputLab.TabIndex = 7;
            this.OutputLab.Text = "Output";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 667);
            this.Controls.Add(this.OutputLab);
            this.Controls.Add(this.StateLab);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.codeBox);
            this.Name = "Main";
            this.Text = "Assembler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.Label StateLab;
        private System.Windows.Forms.Label OutputLab;
    }
}

