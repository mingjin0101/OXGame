namespace OXGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listView6 = new System.Windows.Forms.ListView();
            this.listView7 = new System.Windows.Forms.ListView();
            this.listView8 = new System.Windows.Forms.ListView();
            this.listView9 = new System.Windows.Forms.ListView();
            this.Player = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(112, 99);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(280, 73);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(112, 99);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(168, 73);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(112, 99);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(168, 172);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(112, 99);
            this.listView4.TabIndex = 6;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // listView5
            // 
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(280, 172);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(112, 99);
            this.listView5.TabIndex = 5;
            this.listView5.UseCompatibleStateImageBehavior = false;
            // 
            // listView6
            // 
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(56, 172);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(112, 99);
            this.listView6.TabIndex = 4;
            this.listView6.UseCompatibleStateImageBehavior = false;
            // 
            // listView7
            // 
            this.listView7.HideSelection = false;
            this.listView7.Location = new System.Drawing.Point(168, 271);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(112, 99);
            this.listView7.TabIndex = 9;
            this.listView7.UseCompatibleStateImageBehavior = false;
            // 
            // listView8
            // 
            this.listView8.HideSelection = false;
            this.listView8.Location = new System.Drawing.Point(280, 271);
            this.listView8.Name = "listView8";
            this.listView8.Size = new System.Drawing.Size(112, 99);
            this.listView8.TabIndex = 8;
            this.listView8.UseCompatibleStateImageBehavior = false;
            // 
            // listView9
            // 
            this.listView9.HideSelection = false;
            this.listView9.Location = new System.Drawing.Point(56, 271);
            this.listView9.Name = "listView9";
            this.listView9.Size = new System.Drawing.Size(112, 99);
            this.listView9.TabIndex = 7;
            this.listView9.UseCompatibleStateImageBehavior = false;
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Location = new System.Drawing.Point(417, 86);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(46, 16);
            this.Player.TabIndex = 10;
            this.Player.Text = "Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.listView7);
            this.Controls.Add(this.listView8);
            this.Controls.Add(this.listView9);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ListView listView7;
        private System.Windows.Forms.ListView listView8;
        private System.Windows.Forms.ListView listView9;
        private System.Windows.Forms.Label Player;
    }
}