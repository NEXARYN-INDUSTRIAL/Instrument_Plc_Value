
namespace Instrument_Plc_Calc;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        panelSelectCalc = new System.Windows.Forms.Panel();
        label18 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        instrumentGroup = new System.Windows.Forms.GroupBox();
        engineeringUnit = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        engineeringURV = new System.Windows.Forms.TextBox();
        engineeringLRV = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        resultsGroup = new System.Windows.Forms.GroupBox();
        rawResult = new System.Windows.Forms.Label();
        signalResult = new System.Windows.Forms.Label();
        engineeringResult = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        unitSignalInput = new System.Windows.Forms.ComboBox();
        label12 = new System.Windows.Forms.Label();
        calculateButton = new System.Windows.Forms.Button();
        inputRaw = new System.Windows.Forms.TextBox();
        unitEngineeringInput = new System.Windows.Forms.ComboBox();
        inputSignal = new System.Windows.Forms.TextBox();
        label19 = new System.Windows.Forms.Label();
        radioButton1 = new System.Windows.Forms.RadioButton();
        inputEngineering = new System.Windows.Forms.TextBox();
        electricSignalSelect = new System.Windows.Forms.RadioButton();
        engineeringValueSelect = new System.Windows.Forms.RadioButton();
        groupBox2 = new System.Windows.Forms.GroupBox();
        rawMin = new System.Windows.Forms.Label();
        rawMax = new System.Windows.Forms.Label();
        modePlcScale = new System.Windows.Forms.ComboBox();
        label246 = new System.Windows.Forms.Label();
        label15 = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        brandSelect = new System.Windows.Forms.ComboBox();
        label14 = new System.Windows.Forms.Label();
        groupBox3 = new System.Windows.Forms.GroupBox();
        signalURV = new System.Windows.Forms.TextBox();
        signalLRV = new System.Windows.Forms.TextBox();
        label10 = new System.Windows.Forms.Label();
        label16 = new System.Windows.Forms.Label();
        signalType = new System.Windows.Forms.ComboBox();
        label17 = new System.Windows.Forms.Label();
        panelSelectCalc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        instrumentGroup.SuspendLayout();
        resultsGroup.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // panelSelectCalc
        // 
        panelSelectCalc.BackColor = System.Drawing.SystemColors.Control;
        panelSelectCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        panelSelectCalc.Controls.Add(label18);
        panelSelectCalc.Controls.Add(pictureBox1);
        panelSelectCalc.ForeColor = System.Drawing.SystemColors.ControlText;
        panelSelectCalc.Location = new System.Drawing.Point(19, 0);
        panelSelectCalc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
        panelSelectCalc.Name = "panelSelectCalc";
        panelSelectCalc.Size = new System.Drawing.Size(486, 41);
        panelSelectCalc.TabIndex = 0;
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label18.Location = new System.Drawing.Point(241, 5);
        label18.Name = "label18";
        label18.Size = new System.Drawing.Size(214, 28);
        label18.TabIndex = 5;
        label18.Text = "Industrial Control Tools";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(17, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(198, 41);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // instrumentGroup
        // 
        instrumentGroup.Controls.Add(engineeringUnit);
        instrumentGroup.Controls.Add(label1);
        instrumentGroup.Controls.Add(engineeringURV);
        instrumentGroup.Controls.Add(engineeringLRV);
        instrumentGroup.Controls.Add(label3);
        instrumentGroup.Controls.Add(label2);
        instrumentGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        instrumentGroup.Location = new System.Drawing.Point(19, 54);
        instrumentGroup.Margin = new System.Windows.Forms.Padding(10);
        instrumentGroup.Name = "instrumentGroup";
        instrumentGroup.Size = new System.Drawing.Size(215, 195);
        instrumentGroup.TabIndex = 5;
        instrumentGroup.TabStop = false;
        instrumentGroup.Text = "Engineering Range";
        // 
        // engineeringUnit
        // 
        engineeringUnit.FormattingEnabled = true;
        engineeringUnit.Items.AddRange(new object[] { "bar", "°C", "%", "m", "kg/h", "PSI" });
        engineeringUnit.Location = new System.Drawing.Point(92, 119);
        engineeringUnit.Name = "engineeringUnit";
        engineeringUnit.Size = new System.Drawing.Size(106, 29);
        engineeringUnit.TabIndex = 10;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(9, 122);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(46, 23);
        label1.TabIndex = 13;
        label1.Text = "Unit:";
        // 
        // engineeringURV
        // 
        engineeringURV.Location = new System.Drawing.Point(92, 77);
        engineeringURV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
        engineeringURV.Name = "engineeringURV";
        engineeringURV.Size = new System.Drawing.Size(106, 29);
        engineeringURV.TabIndex = 6;
        // 
        // engineeringLRV
        // 
        engineeringLRV.Location = new System.Drawing.Point(92, 36);
        engineeringLRV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
        engineeringLRV.Name = "engineeringLRV";
        engineeringLRV.Size = new System.Drawing.Size(106, 29);
        engineeringLRV.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(9, 80);
        label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(47, 23);
        label3.TabIndex = 3;
        label3.Text = "URV:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(9, 39);
        label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(43, 23);
        label2.TabIndex = 2;
        label2.Text = "LRV:";
        // 
        // resultsGroup
        // 
        resultsGroup.Controls.Add(rawResult);
        resultsGroup.Controls.Add(signalResult);
        resultsGroup.Controls.Add(engineeringResult);
        resultsGroup.Controls.Add(label7);
        resultsGroup.Controls.Add(label6);
        resultsGroup.Controls.Add(label5);
        resultsGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        resultsGroup.Location = new System.Drawing.Point(19, 630);
        resultsGroup.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
        resultsGroup.Name = "resultsGroup";
        resultsGroup.Size = new System.Drawing.Size(486, 169);
        resultsGroup.TabIndex = 6;
        resultsGroup.TabStop = false;
        resultsGroup.Text = "Results";
        // 
        // rawResult
        // 
        rawResult.AutoSize = true;
        rawResult.Location = new System.Drawing.Point(141, 113);
        rawResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        rawResult.Name = "rawResult";
        rawResult.Size = new System.Drawing.Size(65, 28);
        rawResult.TabIndex = 5;
        rawResult.Text = "13824";
        // 
        // signalResult
        // 
        signalResult.AutoSize = true;
        signalResult.Location = new System.Drawing.Point(141, 72);
        signalResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        signalResult.Name = "signalResult";
        signalResult.Size = new System.Drawing.Size(84, 28);
        signalResult.TabIndex = 4;
        signalResult.Text = "12.0 mA";
        // 
        // engineeringResult
        // 
        engineeringResult.AutoSize = true;
        engineeringResult.Location = new System.Drawing.Point(141, 32);
        engineeringResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        engineeringResult.Name = "engineeringResult";
        engineeringResult.Size = new System.Drawing.Size(69, 28);
        engineeringResult.TabIndex = 3;
        engineeringResult.Text = "50 bar";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new System.Drawing.Point(6, 113);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(93, 28);
        label7.TabIndex = 2;
        label7.Text = "PLC Raw:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new System.Drawing.Point(6, 72);
        label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(72, 28);
        label6.TabIndex = 1;
        label6.Text = "Signal:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new System.Drawing.Point(6, 32);
        label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(126, 28);
        label5.TabIndex = 0;
        label5.Text = "Engineering:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(unitSignalInput);
        groupBox1.Controls.Add(label12);
        groupBox1.Controls.Add(calculateButton);
        groupBox1.Controls.Add(inputRaw);
        groupBox1.Controls.Add(unitEngineeringInput);
        groupBox1.Controls.Add(inputSignal);
        groupBox1.Controls.Add(label19);
        groupBox1.Controls.Add(radioButton1);
        groupBox1.Controls.Add(inputEngineering);
        groupBox1.Controls.Add(electricSignalSelect);
        groupBox1.Controls.Add(engineeringValueSelect);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox1.Location = new System.Drawing.Point(19, 415);
        groupBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(486, 202);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "Input Value";
        // 
        // unitSignalInput
        // 
        unitSignalInput.FormattingEnabled = true;
        unitSignalInput.Items.AddRange(new object[] { "bar", "°C", "%", "m", "kg/h", "PSI" });
        unitSignalInput.Location = new System.Drawing.Point(365, 75);
        unitSignalInput.Name = "unitSignalInput";
        unitSignalInput.Size = new System.Drawing.Size(87, 29);
        unitSignalInput.TabIndex = 14;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(305, 76);
        label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(42, 23);
        label12.TabIndex = 13;
        label12.Text = "Unit";
        // 
        // calculateButton
        // 
        calculateButton.AutoSize = true;
        calculateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        calculateButton.Location = new System.Drawing.Point(198, 151);
        calculateButton.Name = "calculateButton";
        calculateButton.Size = new System.Drawing.Size(93, 36);
        calculateButton.TabIndex = 9;
        calculateButton.Text = "Calculate";
        calculateButton.UseVisualStyleBackColor = true;
        // 
        // inputRaw
        // 
        inputRaw.Location = new System.Drawing.Point(161, 110);
        inputRaw.Name = "inputRaw";
        inputRaw.Size = new System.Drawing.Size(87, 29);
        inputRaw.TabIndex = 12;
        // 
        // unitEngineeringInput
        // 
        unitEngineeringInput.FormattingEnabled = true;
        unitEngineeringInput.Items.AddRange(new object[] { "bar", "°C", "%", "m", "kg/h", "PSI" });
        unitEngineeringInput.Location = new System.Drawing.Point(365, 40);
        unitEngineeringInput.Name = "unitEngineeringInput";
        unitEngineeringInput.Size = new System.Drawing.Size(87, 29);
        unitEngineeringInput.TabIndex = 9;
        // 
        // inputSignal
        // 
        inputSignal.Location = new System.Drawing.Point(161, 75);
        inputSignal.Name = "inputSignal";
        inputSignal.Size = new System.Drawing.Size(87, 29);
        inputSignal.TabIndex = 11;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label19.Location = new System.Drawing.Point(305, 41);
        label19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label19.Name = "label19";
        label19.Size = new System.Drawing.Size(42, 23);
        label19.TabIndex = 8;
        label19.Text = "Unit";
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new System.Drawing.Point(9, 105);
        radioButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new System.Drawing.Size(62, 27);
        radioButton1.TabIndex = 10;
        radioButton1.TabStop = true;
        radioButton1.Text = "Raw";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // inputEngineering
        // 
        inputEngineering.Location = new System.Drawing.Point(161, 40);
        inputEngineering.Name = "inputEngineering";
        inputEngineering.Size = new System.Drawing.Size(87, 29);
        inputEngineering.TabIndex = 7;
        // 
        // electricSignalSelect
        // 
        electricSignalSelect.AutoSize = true;
        electricSignalSelect.Location = new System.Drawing.Point(9, 72);
        electricSignalSelect.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
        electricSignalSelect.Name = "electricSignalSelect";
        electricSignalSelect.Size = new System.Drawing.Size(77, 27);
        electricSignalSelect.TabIndex = 3;
        electricSignalSelect.TabStop = true;
        electricSignalSelect.Text = "Signal";
        electricSignalSelect.UseVisualStyleBackColor = true;
        // 
        // engineeringValueSelect
        // 
        engineeringValueSelect.AutoSize = true;
        engineeringValueSelect.Location = new System.Drawing.Point(9, 38);
        engineeringValueSelect.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
        engineeringValueSelect.Name = "engineeringValueSelect";
        engineeringValueSelect.Size = new System.Drawing.Size(122, 27);
        engineeringValueSelect.TabIndex = 2;
        engineeringValueSelect.TabStop = true;
        engineeringValueSelect.Text = "Engineering";
        engineeringValueSelect.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(rawMin);
        groupBox2.Controls.Add(rawMax);
        groupBox2.Controls.Add(modePlcScale);
        groupBox2.Controls.Add(label246);
        groupBox2.Controls.Add(label15);
        groupBox2.Controls.Add(label13);
        groupBox2.Controls.Add(brandSelect);
        groupBox2.Controls.Add(label14);
        groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox2.Location = new System.Drawing.Point(19, 262);
        groupBox2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(486, 140);
        groupBox2.TabIndex = 8;
        groupBox2.TabStop = false;
        groupBox2.Text = "PLC Scale Configuration";
        // 
        // rawMin
        // 
        rawMin.AutoSize = true;
        rawMin.Location = new System.Drawing.Point(157, 106);
        rawMin.Name = "rawMin";
        rawMin.Size = new System.Drawing.Size(64, 23);
        rawMin.TabIndex = 14;
        rawMin.Text = "label20";
        // 
        // rawMax
        // 
        rawMax.AutoSize = true;
        rawMax.Location = new System.Drawing.Point(357, 106);
        rawMax.Name = "rawMax";
        rawMax.Size = new System.Drawing.Size(55, 23);
        rawMax.TabIndex = 13;
        rawMax.Text = "label4";
        // 
        // modePlcScale
        // 
        modePlcScale.FormattingEnabled = true;
        modePlcScale.Items.AddRange(new object[] { "Siemens", "Allen Bradley", "Delta" });
        modePlcScale.Location = new System.Drawing.Point(217, 64);
        modePlcScale.Name = "modePlcScale";
        modePlcScale.Size = new System.Drawing.Size(121, 29);
        modePlcScale.TabIndex = 12;
        // 
        // label246
        // 
        label246.AutoSize = true;
        label246.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label246.Location = new System.Drawing.Point(258, 106);
        label246.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label246.Name = "label246";
        label246.Size = new System.Drawing.Size(82, 23);
        label246.TabIndex = 11;
        label246.Text = "Raw Max:";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label15.Location = new System.Drawing.Point(62, 106);
        label15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(79, 23);
        label15.TabIndex = 9;
        label15.Text = "Raw Min:";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label13.Location = new System.Drawing.Point(62, 67);
        label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(58, 23);
        label13.TabIndex = 8;
        label13.Text = "Mode:";
        // 
        // brandSelect
        // 
        brandSelect.FormattingEnabled = true;
        brandSelect.Items.AddRange(new object[] { "Siemens", "Allen Bradley", "Delta" });
        brandSelect.Location = new System.Drawing.Point(217, 28);
        brandSelect.Name = "brandSelect";
        brandSelect.Size = new System.Drawing.Size(121, 29);
        brandSelect.TabIndex = 7;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label14.Location = new System.Drawing.Point(62, 31);
        label14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(59, 23);
        label14.TabIndex = 1;
        label14.Text = "Brand:";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(signalURV);
        groupBox3.Controls.Add(signalLRV);
        groupBox3.Controls.Add(label10);
        groupBox3.Controls.Add(label16);
        groupBox3.Controls.Add(signalType);
        groupBox3.Controls.Add(label17);
        groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox3.Location = new System.Drawing.Point(254, 54);
        groupBox3.Margin = new System.Windows.Forms.Padding(10);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(251, 195);
        groupBox3.TabIndex = 13;
        groupBox3.TabStop = false;
        groupBox3.Text = "Signal (Electrical)";
        // 
        // signalURV
        // 
        signalURV.Location = new System.Drawing.Point(118, 119);
        signalURV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
        signalURV.Name = "signalURV";
        signalURV.Size = new System.Drawing.Size(106, 29);
        signalURV.TabIndex = 6;
        // 
        // signalLRV
        // 
        signalLRV.Location = new System.Drawing.Point(118, 78);
        signalLRV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
        signalLRV.Name = "signalLRV";
        signalLRV.Size = new System.Drawing.Size(106, 29);
        signalLRV.TabIndex = 5;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.Location = new System.Drawing.Point(6, 122);
        label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(47, 23);
        label10.TabIndex = 3;
        label10.Text = "URV:";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label16.Location = new System.Drawing.Point(6, 81);
        label16.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label16.Name = "label16";
        label16.Size = new System.Drawing.Size(43, 23);
        label16.TabIndex = 2;
        label16.Text = "LRV:";
        // 
        // signalType
        // 
        signalType.FormattingEnabled = true;
        signalType.Items.AddRange(new object[] { "4-20mA", "0-10V", "+-10V" });
        signalType.Location = new System.Drawing.Point(118, 36);
        signalType.Name = "signalType";
        signalType.Size = new System.Drawing.Size(106, 29);
        signalType.TabIndex = 1;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label17.Location = new System.Drawing.Point(6, 37);
        label17.Name = "label17";
        label17.Size = new System.Drawing.Size(100, 23);
        label17.TabIndex = 0;
        label17.Text = "Signal Type:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(527, 810);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(resultsGroup);
        Controls.Add(instrumentGroup);
        Controls.Add(panelSelectCalc);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Text = "Instrumentation PLC Calculator";
        panelSelectCalc.ResumeLayout(false);
        panelSelectCalc.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        instrumentGroup.ResumeLayout(false);
        instrumentGroup.PerformLayout();
        resultsGroup.ResumeLayout(false);
        resultsGroup.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox unitSignalInput;
    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.TextBox inputSignal;
    private System.Windows.Forms.TextBox inputRaw;

    private System.Windows.Forms.RadioButton radioButton1;

    private System.Windows.Forms.Label rawMax;
    private System.Windows.Forms.Label rawMin;

    private System.Windows.Forms.ComboBox modePlcScale;

    private System.Windows.Forms.ComboBox engineeringUnit;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox signalURV;
    private System.Windows.Forms.TextBox signalLRV;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.ComboBox signalType;
    private System.Windows.Forms.Label label17;

    private System.Windows.Forms.Button calculateButton;

    private System.Windows.Forms.ComboBox unitEngineeringInput;

    private System.Windows.Forms.Label label19;

    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label246;
    private System.Windows.Forms.Label label18;

    private System.Windows.Forms.TextBox inputEngineering;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.ComboBox brandSelect;

    private System.Windows.Forms.RadioButton engineeringValueSelect;
    private System.Windows.Forms.RadioButton electricSignalSelect;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label engineeringResult;
    private System.Windows.Forms.Label signalResult;
    private System.Windows.Forms.Label rawResult;

    private System.Windows.Forms.GroupBox resultsGroup;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox engineeringLRV;
    private System.Windows.Forms.TextBox engineeringURV;

    private System.Windows.Forms.GroupBox instrumentGroup;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Panel panelSelectCalc;

    #endregion
}