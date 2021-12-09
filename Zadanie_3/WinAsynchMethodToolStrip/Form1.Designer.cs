﻿
namespace WinAsynchMethod
{
    partial class Form1
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
            this.btnRUN = new System.Windows.Forms.Button();
            this.btnWORK = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnRUN
            // 
            this.helpProvider1.SetHelpString(this.btnRUN, "Sum");
            this.btnRUN.Location = new System.Drawing.Point(16, 64);
            this.btnRUN.Name = "btnRUN";
            this.helpProvider1.SetShowHelp(this.btnRUN, true);
            this.btnRUN.Size = new System.Drawing.Size(75, 23);
            this.btnRUN.TabIndex = 0;
            this.btnRUN.Text = "Сумма";
            this.toolTip1.SetToolTip(this.btnRUN, "Sum");
            this.btnRUN.UseVisualStyleBackColor = true;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // btnWORK
            // 
            this.helpProvider1.SetHelpString(this.btnWORK, "Start work");
            this.btnWORK.Location = new System.Drawing.Point(120, 128);
            this.btnWORK.Name = "btnWORK";
            this.helpProvider1.SetShowHelp(this.btnWORK, true);
            this.btnWORK.Size = new System.Drawing.Size(75, 23);
            this.btnWORK.TabIndex = 1;
            this.btnWORK.Text = "Работа";
            this.toolTip1.SetToolTip(this.btnWORK, "Start work");
            this.btnWORK.UseVisualStyleBackColor = true;
            this.btnWORK.Click += new System.EventHandler(this.btnWORK_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(8, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Значение A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(216, 24);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(65, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Значение B";
            // 
            // txbA
            // 
            this.helpProvider1.SetHelpString(this.txbA, "For input integer A");
            this.txbA.Location = new System.Drawing.Point(88, 24);
            this.txbA.Name = "txbA";
            this.helpProvider1.SetShowHelp(this.txbA, true);
            this.txbA.Size = new System.Drawing.Size(100, 20);
            this.txbA.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txbA, "For input integer A");
            // 
            // txbB
            // 
            this.helpProvider1.SetHelpString(this.txbB, "For input integer B");
            this.txbB.Location = new System.Drawing.Point(296, 24);
            this.txbB.Name = "txbB";
            this.helpProvider1.SetShowHelp(this.txbB, true);
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txbB, "For input integer B");
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Студент\\Documents\\GitHub\\PraktikaPM01\\WinAsynchMethodHelp\\Справка.docx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnWORK);
            this.Controls.Add(this.btnRUN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Асинхронный запуск";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRUN;
        private System.Windows.Forms.Button btnWORK;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

