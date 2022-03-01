namespace auto_clicker;

partial class AutoClicker
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this._numericEveryMS = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this._numericDurationS = new System.Windows.Forms.NumericUpDown();
            this._btnStart = new System.Windows.Forms.Button();
            this._btnStop = new System.Windows.Forms.Button();
            this._clickDurationTimer = new System.Windows.Forms.Timer(this.components);
            this._clickEveryTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._numericEveryMS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericDurationS)).BeginInit();
            this.SuspendLayout();
            // 
            // _numericEveryMS
            // 
            this._numericEveryMS.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numericEveryMS.Location = new System.Drawing.Point(6, 22);
            this._numericEveryMS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._numericEveryMS.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numericEveryMS.Name = "_numericEveryMS";
            this._numericEveryMS.Size = new System.Drawing.Size(203, 23);
            this._numericEveryMS.TabIndex = 0;
            this._numericEveryMS.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._numericEveryMS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click every";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Milliseconds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this._numericDurationS);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Seconds";
            // 
            // _numericDurationS
            // 
            this._numericDurationS.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._numericDurationS.Location = new System.Drawing.Point(6, 22);
            this._numericDurationS.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this._numericDurationS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._numericDurationS.Name = "_numericDurationS";
            this._numericDurationS.Size = new System.Drawing.Size(203, 23);
            this._numericDurationS.TabIndex = 0;
            this._numericDurationS.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // _btnStart
            // 
            this._btnStart.Location = new System.Drawing.Point(12, 144);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(144, 52);
            this._btnStart.TabIndex = 2;
            this._btnStart.Text = "Start (F6)";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _btnStop
            // 
            this._btnStop.Location = new System.Drawing.Point(162, 144);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(144, 52);
            this._btnStop.TabIndex = 3;
            this._btnStop.Text = "Stop (F7)";
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
            // 
            // _clickDurationTimer
            // 
            this._clickDurationTimer.Tick += new System.EventHandler(this._clickDurationTimer_Tick);
            // 
            // _clickEveryTimer
            // 
            this._clickEveryTimer.Tick += new System.EventHandler(this._clickEveryTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 204);
            this.Controls.Add(this._btnStop);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "auto-clicker";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this._numericEveryMS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericDurationS)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private NumericUpDown _numericEveryMS;
    private GroupBox groupBox1;
    private Label label1;
    private GroupBox groupBox2;
    private Label label4;
    private NumericUpDown _numericDurationS;
    private Button _btnStart;
    private Button _btnStop;
    private System.Windows.Forms.Timer _clickDurationTimer;
    private System.Windows.Forms.Timer _clickEveryTimer;
}
