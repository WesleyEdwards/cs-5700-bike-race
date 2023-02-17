namespace DummyServer
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
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.racersTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(644, 219);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(161, 56);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Groups.csv Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Racers.csv Path:";
            // 
            // groupsTextBox
            // 
            this.groupsTextBox.Location = new System.Drawing.Point(196, 96);
            this.groupsTextBox.Name = "groupsTextBox";
            this.groupsTextBox.Size = new System.Drawing.Size(609, 22);
            this.groupsTextBox.TabIndex = 4;
            this.groupsTextBox.Text = "C:\\Users\\User\\Documents\\wesley\\random\\cs-5700-bike-race\\Groups.csv";
            this.groupsTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.groupsTextBox_MaskInputRejected);
            // 
            // racersTextBox
            // 
            this.racersTextBox.Location = new System.Drawing.Point(196, 167);
            this.racersTextBox.Name = "racersTextBox";
            this.racersTextBox.Size = new System.Drawing.Size(609, 22);
            this.racersTextBox.TabIndex = 5;
            this.racersTextBox.Text = "C:\\Users\\User\\Documents\\wesley\\random\\cs-5700-bike-race\\Racers.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 413);
            this.Controls.Add(this.racersTextBox);
            this.Controls.Add(this.groupsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox groupsTextBox;
        private System.Windows.Forms.MaskedTextBox racersTextBox;
    }
}