namespace Calculator_
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnChangeWidth = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWhiteOrDark = new Calculator_.RJToggleButton();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.txtDisplayBack = new System.Windows.Forms.TextBox();
            this.txtDisplayNumber = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnProcent = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxTextHistory = new System.Windows.Forms.RichTextBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnSinH = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnInX = new System.Windows.Forms.Button();
            this.btnSIn = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.pnlTitle.Controls.Add(this.btnChangeWidth);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.btnWhiteOrDark);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(620, 34);
            this.pnlTitle.TabIndex = 1;
            // 
            // btnChangeWidth
            // 
            this.btnChangeWidth.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangeWidth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangeWidth.FlatAppearance.BorderSize = 0;
            this.btnChangeWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeWidth.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeWidth.Image")));
            this.btnChangeWidth.Location = new System.Drawing.Point(563, 0);
            this.btnChangeWidth.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeWidth.Name = "btnChangeWidth";
            this.btnChangeWidth.Size = new System.Drawing.Size(33, 34);
            this.btnChangeWidth.TabIndex = 1;
            this.btnChangeWidth.UseVisualStyleBackColor = true;
            this.btnChangeWidth.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(596, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWhiteOrDark
            // 
            this.btnWhiteOrDark.Location = new System.Drawing.Point(4, 4);
            this.btnWhiteOrDark.Margin = new System.Windows.Forms.Padding(4);
            this.btnWhiteOrDark.MinimumSize = new System.Drawing.Size(40, 20);
            this.btnWhiteOrDark.Name = "btnWhiteOrDark";
            this.btnWhiteOrDark.Size = new System.Drawing.Size(50, 25);
            this.btnWhiteOrDark.TabIndex = 0;
            this.btnWhiteOrDark.Text = "rjToggleButton1";
            this.btnWhiteOrDark.UseVisualStyleBackColor = true;
            this.btnWhiteOrDark.CheckedChanged += new System.EventHandler(this.rJButtonDarkWhite_CheckedChanged);
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.panelHistory.Controls.Add(this.btnHistory);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHistory.Location = new System.Drawing.Point(0, 34);
            this.panelHistory.Margin = new System.Windows.Forms.Padding(0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(620, 34);
            this.panelHistory.TabIndex = 3;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(587, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(33, 34);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // txtDisplayBack
            // 
            this.txtDisplayBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.txtDisplayBack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplayBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplayBack.Font = new System.Drawing.Font("Cambria", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtDisplayBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtDisplayBack.Location = new System.Drawing.Point(0, 68);
            this.txtDisplayBack.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplayBack.Multiline = true;
            this.txtDisplayBack.Name = "txtDisplayBack";
            this.txtDisplayBack.ReadOnly = true;
            this.txtDisplayBack.Size = new System.Drawing.Size(620, 21);
            this.txtDisplayBack.TabIndex = 4;
            this.txtDisplayBack.Text = "0";
            this.txtDisplayBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisplayNumber
            // 
            this.txtDisplayNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.txtDisplayNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplayNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplayNumber.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold);
            this.txtDisplayNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtDisplayNumber.Location = new System.Drawing.Point(0, 89);
            this.txtDisplayNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplayNumber.Multiline = true;
            this.txtDisplayNumber.Name = "txtDisplayNumber";
            this.txtDisplayNumber.ReadOnly = true;
            this.txtDisplayNumber.Size = new System.Drawing.Size(620, 60);
            this.txtDisplayNumber.TabIndex = 5;
            this.txtDisplayNumber.Text = "0";
            this.txtDisplayNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnC
            // 
            this.btnC.FlatAppearance.BorderSize = 2;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.btnC.Location = new System.Drawing.Point(9, 218);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 50);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.FlatAppearance.BorderSize = 2;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.btnDivision.Location = new System.Drawing.Point(88, 218);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(60, 50);
            this.btnDivision.TabIndex = 12;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnMathOperation_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.FlatAppearance.BorderSize = 2;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.btnMultiplication.Location = new System.Drawing.Point(165, 218);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(60, 50);
            this.btnMultiplication.TabIndex = 11;
            this.btnMultiplication.Text = "×";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMathOperation_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(242, 218);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 50);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.BorderSize = 3;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn7.Location = new System.Drawing.Point(9, 277);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 50);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.BorderSize = 3;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn8.Location = new System.Drawing.Point(88, 277);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 50);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn9
            // 
            this.btn9.FlatAppearance.BorderSize = 3;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn9.Location = new System.Drawing.Point(165, 277);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 50);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderSize = 2;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.btnMinus.Location = new System.Drawing.Point(242, 277);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 50);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMathOperation_Click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderSize = 3;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn4.Location = new System.Drawing.Point(9, 337);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 50);
            this.btn4.TabIndex = 21;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderSize = 3;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn5.Location = new System.Drawing.Point(88, 337);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 50);
            this.btn5.TabIndex = 20;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.BorderSize = 3;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn6.Location = new System.Drawing.Point(165, 337);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 50);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatAppearance.BorderSize = 2;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.btnPlus.Location = new System.Drawing.Point(242, 337);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 50);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnMathOperation_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 3;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn1.Location = new System.Drawing.Point(9, 396);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 50);
            this.btn1.TabIndex = 24;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 3;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn2.Location = new System.Drawing.Point(88, 396);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 50);
            this.btn2.TabIndex = 23;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderSize = 3;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn3.Location = new System.Drawing.Point(165, 396);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 50);
            this.btn3.TabIndex = 22;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnProcent
            // 
            this.btnProcent.FlatAppearance.BorderSize = 3;
            this.btnProcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcent.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnProcent.Location = new System.Drawing.Point(9, 460);
            this.btnProcent.Margin = new System.Windows.Forms.Padding(0);
            this.btnProcent.Name = "btnProcent";
            this.btnProcent.Size = new System.Drawing.Size(60, 50);
            this.btnProcent.TabIndex = 27;
            this.btnProcent.Text = "%";
            this.btnProcent.UseVisualStyleBackColor = true;
            this.btnProcent.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.FlatAppearance.BorderSize = 3;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn0.Location = new System.Drawing.Point(88, 460);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 50);
            this.btn0.TabIndex = 26;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnDot
            // 
            this.btnDot.FlatAppearance.BorderSize = 3;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnDot.Location = new System.Drawing.Point(165, 460);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 50);
            this.btnDot.TabIndex = 25;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.btnEqual.Location = new System.Drawing.Point(242, 396);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(0);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(60, 114);
            this.btnEqual.TabIndex = 28;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEdn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.boxTextHistory);
            this.panel1.Controls.Add(this.btnDeleteAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 516);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(620, 0);
            this.panel1.TabIndex = 30;
            // 
            // boxTextHistory
            // 
            this.boxTextHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.boxTextHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxTextHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxTextHistory.Location = new System.Drawing.Point(0, 0);
            this.boxTextHistory.Margin = new System.Windows.Forms.Padding(0);
            this.boxTextHistory.Name = "boxTextHistory";
            this.boxTextHistory.ReadOnly = true;
            this.boxTextHistory.Size = new System.Drawing.Size(620, 0);
            this.boxTextHistory.TabIndex = 1;
            this.boxTextHistory.Text = "";
            this.boxTextHistory.ClientSizeChanged += new System.EventHandler(this.richTextBox1_ClientSizeChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.btnDeleteAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.Location = new System.Drawing.Point(0, -50);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteAll.Size = new System.Drawing.Size(620, 50);
            this.btnDeleteAll.TabIndex = 0;
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.FlatAppearance.BorderSize = 3;
            this.btnCosh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnCosh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnCosh.Location = new System.Drawing.Point(316, 353);
            this.btnCosh.Margin = new System.Windows.Forms.Padding(0);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(60, 73);
            this.btnCosh.TabIndex = 42;
            this.btnCosh.Text = "cosh";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnBin
            // 
            this.btnBin.FlatAppearance.BorderSize = 3;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnBin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnBin.Location = new System.Drawing.Point(472, 337);
            this.btnBin.Margin = new System.Windows.Forms.Padding(0);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(60, 50);
            this.btnBin.TabIndex = 40;
            this.btnBin.Text = "bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btn1x
            // 
            this.btn1x.FlatAppearance.BorderSize = 3;
            this.btn1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1x.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btn1x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn1x.Location = new System.Drawing.Point(549, 337);
            this.btn1x.Margin = new System.Windows.Forms.Padding(0);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(60, 50);
            this.btn1x.TabIndex = 39;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = true;
            this.btn1x.Click += new System.EventHandler(this.btn1x_Click);
            // 
            // btnSinH
            // 
            this.btnSinH.FlatAppearance.BorderSize = 3;
            this.btnSinH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnSinH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnSinH.Location = new System.Drawing.Point(316, 277);
            this.btnSinH.Margin = new System.Windows.Forms.Padding(0);
            this.btnSinH.Name = "btnSinH";
            this.btnSinH.Size = new System.Drawing.Size(60, 70);
            this.btnSinH.TabIndex = 38;
            this.btnSinH.Text = "sinh";
            this.btnSinH.UseVisualStyleBackColor = true;
            this.btnSinH.Click += new System.EventHandler(this.btnSinH_Click);
            // 
            // btnX3
            // 
            this.btnX3.FlatAppearance.BorderSize = 3;
            this.btnX3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnX3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnX3.Location = new System.Drawing.Point(549, 275);
            this.btnX3.Margin = new System.Windows.Forms.Padding(0);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(60, 50);
            this.btnX3.TabIndex = 35;
            this.btnX3.Text = "x3";
            this.btnX3.UseVisualStyleBackColor = true;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // btnPi
            // 
            this.btnPi.FlatAppearance.BorderSize = 3;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnPi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnPi.Location = new System.Drawing.Point(316, 218);
            this.btnPi.Margin = new System.Windows.Forms.Padding(0);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(60, 50);
            this.btnPi.TabIndex = 34;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnLog
            // 
            this.btnLog.FlatAppearance.BorderSize = 3;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnLog.Location = new System.Drawing.Point(395, 218);
            this.btnLog.Margin = new System.Windows.Forms.Padding(0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(60, 50);
            this.btnLog.TabIndex = 33;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.FlatAppearance.BorderSize = 3;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnSqrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnSqrt.Location = new System.Drawing.Point(472, 218);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(0);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(60, 50);
            this.btnSqrt.TabIndex = 32;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnX2
            // 
            this.btnX2.FlatAppearance.BorderSize = 3;
            this.btnX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnX2.Location = new System.Drawing.Point(549, 218);
            this.btnX2.Margin = new System.Windows.Forms.Padding(0);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(60, 50);
            this.btnX2.TabIndex = 31;
            this.btnX2.Text = "x2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btnInX
            // 
            this.btnInX.FlatAppearance.BorderSize = 3;
            this.btnInX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInX.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnInX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnInX.Location = new System.Drawing.Point(549, 396);
            this.btnInX.Margin = new System.Windows.Forms.Padding(0);
            this.btnInX.Name = "btnInX";
            this.btnInX.Size = new System.Drawing.Size(60, 114);
            this.btnInX.TabIndex = 43;
            this.btnInX.Text = "in x";
            this.btnInX.UseVisualStyleBackColor = true;
            this.btnInX.Click += new System.EventHandler(this.btnInX_Click);
            // 
            // btnSIn
            // 
            this.btnSIn.FlatAppearance.BorderSize = 3;
            this.btnSIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSIn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnSIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnSIn.Location = new System.Drawing.Point(395, 277);
            this.btnSIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnSIn.Name = "btnSIn";
            this.btnSIn.Size = new System.Drawing.Size(60, 70);
            this.btnSIn.TabIndex = 48;
            this.btnSIn.Text = "sin";
            this.btnSIn.UseVisualStyleBackColor = true;
            this.btnSIn.Click += new System.EventHandler(this.btnSIn_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.FlatAppearance.BorderSize = 3;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnDecimal.Location = new System.Drawing.Point(472, 277);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(0);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(60, 50);
            this.btnDecimal.TabIndex = 49;
            this.btnDecimal.Text = "dec";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnCos
            // 
            this.btnCos.FlatAppearance.BorderSize = 3;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnCos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnCos.Location = new System.Drawing.Point(395, 353);
            this.btnCos.Margin = new System.Windows.Forms.Padding(0);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(60, 73);
            this.btnCos.TabIndex = 50;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnHex
            // 
            this.btnHex.FlatAppearance.BorderSize = 3;
            this.btnHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHex.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnHex.Location = new System.Drawing.Point(472, 396);
            this.btnHex.Margin = new System.Windows.Forms.Padding(0);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(60, 50);
            this.btnHex.TabIndex = 51;
            this.btnHex.Text = "hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnTan
            // 
            this.btnTan.FlatAppearance.BorderSize = 3;
            this.btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnTan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnTan.Location = new System.Drawing.Point(395, 437);
            this.btnTan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(60, 73);
            this.btnTan.TabIndex = 52;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.FlatAppearance.BorderSize = 3;
            this.btnTanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnTanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnTanh.Location = new System.Drawing.Point(316, 437);
            this.btnTanh.Margin = new System.Windows.Forms.Padding(0);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(60, 73);
            this.btnTanh.TabIndex = 53;
            this.btnTanh.Text = "tanh";
            this.btnTanh.UseVisualStyleBackColor = true;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnOct
            // 
            this.btnOct.FlatAppearance.BorderSize = 3;
            this.btnOct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOct.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnOct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnOct.Location = new System.Drawing.Point(472, 460);
            this.btnOct.Margin = new System.Windows.Forms.Padding(0);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(60, 50);
            this.btnOct.TabIndex = 54;
            this.btnOct.Text = "oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(620, 516);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnSIn);
            this.Controls.Add(this.btnInX);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.btnSinH);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnProcent);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDisplayNumber);
            this.Controls.Add(this.txtDisplayBack);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.pnlTitle);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTitle.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJToggleButton btnWhiteOrDark;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeWidth;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TextBox txtDisplayBack;
        private System.Windows.Forms.TextBox txtDisplayNumber;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnProcent;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.RichTextBox boxTextHistory;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnSinH;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnInX;
        private System.Windows.Forms.Button btnSIn;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnOct;
    }
}

