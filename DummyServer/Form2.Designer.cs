namespace DummyServer
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.racersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceGroupInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.racersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raceGroupInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.BibNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.racersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceGroupInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceGroupInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Observers";
            // 
            // racersBindingSource
            // 
            this.racersBindingSource.DataMember = "racers";
            this.racersBindingSource.DataSource = this.raceGroupInfoBindingSource;
            // 
            // raceGroupInfoBindingSource
            // 
            this.raceGroupInfoBindingSource.DataSource = typeof(DummyServer.RaceGroupInfo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Racers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Observer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.create_Observer);
            // 
            // racersBindingSource1
            // 
            this.racersBindingSource1.DataMember = "racers";
            this.racersBindingSource1.DataSource = this.raceGroupInfoBindingSource1;
            // 
            // raceGroupInfoBindingSource1
            // 
            this.raceGroupInfoBindingSource1.DataSource = typeof(DummyServer.RaceGroupInfo);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BibNumber,
            this.NameColumn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(478, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 256);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BibNumber
            // 
            this.BibNumber.DisplayIndex = 1;
            this.BibNumber.Text = "Bib";
            this.BibNumber.Width = 87;
            // 
            // NameColumn
            // 
            this.NameColumn.DisplayIndex = 0;
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 164;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceGroupInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceGroupInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource racersBindingSource;
        private System.Windows.Forms.BindingSource raceGroupInfoBindingSource;
        private System.Windows.Forms.BindingSource racersBindingSource1;
        private System.Windows.Forms.BindingSource raceGroupInfoBindingSource1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BibNumber;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}