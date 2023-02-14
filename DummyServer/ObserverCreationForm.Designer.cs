namespace DummyServer
{
    partial class ObserverCreationForm
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
            this.creaetionButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.cheaterRadioButton = new System.Windows.Forms.RadioButton();
            this.bigScreenRadioButton = new System.Windows.Forms.RadioButton();
            this.typeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // creaetionButton
            // 
            this.creaetionButton.Location = new System.Drawing.Point(444, 112);
            this.creaetionButton.Margin = new System.Windows.Forms.Padding(4);
            this.creaetionButton.Name = "creaetionButton";
            this.creaetionButton.Size = new System.Drawing.Size(100, 28);
            this.creaetionButton.TabIndex = 0;
            this.creaetionButton.Text = "Create Observer";
            this.creaetionButton.UseVisualStyleBackColor = true;
            this.creaetionButton.Click += new System.EventHandler(this.creaetionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(27, 112);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(23, 84);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 16);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(71, 80);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(472, 22);
            this.titleTextBox.TabIndex = 3;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.cheaterRadioButton);
            this.typeGroupBox.Controls.Add(this.bigScreenRadioButton);
            this.typeGroupBox.Location = new System.Drawing.Point(27, 16);
            this.typeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.typeGroupBox.Size = new System.Drawing.Size(516, 57);
            this.typeGroupBox.TabIndex = 4;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Observer Type";
            // 
            // cheaterRadioButton
            // 
            this.cheaterRadioButton.AutoSize = true;
            this.cheaterRadioButton.Location = new System.Drawing.Point(144, 23);
            this.cheaterRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.cheaterRadioButton.Name = "cheaterRadioButton";
            this.cheaterRadioButton.Size = new System.Drawing.Size(124, 20);
            this.cheaterRadioButton.TabIndex = 1;
            this.cheaterRadioButton.TabStop = true;
            this.cheaterRadioButton.Text = "Cheater Display";
            this.cheaterRadioButton.UseVisualStyleBackColor = true;
            this.cheaterRadioButton.CheckedChanged += new System.EventHandler(this.graphicalTypeRadioButton_CheckedChanged);
            // 
            // bigScreenRadioButton
            // 
            this.bigScreenRadioButton.AutoSize = true;
            this.bigScreenRadioButton.Checked = true;
            this.bigScreenRadioButton.Location = new System.Drawing.Point(8, 23);
            this.bigScreenRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.bigScreenRadioButton.Name = "bigScreenRadioButton";
            this.bigScreenRadioButton.Size = new System.Drawing.Size(94, 20);
            this.bigScreenRadioButton.TabIndex = 0;
            this.bigScreenRadioButton.TabStop = true;
            this.bigScreenRadioButton.Text = "Big Screen";
            this.bigScreenRadioButton.UseVisualStyleBackColor = true;
            this.bigScreenRadioButton.CheckedChanged += new System.EventHandler(this.listTypeRadioButton_CheckedChanged);
            // 
            // ObserverCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 213);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.creaetionButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ObserverCreationForm";
            this.Text = "ObserverCreationForm";
            this.Load += new System.EventHandler(this.ObserverCreationForm_Load);
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creaetionButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton cheaterRadioButton;
        private System.Windows.Forms.RadioButton bigScreenRadioButton;
    }
}