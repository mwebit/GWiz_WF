namespace GWiz
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.homeBt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.zeroXYZBt = new System.Windows.Forms.Button();
            this.return0Bt = new System.Windows.Forms.Button();
            this.moveXBt = new System.Windows.Forms.Button();
            this.moveYBt = new System.Windows.Forms.Button();
            this.posYBt = new System.Windows.Forms.Button();
            this.negYBt = new System.Windows.Forms.Button();
            this.negXBt = new System.Windows.Forms.Button();
            this.posXBt = new System.Windows.Forms.Button();
            this.negZBt = new System.Windows.Forms.Button();
            this.posZBt = new System.Windows.Forms.Button();
            this.resetBt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.resetBt);
            this.tabPage1.Controls.Add(this.posZBt);
            this.tabPage1.Controls.Add(this.negZBt);
            this.tabPage1.Controls.Add(this.posXBt);
            this.tabPage1.Controls.Add(this.negXBt);
            this.tabPage1.Controls.Add(this.negYBt);
            this.tabPage1.Controls.Add(this.posYBt);
            this.tabPage1.Controls.Add(this.moveYBt);
            this.tabPage1.Controls.Add(this.moveXBt);
            this.tabPage1.Controls.Add(this.return0Bt);
            this.tabPage1.Controls.Add(this.zeroXYZBt);
            this.tabPage1.Controls.Add(this.homeBt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // homeBt
            // 
            this.homeBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBt.Location = new System.Drawing.Point(657, 43);
            this.homeBt.Name = "homeBt";
            this.homeBt.Size = new System.Drawing.Size(97, 43);
            this.homeBt.TabIndex = 0;
            this.homeBt.Text = "Home";
            this.homeBt.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(782, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GRBL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(43, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 267);
            this.treeView1.TabIndex = 0;
            // 
            // zeroXYZBt
            // 
            this.zeroXYZBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroXYZBt.Location = new System.Drawing.Point(624, 126);
            this.zeroXYZBt.Name = "zeroXYZBt";
            this.zeroXYZBt.Size = new System.Drawing.Size(130, 43);
            this.zeroXYZBt.TabIndex = 1;
            this.zeroXYZBt.Text = "Zero X,Y,Z";
            this.zeroXYZBt.UseVisualStyleBackColor = true;
            // 
            // return0Bt
            // 
            this.return0Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return0Bt.Location = new System.Drawing.Point(579, 199);
            this.return0Bt.Name = "return0Bt";
            this.return0Bt.Size = new System.Drawing.Size(175, 43);
            this.return0Bt.TabIndex = 2;
            this.return0Bt.Text = "Return To X,Y,Z 0";
            this.return0Bt.UseVisualStyleBackColor = true;
            // 
            // moveXBt
            // 
            this.moveXBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveXBt.Location = new System.Drawing.Point(25, 292);
            this.moveXBt.Name = "moveXBt";
            this.moveXBt.Size = new System.Drawing.Size(130, 43);
            this.moveXBt.TabIndex = 3;
            this.moveXBt.Text = "Move X by";
            this.moveXBt.UseVisualStyleBackColor = true;
            // 
            // moveYBt
            // 
            this.moveYBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveYBt.Location = new System.Drawing.Point(318, 292);
            this.moveYBt.Name = "moveYBt";
            this.moveYBt.Size = new System.Drawing.Size(130, 43);
            this.moveYBt.TabIndex = 4;
            this.moveYBt.Text = "Move Y by";
            this.moveYBt.UseVisualStyleBackColor = true;
            // 
            // posYBt
            // 
            this.posYBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posYBt.Location = new System.Drawing.Point(94, 199);
            this.posYBt.Name = "posYBt";
            this.posYBt.Size = new System.Drawing.Size(47, 43);
            this.posYBt.TabIndex = 5;
            this.posYBt.Text = "+Y";
            this.posYBt.UseVisualStyleBackColor = true;
            // 
            // negYBt
            // 
            this.negYBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negYBt.Location = new System.Drawing.Point(94, 54);
            this.negYBt.Name = "negYBt";
            this.negYBt.Size = new System.Drawing.Size(48, 43);
            this.negYBt.TabIndex = 6;
            this.negYBt.Text = "-Y";
            this.negYBt.UseVisualStyleBackColor = true;
            // 
            // negXBt
            // 
            this.negXBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negXBt.Location = new System.Drawing.Point(25, 126);
            this.negXBt.Name = "negXBt";
            this.negXBt.Size = new System.Drawing.Size(47, 43);
            this.negXBt.TabIndex = 7;
            this.negXBt.Text = "-X";
            this.negXBt.UseVisualStyleBackColor = true;
            // 
            // posXBt
            // 
            this.posXBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posXBt.Location = new System.Drawing.Point(157, 126);
            this.posXBt.Name = "posXBt";
            this.posXBt.Size = new System.Drawing.Size(49, 43);
            this.posXBt.TabIndex = 8;
            this.posXBt.Text = "+X";
            this.posXBt.UseVisualStyleBackColor = true;
            // 
            // negZBt
            // 
            this.negZBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negZBt.Location = new System.Drawing.Point(251, 199);
            this.negZBt.Name = "negZBt";
            this.negZBt.Size = new System.Drawing.Size(50, 43);
            this.negZBt.TabIndex = 9;
            this.negZBt.Text = "-Z";
            this.negZBt.UseVisualStyleBackColor = true;
            // 
            // posZBt
            // 
            this.posZBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posZBt.Location = new System.Drawing.Point(253, 54);
            this.posZBt.Name = "posZBt";
            this.posZBt.Size = new System.Drawing.Size(48, 43);
            this.posZBt.TabIndex = 10;
            this.posZBt.Text = "+Z";
            this.posZBt.UseVisualStyleBackColor = true;
            // 
            // resetBt
            // 
            this.resetBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBt.Location = new System.Drawing.Point(657, 292);
            this.resetBt.Name = "resetBt";
            this.resetBt.Size = new System.Drawing.Size(97, 43);
            this.resetBt.TabIndex = 11;
            this.resetBt.Text = "Reset";
            this.resetBt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 557);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button moveYBt;
        private System.Windows.Forms.Button moveXBt;
        private System.Windows.Forms.Button return0Bt;
        private System.Windows.Forms.Button zeroXYZBt;
        private System.Windows.Forms.Button homeBt;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button posZBt;
        private System.Windows.Forms.Button negZBt;
        private System.Windows.Forms.Button posXBt;
        private System.Windows.Forms.Button negXBt;
        private System.Windows.Forms.Button negYBt;
        private System.Windows.Forms.Button posYBt;
        private System.Windows.Forms.Button resetBt;
        private System.Windows.Forms.TextBox textBox1;
    }
}

