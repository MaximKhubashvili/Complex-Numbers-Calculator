namespace AppCalculator
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNegativ = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnRev = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDeduct = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSeparator = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMDeduct = new System.Windows.Forms.Button();
            this.btnMAdd = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.txtCalculate = new System.Windows.Forms.TextBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросБуфераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnComplexPlus = new System.Windows.Forms.Button();
            this.btnCompMin = new System.Windows.Forms.Button();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNegativ
            // 
            this.btnNegativ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNegativ.Location = new System.Drawing.Point(277, 250);
            this.btnNegativ.Name = "btnNegativ";
            this.btnNegativ.Size = new System.Drawing.Size(50, 35);
            this.btnNegativ.TabIndex = 74;
            this.btnNegativ.Text = "+/-";
            this.toolTipHelp.SetToolTip(this.btnNegativ, "Изменить знак");
            this.btnNegativ.UseVisualStyleBackColor = false;
            this.btnNegativ.Click += new System.EventHandler(this.btnNegativ_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackSpace.Location = new System.Drawing.Point(221, 86);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(76, 35);
            this.btnBackSpace.TabIndex = 73;
            this.btnBackSpace.Text = "<-";
            this.toolTipHelp.SetToolTip(this.btnBackSpace, "Удалить символ");
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCE.Location = new System.Drawing.Point(303, 86);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(80, 35);
            this.btnCE.TabIndex = 72;
            this.btnCE.Text = "CE";
            this.toolTipHelp.SetToolTip(this.btnCE, "Сброс числа");
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnRev
            // 
            this.btnRev.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRev.Location = new System.Drawing.Point(445, 86);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(50, 35);
            this.btnRev.TabIndex = 70;
            this.btnRev.Text = "1/x";
            this.toolTipHelp.SetToolTip(this.btnRev, "Получить обратное значение");
            this.btnRev.UseVisualStyleBackColor = false;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSqr.Location = new System.Drawing.Point(389, 86);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(50, 35);
            this.btnSqr.TabIndex = 69;
            this.btnSqr.Text = "Sqr";
            this.toolTipHelp.SetToolTip(this.btnSqr, "Возведение в квадрат");
            this.btnSqr.UseVisualStyleBackColor = false;
            this.btnSqr.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(389, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(162, 35);
            this.btnCalculate.TabIndex = 68;
            this.btnCalculate.Tag = "";
            this.btnCalculate.Text = "=";
            this.toolTipHelp.SetToolTip(this.btnCalculate, "Вычислить");
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDeduct
            // 
            this.btnDeduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeduct.Location = new System.Drawing.Point(501, 168);
            this.btnDeduct.Name = "btnDeduct";
            this.btnDeduct.Size = new System.Drawing.Size(50, 35);
            this.btnDeduct.TabIndex = 67;
            this.btnDeduct.Tag = "";
            this.btnDeduct.Text = "-";
            this.toolTipHelp.SetToolTip(this.btnDeduct, "Вычесть");
            this.btnDeduct.UseVisualStyleBackColor = false;
            this.btnDeduct.Click += new System.EventHandler(this.btnDeduct_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(501, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 35);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "+";
            this.toolTipHelp.SetToolTip(this.btnAdd, "Сложить");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMul.Location = new System.Drawing.Point(501, 127);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(50, 35);
            this.btnMul.TabIndex = 65;
            this.btnMul.Tag = "";
            this.btnMul.Text = "*";
            this.toolTipHelp.SetToolTip(this.btnMul, "Умножить");
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDivide.Location = new System.Drawing.Point(501, 86);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 35);
            this.btnDivide.TabIndex = 64;
            this.btnDivide.Tag = "";
            this.btnDivide.Text = "/";
            this.toolTipHelp.SetToolTip(this.btnDivide, "Делить");
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSeparator
            // 
            this.btnSeparator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSeparator.Location = new System.Drawing.Point(333, 250);
            this.btnSeparator.Name = "btnSeparator";
            this.btnSeparator.Size = new System.Drawing.Size(50, 35);
            this.btnSeparator.TabIndex = 63;
            this.btnSeparator.Tag = "";
            this.btnSeparator.Text = ".";
            this.btnSeparator.UseVisualStyleBackColor = false;
            this.btnSeparator.Click += new System.EventHandler(this.btnSeparator_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn0.Location = new System.Drawing.Point(221, 250);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 35);
            this.btn0.TabIndex = 62;
            this.btn0.Tag = "";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn3.Location = new System.Drawing.Point(333, 209);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 35);
            this.btn3.TabIndex = 61;
            this.btn3.Tag = "";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn2.Location = new System.Drawing.Point(277, 209);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 35);
            this.btn2.TabIndex = 60;
            this.btn2.Tag = "";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn1.Location = new System.Drawing.Point(221, 209);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 35);
            this.btn1.TabIndex = 59;
            this.btn1.Tag = "";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn6.Location = new System.Drawing.Point(333, 168);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 35);
            this.btn6.TabIndex = 58;
            this.btn6.Tag = "";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn4.Location = new System.Drawing.Point(221, 168);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 35);
            this.btn4.TabIndex = 57;
            this.btn4.Tag = "";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn5.Location = new System.Drawing.Point(277, 168);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 35);
            this.btn5.TabIndex = 56;
            this.btn5.Tag = "";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn8.Location = new System.Drawing.Point(277, 127);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 35);
            this.btn8.TabIndex = 55;
            this.btn8.Tag = "";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn9.Location = new System.Drawing.Point(333, 127);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 35);
            this.btn9.TabIndex = 54;
            this.btn9.Tag = "";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn7.Location = new System.Drawing.Point(221, 127);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 35);
            this.btn7.TabIndex = 53;
            this.btn7.Tag = "";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // btnMDeduct
            // 
            this.btnMDeduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMDeduct.Enabled = false;
            this.btnMDeduct.Location = new System.Drawing.Point(165, 85);
            this.btnMDeduct.Name = "btnMDeduct";
            this.btnMDeduct.Size = new System.Drawing.Size(50, 35);
            this.btnMDeduct.TabIndex = 52;
            this.btnMDeduct.Text = "M-";
            this.toolTipHelp.SetToolTip(this.btnMDeduct, "Вычесть число из памяти");
            this.btnMDeduct.UseVisualStyleBackColor = false;
            this.btnMDeduct.Click += new System.EventHandler(this.btnMDeduct_Click);
            // 
            // btnMAdd
            // 
            this.btnMAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMAdd.Enabled = false;
            this.btnMAdd.Location = new System.Drawing.Point(165, 250);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(50, 35);
            this.btnMAdd.TabIndex = 51;
            this.btnMAdd.Text = "M+";
            this.toolTipHelp.SetToolTip(this.btnMAdd, "Сложить число из памяти");
            this.btnMAdd.UseVisualStyleBackColor = false;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMS.Location = new System.Drawing.Point(165, 209);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(50, 35);
            this.btnMS.TabIndex = 50;
            this.btnMS.Text = "MS";
            this.toolTipHelp.SetToolTip(this.btnMS, "Сохранить число в память");
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMR.Enabled = false;
            this.btnMR.Location = new System.Drawing.Point(165, 168);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(50, 35);
            this.btnMR.TabIndex = 49;
            this.btnMR.Text = "MR";
            this.toolTipHelp.SetToolTip(this.btnMR, "Использовать число из памяти");
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMC.Enabled = false;
            this.btnMC.Location = new System.Drawing.Point(165, 127);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(50, 35);
            this.btnMC.TabIndex = 48;
            this.btnMC.Text = "MC";
            this.toolTipHelp.SetToolTip(this.btnMC, "Очистить память");
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // txtCalculate
            // 
            this.txtCalculate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCalculate.Location = new System.Drawing.Point(165, 56);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.ReadOnly = true;
            this.txtCalculate.Size = new System.Drawing.Size(393, 23);
            this.txtCalculate.TabIndex = 47;
            this.txtCalculate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCalculate.TextChanged += new System.EventHandler(this.txtCalculate_TextChanged);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(736, 24);
            this.menuMain.TabIndex = 79;
            this.menuMain.Text = "menuStrip1";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.сбросБуфераToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            this.правкаToolStripMenuItem.Click += new System.EventHandler(this.правкаToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // сбросБуфераToolStripMenuItem
            // 
            this.сбросБуфераToolStripMenuItem.Name = "сбросБуфераToolStripMenuItem";
            this.сбросБуфераToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.сбросБуфераToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.сбросБуфераToolStripMenuItem.Text = "Сброс буфера";
            this.сбросБуфераToolStripMenuItem.Click += new System.EventHandler(this.сбросБуфераToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.обАвтореToolStripMenuItem.Text = "Об Авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // btnComplexPlus
            // 
            this.btnComplexPlus.Location = new System.Drawing.Point(657, 98);
            this.btnComplexPlus.Name = "btnComplexPlus";
            this.btnComplexPlus.Size = new System.Drawing.Size(50, 35);
            this.btnComplexPlus.TabIndex = 40;
            this.btnComplexPlus.Text = "+Im";
            this.btnComplexPlus.UseVisualStyleBackColor = true;
            this.btnComplexPlus.Click += new System.EventHandler(this.btnComplexPlus_Click);
            // 
            // btnCompMin
            // 
            this.btnCompMin.Location = new System.Drawing.Point(658, 139);
            this.btnCompMin.Name = "btnCompMin";
            this.btnCompMin.Size = new System.Drawing.Size(50, 35);
            this.btnCompMin.TabIndex = 39;
            this.btnCompMin.Text = "-Im";
            this.btnCompMin.UseVisualStyleBackColor = true;
            this.btnCompMin.Click += new System.EventHandler(this.btnCompMin_Click);
            // 
            // txtHistory
            // 
            this.txtHistory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHistory.Location = new System.Drawing.Point(165, 27);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.Size = new System.Drawing.Size(393, 23);
            this.txtHistory.TabIndex = 46;
            this.txtHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHistory.TextChanged += new System.EventHandler(this.txtHistory_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoCheck = false;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "ВЫКЛ";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Буфер";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Location = new System.Drawing.Point(12, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 52);
            this.panel4.TabIndex = 81;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ВЫКЛ";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Память";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(12, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 52);
            this.panel1.TabIndex = 80;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(673, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 13);
            this.lblType.TabIndex = 75;
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 354);
            this.Controls.Add(this.btnComplexPlus);
            this.Controls.Add(this.btnCompMin);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnNegativ);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnRev);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnDeduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSeparator);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMDeduct);
            this.Controls.Add(this.btnMAdd);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.txtCalculate);
            this.Controls.Add(this.txtHistory);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Калькулятор комплексных чисел";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNegativ;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Button btnSqr;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDeduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSeparator;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMDeduct;
        private System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.TextBox txtCalculate;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button btnComplexPlus;
        private System.Windows.Forms.Button btnCompMin;
        private System.Windows.Forms.ToolStripMenuItem сбросБуфераToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblType;
    }
}

