namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.holiciLB = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.jmenoT = new System.Windows.Forms.TextBox();
            this.prijmeniT = new System.Windows.Forms.TextBox();
            this.zakazniciLB = new System.Windows.Forms.ListBox();
            this.jeHolic = new System.Windows.Forms.CheckBox();
            this.vypisTB = new System.Windows.Forms.TextBox();
            this.vycistiB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // holiciLB
            // 
            this.holiciLB.FormattingEnabled = true;
            this.holiciLB.Location = new System.Drawing.Point(12, 68);
            this.holiciLB.Name = "holiciLB";
            this.holiciLB.Size = new System.Drawing.Size(65, 173);
            this.holiciLB.TabIndex = 0;
            this.holiciLB.SelectedIndexChanged += new System.EventHandler(this.holiciLB_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "pridej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jmenoT
            // 
            this.jmenoT.Location = new System.Drawing.Point(161, 27);
            this.jmenoT.Name = "jmenoT";
            this.jmenoT.Size = new System.Drawing.Size(100, 20);
            this.jmenoT.TabIndex = 2;
            // 
            // prijmeniT
            // 
            this.prijmeniT.Location = new System.Drawing.Point(161, 68);
            this.prijmeniT.Name = "prijmeniT";
            this.prijmeniT.Size = new System.Drawing.Size(100, 20);
            this.prijmeniT.TabIndex = 3;
            // 
            // zakazniciLB
            // 
            this.zakazniciLB.FormattingEnabled = true;
            this.zakazniciLB.Location = new System.Drawing.Point(83, 68);
            this.zakazniciLB.Name = "zakazniciLB";
            this.zakazniciLB.Size = new System.Drawing.Size(72, 173);
            this.zakazniciLB.TabIndex = 7;
            // 
            // jeHolic
            // 
            this.jeHolic.AutoSize = true;
            this.jeHolic.Location = new System.Drawing.Point(180, 124);
            this.jeHolic.Name = "jeHolic";
            this.jeHolic.Size = new System.Drawing.Size(48, 17);
            this.jeHolic.TabIndex = 8;
            this.jeHolic.Text = "holic";
            this.jeHolic.UseVisualStyleBackColor = true;
            this.jeHolic.Click += new System.EventHandler(this.jeHolic_Click);
            // 
            // vypisTB
            // 
            this.vypisTB.Location = new System.Drawing.Point(172, 169);
            this.vypisTB.Multiline = true;
            this.vypisTB.Name = "vypisTB";
            this.vypisTB.Size = new System.Drawing.Size(100, 72);
            this.vypisTB.TabIndex = 9;
            // 
            // vycistiB
            // 
            this.vycistiB.Location = new System.Drawing.Point(13, 42);
            this.vycistiB.Name = "vycistiB";
            this.vycistiB.Size = new System.Drawing.Size(75, 23);
            this.vycistiB.TabIndex = 10;
            this.vycistiB.Text = "vycisti";
            this.vycistiB.UseVisualStyleBackColor = true;
            this.vycistiB.Click += new System.EventHandler(this.vycistiB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jmeno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prijmeni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vycistiB);
            this.Controls.Add(this.vypisTB);
            this.Controls.Add(this.jeHolic);
            this.Controls.Add(this.zakazniciLB);
            this.Controls.Add(this.prijmeniT);
            this.Controls.Add(this.jmenoT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.holiciLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox holiciLB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox jmenoT;
        private System.Windows.Forms.TextBox prijmeniT;
        private System.Windows.Forms.ListBox zakazniciLB;
        private System.Windows.Forms.CheckBox jeHolic;
        private System.Windows.Forms.TextBox vypisTB;
        private System.Windows.Forms.Button vycistiB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

