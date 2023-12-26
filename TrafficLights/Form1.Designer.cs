namespace TrafficLights
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            radioButtonAuto = new RadioButton();
            radioButtonManual = new RadioButton();
            groupBox2 = new GroupBox();
            textBoxGreenLight = new TextBox();
            label3 = new Label();
            textBoxYellowLight = new TextBox();
            label2 = new Label();
            textBoxRedLight = new TextBox();
            label1 = new Label();
            buttonStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 383);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonAuto);
            groupBox1.Controls.Add(radioButtonManual);
            groupBox1.Location = new Point(241, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 84);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Режим роботи";
            // 
            // radioButtonAuto
            // 
            radioButtonAuto.AutoSize = true;
            radioButtonAuto.Location = new Point(16, 46);
            radioButtonAuto.Name = "radioButtonAuto";
            radioButtonAuto.Size = new Size(106, 19);
            radioButtonAuto.TabIndex = 1;
            radioButtonAuto.TabStop = true;
            radioButtonAuto.Text = "Автоматичний";
            radioButtonAuto.UseVisualStyleBackColor = true;
            // 
            // radioButtonManual
            // 
            radioButtonManual.AutoSize = true;
            radioButtonManual.Location = new Point(16, 21);
            radioButtonManual.Name = "radioButtonManual";
            radioButtonManual.Size = new Size(66, 19);
            radioButtonManual.TabIndex = 0;
            radioButtonManual.TabStop = true;
            radioButtonManual.Text = "Ручний";
            radioButtonManual.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxGreenLight);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxYellowLight);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxRedLight);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(241, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 174);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Тривалість сигналів";
            // 
            // textBoxGreenLight
            // 
            textBoxGreenLight.Location = new Point(6, 135);
            textBoxGreenLight.Name = "textBoxGreenLight";
            textBoxGreenLight.Size = new Size(100, 23);
            textBoxGreenLight.TabIndex = 5;
            textBoxGreenLight.Text = "3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 117);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Зелений";
            // 
            // textBoxYellowLight
            // 
            textBoxYellowLight.Location = new Point(6, 91);
            textBoxYellowLight.Name = "textBoxYellowLight";
            textBoxYellowLight.Size = new Size(100, 23);
            textBoxYellowLight.TabIndex = 3;
            textBoxYellowLight.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Жовтий";
            // 
            // textBoxRedLight
            // 
            textBoxRedLight.Location = new Point(6, 47);
            textBoxRedLight.Name = "textBoxRedLight";
            textBoxRedLight.Size = new Size(100, 23);
            textBoxRedLight.TabIndex = 1;
            textBoxRedLight.Text = "5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Червоний";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(272, 359);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Пуск";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 407);
            Controls.Add(buttonStart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Світлофор";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton radioButtonAuto;
        private RadioButton radioButtonManual;
        private GroupBox groupBox2;
        private TextBox textBoxRedLight;
        private Label label1;
        private TextBox textBoxGreenLight;
        private Label label3;
        private TextBox textBoxYellowLight;
        private Label label2;
        private Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}