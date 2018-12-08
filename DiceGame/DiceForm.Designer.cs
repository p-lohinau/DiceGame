namespace DiceGame
{
    partial class DiceGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceGame));
            this.Start_btn = new System.Windows.Forms.Button();
            this.Dice1 = new System.Windows.Forms.Label();
            this.Dice2 = new System.Windows.Forms.Label();
            this.Dice3 = new System.Windows.Forms.Label();
            this.Dice4 = new System.Windows.Forms.Label();
            this.Dice5 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            resources.ApplyResources(this.Start_btn, "Start_btn");
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Dice1
            // 
            resources.ApplyResources(this.Dice1, "Dice1");
            this.Dice1.BackColor = System.Drawing.Color.Lime;
            this.Dice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dice1.Name = "Dice1";
            // 
            // Dice2
            // 
            resources.ApplyResources(this.Dice2, "Dice2");
            this.Dice2.BackColor = System.Drawing.Color.Lime;
            this.Dice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dice2.Name = "Dice2";
            // 
            // Dice3
            // 
            resources.ApplyResources(this.Dice3, "Dice3");
            this.Dice3.BackColor = System.Drawing.Color.Lime;
            this.Dice3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dice3.Name = "Dice3";
            // 
            // Dice4
            // 
            resources.ApplyResources(this.Dice4, "Dice4");
            this.Dice4.BackColor = System.Drawing.Color.Lime;
            this.Dice4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dice4.Name = "Dice4";
            // 
            // Dice5
            // 
            resources.ApplyResources(this.Dice5, "Dice5");
            this.Dice5.BackColor = System.Drawing.Color.Lime;
            this.Dice5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dice5.Name = "Dice5";
            // 
            // ResultTextBox
            // 
            resources.ApplyResources(this.ResultTextBox, "ResultTextBox");
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // DiceGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiceGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Label Dice1;
        private System.Windows.Forms.Label Dice2;
        private System.Windows.Forms.Label Dice3;
        private System.Windows.Forms.Label Dice4;
        private System.Windows.Forms.Label Dice5;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

