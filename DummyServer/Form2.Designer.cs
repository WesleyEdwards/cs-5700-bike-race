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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.racersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceGroupInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.racersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raceGroupInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BibNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(554, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 308);
            this.listBox1.TabIndex = 1;
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
            this.listView1.Location = new System.Drawing.Point(22, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 256);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.DisplayIndex = 0;
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 79;
            // 
            // BibNumber
            // 
            this.BibNumber.DisplayIndex = 1;
            this.BibNumber.Text = "Bib Number";
            this.BibNumber.Width = 87;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource racersBindingSource;
        private System.Windows.Forms.BindingSource raceGroupInfoBindingSource;
        private System.Windows.Forms.BindingSource racersBindingSource1;
        private System.Windows.Forms.BindingSource raceGroupInfoBindingSource1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BibNumber;
        private System.Windows.Forms.ColumnHeader NameColumn;
    }
}