
namespace ByValByRef
{
    partial class FrmByValByRef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmByValByRef));
            this.txtAIn = new System.Windows.Forms.TextBox();
            this.txtBIn = new System.Windows.Forms.TextBox();
            this.txtAOut = new System.Windows.Forms.TextBox();
            this.txtBOut = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblAInput = new System.Windows.Forms.Label();
            this.lblBInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBInMethod = new System.Windows.Forms.TextBox();
            this.txtAinMethod = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAIn
            // 
            this.txtAIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAIn.Location = new System.Drawing.Point(335, 39);
            this.txtAIn.Name = "txtAIn";
            this.txtAIn.Size = new System.Drawing.Size(340, 45);
            this.txtAIn.TabIndex = 1;
            // 
            // txtBIn
            // 
            this.txtBIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIn.Location = new System.Drawing.Point(1029, 39);
            this.txtBIn.Name = "txtBIn";
            this.txtBIn.Size = new System.Drawing.Size(340, 45);
            this.txtBIn.TabIndex = 3;
            // 
            // txtAOut
            // 
            this.txtAOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAOut.Location = new System.Drawing.Point(335, 369);
            this.txtAOut.Name = "txtAOut";
            this.txtAOut.ReadOnly = true;
            this.txtAOut.Size = new System.Drawing.Size(340, 45);
            this.txtAOut.TabIndex = 11;
            // 
            // txtBOut
            // 
            this.txtBOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBOut.Location = new System.Drawing.Point(1029, 369);
            this.txtBOut.Name = "txtBOut";
            this.txtBOut.ReadOnly = true;
            this.txtBOut.Size = new System.Drawing.Size(340, 45);
            this.txtBOut.TabIndex = 13;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(19, 151);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(126, 55);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // lblAInput
            // 
            this.lblAInput.AutoSize = true;
            this.lblAInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAInput.Location = new System.Drawing.Point(12, 42);
            this.lblAInput.Name = "lblAInput";
            this.lblAInput.Size = new System.Drawing.Size(284, 39);
            this.lblAInput.TabIndex = 0;
            this.lblAInput.Text = "A (Passed ByVal)";
            // 
            // lblBInput
            // 
            this.lblBInput.AutoSize = true;
            this.lblBInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBInput.Location = new System.Drawing.Point(706, 42);
            this.lblBInput.Name = "lblBInput";
            this.lblBInput.Size = new System.Drawing.Size(287, 39);
            this.lblBInput.TabIndex = 2;
            this.lblBInput.Text = "B (Passed ByRef)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "A (Passed ByVal)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "B (Passed ByRef)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(706, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "B (Value in Method)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "A (Value in Method)";
            // 
            // txtBInMethod
            // 
            this.txtBInMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBInMethod.Location = new System.Drawing.Point(1029, 278);
            this.txtBInMethod.Name = "txtBInMethod";
            this.txtBInMethod.ReadOnly = true;
            this.txtBInMethod.Size = new System.Drawing.Size(340, 45);
            this.txtBInMethod.TabIndex = 9;
            // 
            // txtAinMethod
            // 
            this.txtAinMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAinMethod.Location = new System.Drawing.Point(335, 278);
            this.txtAinMethod.Name = "txtAinMethod";
            this.txtAinMethod.ReadOnly = true;
            this.txtAinMethod.Size = new System.Drawing.Size(340, 45);
            this.txtAinMethod.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1243, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 55);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(630, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 55);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmByValByRef
            // 
            this.AcceptButton = this.btnTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1514, 541);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBInMethod);
            this.Controls.Add(this.txtAinMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBInput);
            this.Controls.Add(this.lblAInput);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtBOut);
            this.Controls.Add(this.txtAOut);
            this.Controls.Add(this.txtBIn);
            this.Controls.Add(this.txtAIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmByValByRef";
            this.Text = "By Value vs By Reference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAIn;
        private System.Windows.Forms.TextBox txtBIn;
        private System.Windows.Forms.TextBox txtAOut;
        private System.Windows.Forms.TextBox txtBOut;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblAInput;
        private System.Windows.Forms.Label lblBInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBInMethod;
        private System.Windows.Forms.TextBox txtAinMethod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

