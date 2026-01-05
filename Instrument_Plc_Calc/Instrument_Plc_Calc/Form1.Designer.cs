
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
        spanValue = new System.Windows.Forms.Label();
        URV = new System.Windows.Forms.TextBox();
        LRV = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        signalType = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        resultsGroup = new System.Windows.Forms.GroupBox();
        rawResult = new System.Windows.Forms.Label();
        signalResult = new System.Windows.Forms.Label();
        engineeringResult = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        unitSignalSelect = new System.Windows.Forms.ComboBox();
        label19 = new System.Windows.Forms.Label();
        inputValue = new System.Windows.Forms.TextBox();
        label12 = new System.Windows.Forms.Label();
        electricSignalSelect = new System.Windows.Forms.RadioButton();
        engineeringValueSelect = new System.Windows.Forms.RadioButton();
        label11 = new System.Windows.Forms.Label();
        groupBox2 = new System.Windows.Forms.GroupBox();
        dataType = new System.Windows.Forms.Label();
        rawRange = new System.Windows.Forms.Label();
        label15 = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        platformSelect = new System.Windows.Forms.ComboBox();
        label14 = new System.Windows.Forms.Label();
        calculateButton = new System.Windows.Forms.Button();
        resetButton = new System.Windows.Forms.Button();
        panelSelectCalc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        instrumentGroup.SuspendLayout();
        resultsGroup.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // panelSelectCalc
        // 
        panelSelectCalc.BackColor = System.Drawing.SystemColors.Control;
        panelSelectCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        panelSelectCalc.Controls.Add(label18);
        panelSelectCalc.Controls.Add(pictureBox1);
        panelSelectCalc.ForeColor = System.Drawing.SystemColors.ControlText;
        panelSelectCalc.Location = new System.Drawing.Point(2, 0);
        panelSelectCalc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
        panelSelectCalc.Name = "panelSelectCalc";
        panelSelectCalc.Size = new System.Drawing.Size(490, 41);
        panelSelectCalc.TabIndex = 0;
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label18.Location = new System.Drawing.Point(238, 7);
        label18.Name = "label18";
        label18.Size = new System.Drawing.Size(207, 25);
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
        instrumentGroup.Controls.Add(spanValue);
        instrumentGroup.Controls.Add(URV);
        instrumentGroup.Controls.Add(LRV);
        instrumentGroup.Controls.Add(label4);
        instrumentGroup.Controls.Add(label3);
        instrumentGroup.Controls.Add(label2);
        instrumentGroup.Controls.Add(signalType);
        instrumentGroup.Controls.Add(label1);
        instrumentGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        instrumentGroup.Location = new System.Drawing.Point(19, 54);
        instrumentGroup.Margin = new System.Windows.Forms.Padding(10);
        instrumentGroup.Name = "instrumentGroup";
        instrumentGroup.Size = new System.Drawing.Size(233, 195);
        instrumentGroup.TabIndex = 5;
        instrumentGroup.TabStop = false;
        instrumentGroup.Text = "Instrument Setup";
        // 
        // spanValue
        // 
        spanValue.AutoSize = true;
        spanValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        spanValue.Location = new System.Drawing.Point(97, 163);
        spanValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        spanValue.Name = "spanValue";
        spanValue.Size = new System.Drawing.Size(80, 17);
        spanValue.TabIndex = 12;
        spanValue.Text = "INT / WORD";
        // 
        // URV
        // 
        URV.Location = new System.Drawing.Point(97, 119);
        URV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
        URV.Name = "URV";
        URV.Size = new System.Drawing.Size(121, 25);
        URV.TabIndex = 6;
        // 
        // LRV
        // 
        LRV.Location = new System.Drawing.Point(97, 78);
        LRV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
        LRV.Name = "LRV";
        LRV.Size = new System.Drawing.Size(121, 25);
        LRV.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(6, 163);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(40, 17);
        label4.TabIndex = 4;
        label4.Text = "Span:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(6, 122);
        label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(36, 17);
        label3.TabIndex = 3;
        label3.Text = "URV:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(6, 81);
        label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(33, 17);
        label2.TabIndex = 2;
        label2.Text = "LRV:";
        // 
        // signalType
        // 
        signalType.FormattingEnabled = true;
        signalType.Items.AddRange(new object[] { "4-20mA", "0-10V", "+-10V" });
        signalType.Location = new System.Drawing.Point(97, 36);
        signalType.Name = "signalType";
        signalType.Size = new System.Drawing.Size(121, 25);
        signalType.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(6, 37);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(77, 17);
        label1.TabIndex = 0;
        label1.Text = "Signal Type:";
        // 
        // resultsGroup
        // 
        resultsGroup.Controls.Add(rawResult);
        resultsGroup.Controls.Add(signalResult);
        resultsGroup.Controls.Add(engineeringResult);
        resultsGroup.Controls.Add(label7);
        resultsGroup.Controls.Add(label6);
        resultsGroup.Controls.Add(label5);
        resultsGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        resultsGroup.Location = new System.Drawing.Point(272, 54);
        resultsGroup.Margin = new System.Windows.Forms.Padding(10);
        resultsGroup.Name = "resultsGroup";
        resultsGroup.Size = new System.Drawing.Size(200, 129);
        resultsGroup.TabIndex = 6;
        resultsGroup.TabStop = false;
        resultsGroup.Text = "Results";
        // 
        // rawResult
        // 
        rawResult.AutoSize = true;
        rawResult.Location = new System.Drawing.Point(114, 96);
        rawResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        rawResult.Name = "rawResult";
        rawResult.Size = new System.Drawing.Size(43, 17);
        rawResult.TabIndex = 5;
        rawResult.Text = "13824";
        // 
        // signalResult
        // 
        signalResult.AutoSize = true;
        signalResult.Location = new System.Drawing.Point(114, 64);
        signalResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        signalResult.Name = "signalResult";
        signalResult.Size = new System.Drawing.Size(55, 17);
        signalResult.TabIndex = 4;
        signalResult.Text = "12.0 mA";
        // 
        // engineeringResult
        // 
        engineeringResult.AutoSize = true;
        engineeringResult.Location = new System.Drawing.Point(114, 32);
        engineeringResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        engineeringResult.Name = "engineeringResult";
        engineeringResult.Size = new System.Drawing.Size(46, 17);
        engineeringResult.TabIndex = 3;
        engineeringResult.Text = "50 bar";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new System.Drawing.Point(6, 96);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(60, 17);
        label7.TabIndex = 2;
        label7.Text = "PLC Raw:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new System.Drawing.Point(6, 64);
        label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(46, 17);
        label6.TabIndex = 1;
        label6.Text = "Signal:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new System.Drawing.Point(6, 32);
        label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(80, 17);
        label5.TabIndex = 0;
        label5.Text = "Engineering:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(unitSignalSelect);
        groupBox1.Controls.Add(label19);
        groupBox1.Controls.Add(inputValue);
        groupBox1.Controls.Add(label12);
        groupBox1.Controls.Add(electricSignalSelect);
        groupBox1.Controls.Add(engineeringValueSelect);
        groupBox1.Controls.Add(label11);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox1.Location = new System.Drawing.Point(19, 262);
        groupBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(453, 105);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "Input Values";
        // 
        // unitSignalSelect
        // 
        unitSignalSelect.FormattingEnabled = true;
        unitSignalSelect.Items.AddRange(new object[] { "bar", "°C", "%", "m", "kg/h", "PSI" });
        unitSignalSelect.Location = new System.Drawing.Point(334, 70);
        unitSignalSelect.Name = "unitSignalSelect";
        unitSignalSelect.Size = new System.Drawing.Size(103, 25);
        unitSignalSelect.TabIndex = 9;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label19.Location = new System.Drawing.Point(241, 73);
        label19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label19.Name = "label19";
        label19.Size = new System.Drawing.Size(82, 17);
        label19.TabIndex = 8;
        label19.Text = "Unit / Signal:";
        // 
        // inputValue
        // 
        inputValue.Location = new System.Drawing.Point(334, 36);
        inputValue.Name = "inputValue";
        inputValue.Size = new System.Drawing.Size(103, 25);
        inputValue.TabIndex = 7;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(241, 39);
        label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(75, 17);
        label12.TabIndex = 4;
        label12.Text = "Input Value:";
        // 
        // electricSignalSelect
        // 
        electricSignalSelect.AutoSize = true;
        electricSignalSelect.Location = new System.Drawing.Point(86, 71);
        electricSignalSelect.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
        electricSignalSelect.Name = "electricSignalSelect";
        electricSignalSelect.Size = new System.Drawing.Size(106, 21);
        electricSignalSelect.TabIndex = 3;
        electricSignalSelect.TabStop = true;
        electricSignalSelect.Text = "Electric Signal";
        electricSignalSelect.UseVisualStyleBackColor = true;
        // 
        // engineeringValueSelect
        // 
        engineeringValueSelect.AutoSize = true;
        engineeringValueSelect.Location = new System.Drawing.Point(86, 40);
        engineeringValueSelect.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
        engineeringValueSelect.Name = "engineeringValueSelect";
        engineeringValueSelect.Size = new System.Drawing.Size(130, 21);
        engineeringValueSelect.TabIndex = 2;
        engineeringValueSelect.TabStop = true;
        engineeringValueSelect.Text = "Engineering Value";
        engineeringValueSelect.UseVisualStyleBackColor = true;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.Location = new System.Drawing.Point(6, 39);
        label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(71, 17);
        label11.TabIndex = 1;
        label11.Text = "Input Type:";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dataType);
        groupBox2.Controls.Add(rawRange);
        groupBox2.Controls.Add(label15);
        groupBox2.Controls.Add(label13);
        groupBox2.Controls.Add(platformSelect);
        groupBox2.Controls.Add(label14);
        groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox2.Location = new System.Drawing.Point(19, 380);
        groupBox2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(453, 140);
        groupBox2.TabIndex = 8;
        groupBox2.TabStop = false;
        groupBox2.Text = "PLC Scale Configuration";
        // 
        // dataType
        // 
        dataType.AutoSize = true;
        dataType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dataType.Location = new System.Drawing.Point(116, 107);
        dataType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        dataType.Name = "dataType";
        dataType.Size = new System.Drawing.Size(80, 17);
        dataType.TabIndex = 11;
        dataType.Text = "INT / WORD";
        // 
        // rawRange
        // 
        rawRange.AutoSize = true;
        rawRange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        rawRange.Location = new System.Drawing.Point(116, 75);
        rawRange.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        rawRange.Name = "rawRange";
        rawRange.Size = new System.Drawing.Size(63, 17);
        rawRange.TabIndex = 10;
        rawRange.Text = "0 - 27648";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label15.Location = new System.Drawing.Point(6, 107);
        label15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(69, 17);
        label15.TabIndex = 9;
        label15.Text = "Data Type:";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label13.Location = new System.Drawing.Point(6, 75);
        label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(76, 17);
        label13.TabIndex = 8;
        label13.Text = "Raw Range:";
        // 
        // platformSelect
        // 
        platformSelect.FormattingEnabled = true;
        platformSelect.Items.AddRange(new object[] { "Siemens", "Allen Bradley", "Delta" });
        platformSelect.Location = new System.Drawing.Point(116, 36);
        platformSelect.Name = "platformSelect";
        platformSelect.Size = new System.Drawing.Size(121, 25);
        platformSelect.TabIndex = 7;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label14.Location = new System.Drawing.Point(6, 39);
        label14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(60, 17);
        label14.TabIndex = 1;
        label14.Text = "Platform:";
        // 
        // calculateButton
        // 
        calculateButton.AutoSize = true;
        calculateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        calculateButton.Location = new System.Drawing.Point(116, 533);
        calculateButton.Name = "calculateButton";
        calculateButton.Size = new System.Drawing.Size(93, 36);
        calculateButton.TabIndex = 9;
        calculateButton.Text = "Calculate";
        calculateButton.UseVisualStyleBackColor = true;
        // 
        // resetButton
        // 
        resetButton.AutoSize = true;
        resetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        resetButton.Location = new System.Drawing.Point(244, 533);
        resetButton.Name = "resetButton";
        resetButton.Size = new System.Drawing.Size(93, 36);
        resetButton.TabIndex = 10;
        resetButton.Text = "Reset";
        resetButton.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(493, 576);
        Controls.Add(resetButton);
        Controls.Add(calculateButton);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(resultsGroup);
        Controls.Add(instrumentGroup);
        Controls.Add(panelSelectCalc);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
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
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button resetButton;

    private System.Windows.Forms.Button calculateButton;

    private System.Windows.Forms.Label spanValue;

    private System.Windows.Forms.ComboBox unitSignalSelect;

    private System.Windows.Forms.Label label19;

    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label rawRange;
    private System.Windows.Forms.Label dataType;
    private System.Windows.Forms.Label label18;

    private System.Windows.Forms.TextBox inputValue;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.ComboBox platformSelect;

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.RadioButton engineeringValueSelect;
    private System.Windows.Forms.RadioButton electricSignalSelect;
    private System.Windows.Forms.Label label12;

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
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox LRV;
    private System.Windows.Forms.TextBox URV;

    private System.Windows.Forms.ComboBox signalType;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.GroupBox instrumentGroup;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Panel panelSelectCalc;

    #endregion
}