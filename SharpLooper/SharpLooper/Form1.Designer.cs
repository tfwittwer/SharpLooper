
namespace SharpLooper
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
            this.startB = new System.Windows.Forms.Button();
            this.PauseB = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.setStartB = new System.Windows.Forms.Button();
            this.setEndB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startBox = new System.Windows.Forms.TextBox();
            this.endBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.slowerB = new System.Windows.Forms.Button();
            this.fasterB = new System.Windows.Forms.Button();
            this.speedLbl = new System.Windows.Forms.Label();
            this.s05B = new System.Windows.Forms.Button();
            this.s075B = new System.Windows.Forms.Button();
            this.s1B = new System.Windows.Forms.Button();
            this.s125B = new System.Windows.Forms.Button();
            this.s15B = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.min30B = new System.Windows.Forms.Button();
            this.min10B = new System.Windows.Forms.Button();
            this.plus10B = new System.Windows.Forms.Button();
            this.plus30B = new System.Windows.Forms.Button();
            this.fileOpenB = new System.Windows.Forms.Button();
            this.clearStartB = new System.Windows.Forms.Button();
            this.clearEndB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(170, 141);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(75, 23);
            this.startB.TabIndex = 0;
            this.startB.Text = "Start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // PauseB
            // 
            this.PauseB.Location = new System.Drawing.Point(15, 141);
            this.PauseB.Name = "PauseB";
            this.PauseB.Size = new System.Drawing.Size(75, 23);
            this.PauseB.TabIndex = 1;
            this.PauseB.Text = "Pause";
            this.PauseB.UseVisualStyleBackColor = true;
            this.PauseB.Click += new System.EventHandler(this.PauseB_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.Location = new System.Drawing.Point(12, 277);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(256, 21);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "label1";
            // 
            // setStartB
            // 
            this.setStartB.Location = new System.Drawing.Point(143, 36);
            this.setStartB.Name = "setStartB";
            this.setStartB.Size = new System.Drawing.Size(48, 23);
            this.setStartB.TabIndex = 3;
            this.setStartB.Text = "Set";
            this.setStartB.UseVisualStyleBackColor = true;
            this.setStartB.Click += new System.EventHandler(this.setStartB_Click);
            // 
            // setEndB
            // 
            this.setEndB.Location = new System.Drawing.Point(143, 62);
            this.setEndB.Name = "setEndB";
            this.setEndB.Size = new System.Drawing.Size(48, 23);
            this.setEndB.TabIndex = 4;
            this.setEndB.Text = "Set";
            this.setEndB.UseVisualStyleBackColor = true;
            this.setEndB.Click += new System.EventHandler(this.setEndB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start:";
            // 
            // startBox
            // 
            this.startBox.Location = new System.Drawing.Point(41, 38);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(96, 20);
            this.startBox.TabIndex = 6;
            this.startBox.TextChanged += new System.EventHandler(this.startBox_TextChanged);
            this.startBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startBox_KeyDown);
            this.startBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startBox_KeyPress);
            // 
            // endBox
            // 
            this.endBox.Location = new System.Drawing.Point(41, 64);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(96, 20);
            this.endBox.TabIndex = 7;
            this.endBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.endBox_KeyDown);
            this.endBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "End:";
            // 
            // fileBox
            // 
            this.fileBox.AllowDrop = true;
            this.fileBox.Location = new System.Drawing.Point(41, 12);
            this.fileBox.Name = "fileBox";
            this.fileBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileBox.Size = new System.Drawing.Size(171, 20);
            this.fileBox.TabIndex = 10;
            this.fileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileBox_DragDrop);
            this.fileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileBox_DragEnter);
            this.fileBox.DragLeave += new System.EventHandler(this.fileBox_DragLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "File:";
            // 
            // slowerB
            // 
            this.slowerB.Location = new System.Drawing.Point(13, 19);
            this.slowerB.Name = "slowerB";
            this.slowerB.Size = new System.Drawing.Size(75, 23);
            this.slowerB.TabIndex = 12;
            this.slowerB.Text = "Slower";
            this.slowerB.UseVisualStyleBackColor = true;
            this.slowerB.Click += new System.EventHandler(this.slowerB_Click);
            // 
            // fasterB
            // 
            this.fasterB.Location = new System.Drawing.Point(142, 19);
            this.fasterB.Name = "fasterB";
            this.fasterB.Size = new System.Drawing.Size(75, 23);
            this.fasterB.TabIndex = 13;
            this.fasterB.Text = "Faster";
            this.fasterB.UseVisualStyleBackColor = true;
            this.fasterB.Click += new System.EventHandler(this.fasterB_Click);
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(101, 24);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(28, 13);
            this.speedLbl.TabIndex = 14;
            this.speedLbl.Text = "1.00";
            // 
            // s05B
            // 
            this.s05B.Location = new System.Drawing.Point(13, 48);
            this.s05B.Name = "s05B";
            this.s05B.Size = new System.Drawing.Size(36, 23);
            this.s05B.TabIndex = 15;
            this.s05B.Text = "0.50";
            this.s05B.UseVisualStyleBackColor = true;
            this.s05B.Click += new System.EventHandler(this.s05B_Click);
            // 
            // s075B
            // 
            this.s075B.Location = new System.Drawing.Point(55, 48);
            this.s075B.Name = "s075B";
            this.s075B.Size = new System.Drawing.Size(36, 23);
            this.s075B.TabIndex = 16;
            this.s075B.Text = "0.75";
            this.s075B.UseVisualStyleBackColor = true;
            this.s075B.Click += new System.EventHandler(this.s075B_Click);
            // 
            // s1B
            // 
            this.s1B.Location = new System.Drawing.Point(97, 48);
            this.s1B.Name = "s1B";
            this.s1B.Size = new System.Drawing.Size(36, 23);
            this.s1B.TabIndex = 17;
            this.s1B.Text = "1.00";
            this.s1B.UseVisualStyleBackColor = true;
            this.s1B.Click += new System.EventHandler(this.s1B_Click);
            // 
            // s125B
            // 
            this.s125B.Location = new System.Drawing.Point(139, 48);
            this.s125B.Name = "s125B";
            this.s125B.Size = new System.Drawing.Size(36, 23);
            this.s125B.TabIndex = 18;
            this.s125B.Text = "1.25";
            this.s125B.UseVisualStyleBackColor = true;
            this.s125B.Click += new System.EventHandler(this.s125B_Click);
            // 
            // s15B
            // 
            this.s15B.Location = new System.Drawing.Point(181, 48);
            this.s15B.Name = "s15B";
            this.s15B.Size = new System.Drawing.Size(36, 23);
            this.s15B.TabIndex = 19;
            this.s15B.Text = "1.50";
            this.s15B.UseVisualStyleBackColor = true;
            this.s15B.Click += new System.EventHandler(this.s15B_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slowerB);
            this.groupBox1.Controls.Add(this.s15B);
            this.groupBox1.Controls.Add(this.fasterB);
            this.groupBox1.Controls.Add(this.s125B);
            this.groupBox1.Controls.Add(this.speedLbl);
            this.groupBox1.Controls.Add(this.s1B);
            this.groupBox1.Controls.Add(this.s05B);
            this.groupBox1.Controls.Add(this.s075B);
            this.groupBox1.Location = new System.Drawing.Point(15, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 83);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // min30B
            // 
            this.min30B.Location = new System.Drawing.Point(15, 100);
            this.min30B.Name = "min30B";
            this.min30B.Size = new System.Drawing.Size(53, 25);
            this.min30B.TabIndex = 21;
            this.min30B.Text = "-30s";
            this.min30B.UseVisualStyleBackColor = true;
            this.min30B.Click += new System.EventHandler(this.min30B_Click);
            // 
            // min10B
            // 
            this.min10B.Location = new System.Drawing.Point(74, 100);
            this.min10B.Name = "min10B";
            this.min10B.Size = new System.Drawing.Size(53, 25);
            this.min10B.TabIndex = 22;
            this.min10B.Text = "-10s";
            this.min10B.UseVisualStyleBackColor = true;
            this.min10B.Click += new System.EventHandler(this.min10B_Click);
            // 
            // plus10B
            // 
            this.plus10B.Location = new System.Drawing.Point(133, 100);
            this.plus10B.Name = "plus10B";
            this.plus10B.Size = new System.Drawing.Size(53, 25);
            this.plus10B.TabIndex = 23;
            this.plus10B.Text = "+10s";
            this.plus10B.UseVisualStyleBackColor = true;
            this.plus10B.Click += new System.EventHandler(this.plus10B_Click);
            // 
            // plus30B
            // 
            this.plus30B.Location = new System.Drawing.Point(192, 100);
            this.plus30B.Name = "plus30B";
            this.plus30B.Size = new System.Drawing.Size(53, 25);
            this.plus30B.TabIndex = 24;
            this.plus30B.Text = "+30s";
            this.plus30B.UseVisualStyleBackColor = true;
            this.plus30B.Click += new System.EventHandler(this.plus30B_Click);
            // 
            // fileOpenB
            // 
            this.fileOpenB.Location = new System.Drawing.Point(218, 9);
            this.fileOpenB.Name = "fileOpenB";
            this.fileOpenB.Size = new System.Drawing.Size(27, 25);
            this.fileOpenB.TabIndex = 25;
            this.fileOpenB.Text = "...";
            this.fileOpenB.UseVisualStyleBackColor = true;
            this.fileOpenB.Click += new System.EventHandler(this.fileOpenB_Click);
            // 
            // clearStartB
            // 
            this.clearStartB.Location = new System.Drawing.Point(197, 36);
            this.clearStartB.Name = "clearStartB";
            this.clearStartB.Size = new System.Drawing.Size(48, 23);
            this.clearStartB.TabIndex = 26;
            this.clearStartB.Text = "Clear";
            this.clearStartB.UseVisualStyleBackColor = true;
            this.clearStartB.Click += new System.EventHandler(this.clearStartB_Click);
            // 
            // clearEndB
            // 
            this.clearEndB.Location = new System.Drawing.Point(196, 62);
            this.clearEndB.Name = "clearEndB";
            this.clearEndB.Size = new System.Drawing.Size(48, 23);
            this.clearEndB.TabIndex = 27;
            this.clearEndB.Text = "Clear";
            this.clearEndB.UseVisualStyleBackColor = true;
            this.clearEndB.Click += new System.EventHandler(this.clearEndB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 298);
            this.Controls.Add(this.clearEndB);
            this.Controls.Add(this.clearStartB);
            this.Controls.Add(this.fileOpenB);
            this.Controls.Add(this.plus30B);
            this.Controls.Add(this.plus10B);
            this.Controls.Add(this.min10B);
            this.Controls.Add(this.min30B);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setEndB);
            this.Controls.Add(this.setStartB);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.PauseB);
            this.Controls.Add(this.startB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SharpLooper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button PauseB;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button setStartB;
        private System.Windows.Forms.Button setEndB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.TextBox endBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button slowerB;
        private System.Windows.Forms.Button fasterB;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.Button s05B;
        private System.Windows.Forms.Button s075B;
        private System.Windows.Forms.Button s1B;
        private System.Windows.Forms.Button s125B;
        private System.Windows.Forms.Button s15B;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button min30B;
        private System.Windows.Forms.Button min10B;
        private System.Windows.Forms.Button plus10B;
        private System.Windows.Forms.Button plus30B;
        private System.Windows.Forms.Button fileOpenB;
        private System.Windows.Forms.Button clearStartB;
        private System.Windows.Forms.Button clearEndB;
    }
}

