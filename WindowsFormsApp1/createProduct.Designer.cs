﻿namespace WindowsFormsApp1
{
    partial class createProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nimTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aproval = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.TextBox();
            this.nimTimeCheck = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.isAutomatic = new System.Windows.Forms.CheckBox();
            this.carYear = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.carManu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.carModel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.realestateType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.secondHandType = new System.Windows.Forms.ComboBox();
            this.condition = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.animalType = new System.Windows.Forms.ComboBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.isTraded = new System.Windows.Forms.CheckBox();
            this.isPackage = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(139, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "יצירת מודעה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(258, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "בחר סוג מוצר";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "נדלן",
            "רכב",
            "חיות מחמד",
            "מוצרי יד שנייה",
            "חבילה"});
            this.comboBox1.Location = new System.Drawing.Point(120, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "בחר";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(316, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "עלות";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(155, 127);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(82, 20);
            this.cost.TabIndex = 5;
            this.cost.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(243, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "זמן השכרה מינימלי";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nimTime
            // 
            this.nimTime.Location = new System.Drawing.Point(211, 71);
            this.nimTime.Name = "nimTime";
            this.nimTime.Size = new System.Drawing.Size(26, 20);
            this.nimTime.TabIndex = 7;
            this.nimTime.TextChanged += new System.EventHandler(this.nimTime_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(279, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "גישת אישור";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // aproval
            // 
            this.aproval.FormattingEnabled = true;
            this.aproval.Items.AddRange(new object[] {
            "שמרנית",
            "בטוחה",
            "כל הקודם זוכה"});
            this.aproval.Location = new System.Drawing.Point(155, 98);
            this.aproval.Name = "aproval";
            this.aproval.Size = new System.Drawing.Size(82, 21);
            this.aproval.TabIndex = 9;
            this.aproval.Text = "בחר";
            this.aproval.SelectedIndexChanged += new System.EventHandler(this.aproval_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(308, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "פקדון";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(155, 158);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(82, 20);
            this.deposit.TabIndex = 14;
            this.deposit.TextChanged += new System.EventHandler(this.deposit_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(59, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "תמונה";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(268, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "שעות לביטול";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(154, 187);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 20);
            this.cancel.TabIndex = 18;
            this.cancel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // nimTimeCheck
            // 
            this.nimTimeCheck.FormattingEnabled = true;
            this.nimTimeCheck.Items.AddRange(new object[] {
            "שעה",
            "יום",
            "חודש",
            "שנה"});
            this.nimTimeCheck.Location = new System.Drawing.Point(155, 71);
            this.nimTimeCheck.Name = "nimTimeCheck";
            this.nimTimeCheck.Size = new System.Drawing.Size(50, 21);
            this.nimTimeCheck.TabIndex = 20;
            this.nimTimeCheck.Text = "בחר";
            this.nimTimeCheck.SelectedIndexChanged += new System.EventHandler(this.nimTimeCheck_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.carType);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.isAutomatic);
            this.groupBox1.Controls.Add(this.carYear);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.carManu);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.carModel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(10, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 188);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // carType
            // 
            this.carType.FormattingEnabled = true;
            this.carType.Items.AddRange(new object[] {
            "private",
            "4X4",
            "sport",
            "minivan",
            "van",
            "truck",
            "minibus",
            "bus",
            "mini jeap",
            "micro",
            "suv",
            "limozine",
            "hybrid",
            "convertible",
            "motorcycle"});
            this.carType.Location = new System.Drawing.Point(12, 43);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(82, 21);
            this.carType.TabIndex = 33;
            this.carType.Text = "בחר";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(27, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "פרטים נוספים-רכב";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // isAutomatic
            // 
            this.isAutomatic.AutoSize = true;
            this.isAutomatic.Location = new System.Drawing.Point(86, 155);
            this.isAutomatic.Name = "isAutomatic";
            this.isAutomatic.Size = new System.Drawing.Size(65, 17);
            this.isAutomatic.TabIndex = 25;
            this.isAutomatic.Text = "אוטומט";
            this.isAutomatic.UseVisualStyleBackColor = true;
            // 
            // carYear
            // 
            this.carYear.Location = new System.Drawing.Point(12, 126);
            this.carYear.Name = "carYear";
            this.carYear.Size = new System.Drawing.Size(73, 20);
            this.carYear.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(89, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "שנת ייצור";
            // 
            // carManu
            // 
            this.carManu.Location = new System.Drawing.Point(12, 96);
            this.carManu.Name = "carManu";
            this.carManu.Size = new System.Drawing.Size(82, 20);
            this.carManu.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(118, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "יצרן";
            // 
            // carModel
            // 
            this.carModel.Location = new System.Drawing.Point(12, 70);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(82, 20);
            this.carModel.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(115, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "מודל";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(100, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "סוג רכב";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.CausesValidation = false;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.realestateType);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(155, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 136);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "הוסף ציוד";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // realestateType
            // 
            this.realestateType.FormattingEnabled = true;
            this.realestateType.Items.AddRange(new object[] {
            "דירה",
            "וילה",
            "סטודיו",
            "משרד",
            "מועדון ריקודים",
            "חדר ועידות",
            "אולם אירועים",
            "חדר אחסון"});
            this.realestateType.Location = new System.Drawing.Point(17, 51);
            this.realestateType.Name = "realestateType";
            this.realestateType.Size = new System.Drawing.Size(82, 21);
            this.realestateType.TabIndex = 34;
            this.realestateType.Text = "בחר";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(68, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "פרטים נוספים-נדל\"ן";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(17, 77);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(82, 20);
            this.textBox11.TabIndex = 9;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label18.Location = new System.Drawing.Point(105, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "כמות אנשים";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.Location = new System.Drawing.Point(152, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "סוג";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.CausesValidation = false;
            this.groupBox3.Controls.Add(this.secondHandType);
            this.groupBox3.Controls.Add(this.condition);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(170, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 106);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // secondHandType
            // 
            this.secondHandType.FormattingEnabled = true;
            this.secondHandType.Items.AddRange(new object[] {
            "לבית",
            "לגינה",
            "טקסטיל",
            "משחקים",
            "אופניים",
            "כלי נגינה"});
            this.secondHandType.Location = new System.Drawing.Point(1, 39);
            this.secondHandType.Name = "secondHandType";
            this.secondHandType.Size = new System.Drawing.Size(82, 21);
            this.secondHandType.TabIndex = 33;
            this.secondHandType.Text = "בחר";
            // 
            // condition
            // 
            this.condition.FormattingEnabled = true;
            this.condition.Items.AddRange(new object[] {
            "חדש",
            "כחדש",
            "משומש",
            "דרוש תיקון",
            "מהחבילה"});
            this.condition.Location = new System.Drawing.Point(1, 67);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(82, 21);
            this.condition.TabIndex = 32;
            this.condition.Text = "בחר";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(30, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "פרטים נוספים-יד שנייה";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label17.Location = new System.Drawing.Point(108, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "מצב מוצר";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label20.Location = new System.Drawing.Point(136, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "סוג";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "צור";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.CausesValidation = false;
            this.groupBox4.Controls.Add(this.gender);
            this.groupBox4.Controls.Add(this.animalType);
            this.groupBox4.Controls.Add(this.textBox16);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Location = new System.Drawing.Point(153, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 160);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.gender.Location = new System.Drawing.Point(12, 73);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(82, 21);
            this.gender.TabIndex = 32;
            this.gender.Text = "בחר";
            // 
            // animalType
            // 
            this.animalType.FormattingEnabled = true;
            this.animalType.Items.AddRange(new object[] {
            "סוס",
            "כלב ",
            "חתול",
            "דג",
            "ארנב",
            "אוגר",
            "שרקן",
            "זוחלים",
            "תוכי"});
            this.animalType.Location = new System.Drawing.Point(12, 44);
            this.animalType.Name = "animalType";
            this.animalType.Size = new System.Drawing.Size(82, 21);
            this.animalType.TabIndex = 31;
            this.animalType.Text = "בחר";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(9, 129);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(82, 20);
            this.textBox16.TabIndex = 30;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(9, 103);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(82, 20);
            this.textBox15.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label25.Location = new System.Drawing.Point(120, 131);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "גזע";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label24.Location = new System.Drawing.Point(119, 106);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "גיל";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label21.Location = new System.Drawing.Point(6, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(148, 17);
            this.label21.TabIndex = 26;
            this.label21.Text = "פרטים נוספים-חיות מחמד";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label22.Location = new System.Drawing.Point(121, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "מין";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label23.Location = new System.Drawing.Point(121, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "סוג";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "העלה תמונה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(11, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.CausesValidation = false;
            this.groupBox5.Controls.Add(this.checkedListBox1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Location = new System.Drawing.Point(14, 480);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 121);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Visible = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(4, 40);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(69, 79);
            this.checkedListBox1.TabIndex = 27;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(26, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "פרטים נוספים-חבילה";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label26.Location = new System.Drawing.Point(79, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "הוסף מוצרים";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label27.Location = new System.Drawing.Point(126, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 7;
            // 
            // isTraded
            // 
            this.isTraded.AutoSize = true;
            this.isTraded.BackColor = System.Drawing.Color.Transparent;
            this.isTraded.Location = new System.Drawing.Point(254, 248);
            this.isTraded.Name = "isTraded";
            this.isTraded.Size = new System.Drawing.Size(93, 17);
            this.isTraded.TabIndex = 12;
            this.isTraded.Text = "ניתן להחלפה";
            this.isTraded.UseVisualStyleBackColor = false;
            this.isTraded.CheckedChanged += new System.EventHandler(this.isTraded_CheckedChanged);
            // 
            // isPackage
            // 
            this.isPackage.AutoSize = true;
            this.isPackage.BackColor = System.Drawing.Color.Transparent;
            this.isPackage.Location = new System.Drawing.Point(217, 219);
            this.isPackage.Name = "isPackage";
            this.isPackage.Size = new System.Drawing.Size(131, 17);
            this.isPackage.TabIndex = 15;
            this.isPackage.Text = "האם רק חלק מחבילה";
            this.isPackage.UseVisualStyleBackColor = false;
            this.isPackage.CheckedChanged += new System.EventHandler(this.isPackage_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.numericUpDown1);
            this.groupBox6.Location = new System.Drawing.Point(103, 84);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(46, 39);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(29, 20);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // createProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(389, 613);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nimTimeCheck);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.isPackage);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isTraded);
            this.Controls.Add(this.aproval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nimTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createProduct";
            this.Text = "createProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nimTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox aproval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cancel;
        private System.Windows.Forms.ComboBox nimTimeCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isAutomatic;
        private System.Windows.Forms.TextBox carYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox carManu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox carModel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox animalType;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox condition;
        private System.Windows.Forms.ComboBox carType;
        private System.Windows.Forms.ComboBox realestateType;
        private System.Windows.Forms.ComboBox secondHandType;
        private System.Windows.Forms.CheckBox isTraded;
        private System.Windows.Forms.CheckBox isPackage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}