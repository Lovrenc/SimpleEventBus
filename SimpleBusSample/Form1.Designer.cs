namespace SimpleBusTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddTestClass = new System.Windows.Forms.Button();
            this.btnRemoveTestClasses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoTestClasses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fire Click Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddTestClass
            // 
            this.btnAddTestClass.Location = new System.Drawing.Point(12, 194);
            this.btnAddTestClass.Name = "btnAddTestClass";
            this.btnAddTestClass.Size = new System.Drawing.Size(129, 23);
            this.btnAddTestClass.TabIndex = 2;
            this.btnAddTestClass.Text = "Add TestClass";
            this.btnAddTestClass.UseVisualStyleBackColor = true;
            this.btnAddTestClass.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemoveTestClasses
            // 
            this.btnRemoveTestClasses.Location = new System.Drawing.Point(147, 194);
            this.btnRemoveTestClasses.Name = "btnRemoveTestClasses";
            this.btnRemoveTestClasses.Size = new System.Drawing.Size(129, 23);
            this.btnRemoveTestClasses.TabIndex = 3;
            this.btnRemoveTestClasses.Text = "Remove All TestClasses";
            this.btnRemoveTestClasses.UseVisualStyleBackColor = true;
            this.btnRemoveTestClasses.Click += new System.EventHandler(this.btnRemoveTestClasses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type to fire Text Changed Event. (TestClass subscribes to it).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of test classes: ";
            // 
            // lblNoTestClasses
            // 
            this.lblNoTestClasses.AutoSize = true;
            this.lblNoTestClasses.Location = new System.Drawing.Point(129, 224);
            this.lblNoTestClasses.Name = "lblNoTestClasses";
            this.lblNoTestClasses.Size = new System.Drawing.Size(13, 13);
            this.lblNoTestClasses.TabIndex = 6;
            this.lblNoTestClasses.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 299);
            this.Controls.Add(this.lblNoTestClasses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveTestClasses);
            this.Controls.Add(this.btnAddTestClass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddTestClass;
        private System.Windows.Forms.Button btnRemoveTestClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoTestClasses;
    }
}

