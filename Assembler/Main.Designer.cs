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
            this.title = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.codeBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.ForeColor = System.Drawing.SystemColors.Control;
            this.codeBox.Location = new System.Drawing.Point(14, 72);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(254, 643);
            this.codeBox.TabIndex = 0;
            // 
            // Run
            // 
            this.Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Run.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.ForeColor = System.Drawing.SystemColors.Control;
            this.Run.Location = new System.Drawing.Point(275, 73);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(256, 54);
            this.Run.TabIndex = 1;
            this.Run.Text = "Run Code";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.Output.Font = new System.Drawing.Font("Courier New", 12F);
            this.Output.ForeColor = System.Drawing.SystemColors.Control;
            this.Output.Location = new System.Drawing.Point(277, 223);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(256, 492);
            this.Output.TabIndex = 2;
            // 
            // State
            // 
            this.State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.State.Font = new System.Drawing.Font("Courier New", 12F);
            this.State.ForeColor = System.Drawing.SystemColors.Control;
            this.State.Location = new System.Drawing.Point(274, 157);
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Size = new System.Drawing.Size(256, 26);
            this.State.TabIndex = 3;
            // 
            // StateLab
            // 
            this.StateLab.AutoSize = true;
            this.StateLab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLab.ForeColor = System.Drawing.SystemColors.Control;
            this.StateLab.Location = new System.Drawing.Point(271, 130);
            this.StateLab.Name = "StateLab";
            this.StateLab.Size = new System.Drawing.Size(155, 24);
            this.StateLab.TabIndex = 6;
            this.StateLab.Text = "Program State";
            // 
            // OutputLab
            // 
            this.OutputLab.AutoSize = true;
            this.OutputLab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLab.ForeColor = System.Drawing.SystemColors.Control;
            this.OutputLab.Location = new System.Drawing.Point(274, 196);
            this.OutputLab.Name = "OutputLab";
            this.OutputLab.Size = new System.Drawing.Size(82, 24);
            this.OutputLab.TabIndex = 7;
            this.OutputLab.Text = "Output";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(340, 36);
            this.title.TabIndex = 9;
            this.title.Text = "Assembler made in C#";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.top.Controls.Add(this.close);
            this.top.Controls.Add(this.title);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(558, 54);
            this.top.TabIndex = 10;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(504, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(54, 54);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(558, 731);
            this.Controls.Add(this.top);
            this.Controls.Add(this.OutputLab);
            this.Controls.Add(this.StateLab);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.codeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Assembler";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
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
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button close;
    }
}

