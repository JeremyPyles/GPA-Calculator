namespace GPA_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnAddAnother = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteComboBox = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Location = new System.Drawing.Point(304, 742);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 46);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(635, 83);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(59, 20);
            this.lblCredits.TabIndex = 3;
            this.lblCredits.Text = "Credits";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(226, 83);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(94, 20);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Class Name";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(747, 83);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(100, 20);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Letter Grade";
            // 
            // btnAddAnother
            // 
            this.btnAddAnother.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAnother.Location = new System.Drawing.Point(487, 742);
            this.btnAddAnother.Name = "btnAddAnother";
            this.btnAddAnother.Size = new System.Drawing.Size(166, 46);
            this.btnAddAnother.TabIndex = 10;
            this.btnAddAnother.TabStop = false;
            this.btnAddAnother.Text = "Add Another Class";
            this.btnAddAnother.UseVisualStyleBackColor = true;
            this.btnAddAnother.Click += new System.EventHandler(this.btnAddAnother_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(565, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 543);
            this.panel1.TabIndex = 11;
            // 
            // btnDeleteComboBox
            // 
            this.btnDeleteComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteComboBox.Location = new System.Drawing.Point(682, 742);
            this.btnDeleteComboBox.Name = "btnDeleteComboBox";
            this.btnDeleteComboBox.Size = new System.Drawing.Size(153, 46);
            this.btnDeleteComboBox.TabIndex = 12;
            this.btnDeleteComboBox.Text = "Delete Course";
            this.btnDeleteComboBox.UseVisualStyleBackColor = true;
            this.btnDeleteComboBox.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(120, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 543);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1141, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDeleteComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddAnother);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.btnCalculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GPA Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnAddAnother;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteComboBox;
        private System.Windows.Forms.Panel panel2;
    }
}

