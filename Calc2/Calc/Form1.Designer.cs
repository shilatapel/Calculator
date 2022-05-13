
namespace Calc2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseBrack = new System.Windows.Forms.Button();
            this.btnOpenBrack = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCloseBrack);
            this.panel1.Controls.Add(this.btnOpenBrack);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.btnEqu);
            this.panel1.Controls.Add(this.btnSub);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btnMult);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btnDiv);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnCE);
            this.panel1.Controls.Add(this.txtScreen);
            this.panel1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 433);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseBrack
            // 
            this.btnCloseBrack.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseBrack.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCloseBrack.Location = new System.Drawing.Point(162, 356);
            this.btnCloseBrack.Name = "btnCloseBrack";
            this.btnCloseBrack.Size = new System.Drawing.Size(60, 57);
            this.btnCloseBrack.TabIndex = 5;
            this.btnCloseBrack.Text = ")";
            this.btnCloseBrack.UseVisualStyleBackColor = true;
            this.btnCloseBrack.Click += new System.EventHandler(this.btnOperClick);
            // 
            // btnOpenBrack
            // 
            this.btnOpenBrack.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBrack.ForeColor = System.Drawing.Color.Firebrick;
            this.btnOpenBrack.Location = new System.Drawing.Point(17, 356);
            this.btnOpenBrack.Name = "btnOpenBrack";
            this.btnOpenBrack.Size = new System.Drawing.Size(60, 57);
            this.btnOpenBrack.TabIndex = 4;
            this.btnOpenBrack.Text = "(";
            this.btnOpenBrack.UseVisualStyleBackColor = true;
            this.btnOpenBrack.Click += new System.EventHandler(this.btnOperClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(10, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 24);
            this.lbl1.TabIndex = 3;
            // 
            // btnEqu
            // 
            this.btnEqu.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqu.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEqu.Location = new System.Drawing.Point(234, 357);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(60, 57);
            this.btnEqu.TabIndex = 2;
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = true;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSub.Location = new System.Drawing.Point(234, 231);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(60, 57);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOperClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAdd.Location = new System.Drawing.Point(234, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 57);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperClick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Maroon;
            this.btn6.Location = new System.Drawing.Point(162, 231);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 57);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnClick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Maroon;
            this.btn3.Location = new System.Drawing.Point(162, 294);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 57);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.Firebrick;
            this.btnMult.Location = new System.Drawing.Point(234, 168);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(60, 57);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnOperClick);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Maroon;
            this.btn0.Location = new System.Drawing.Point(90, 357);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 57);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnClick);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Maroon;
            this.btn9.Location = new System.Drawing.Point(162, 168);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 57);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Maroon;
            this.btn5.Location = new System.Drawing.Point(90, 231);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 57);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Maroon;
            this.btn2.Location = new System.Drawing.Point(90, 294);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 57);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnCancel.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Location = new System.Drawing.Point(162, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 57);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Maroon;
            this.btn8.Location = new System.Drawing.Point(90, 168);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 57);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnClick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Maroon;
            this.btn4.Location = new System.Drawing.Point(17, 231);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 57);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnClick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Maroon;
            this.btn1.Location = new System.Drawing.Point(17, 294);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 57);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnClick);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDiv.Location = new System.Drawing.Point(234, 105);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(60, 57);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperClick);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Maroon;
            this.btn7.Location = new System.Drawing.Point(17, 168);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 57);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnClick);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Firebrick;
            this.btnC.Location = new System.Drawing.Point(90, 105);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 57);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCE.Location = new System.Drawing.Point(17, 105);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(60, 57);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // txtScreen
            // 
            this.txtScreen.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreen.Location = new System.Drawing.Point(7, 49);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(298, 47);
            this.txtScreen.TabIndex = 0;
            this.txtScreen.Text = "0";
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 441);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEqu;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCloseBrack;
        private System.Windows.Forms.Button btnOpenBrack;
    }
}

