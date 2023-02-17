namespace DummyServer
{
    partial class ListDisplay
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
            this.ballListView = new System.Windows.Forms.ListView();
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.racerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sensorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cheater2ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ballListView
            // 
            this.ballListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.racerName,
            this.sensorId});
            this.ballListView.HideSelection = false;
            this.ballListView.Location = new System.Drawing.Point(32, 32);
            this.ballListView.Margin = new System.Windows.Forms.Padding(4);
            this.ballListView.Name = "ballListView";
            this.ballListView.Size = new System.Drawing.Size(463, 419);
            this.ballListView.TabIndex = 0;
            this.ballListView.UseCompatibleStateImageBehavior = false;
            this.ballListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "Bib";
            this.idColumnHeader.Width = 52;
            // 
            // racerName
            // 
            this.racerName.Text = "Name";
            this.racerName.Width = 120;
            // 
            // sensorId
            // 
            this.sensorId.Text = "Sensor Id";
            this.sensorId.Width = 111;
            // 
            // cheater2ListView
            // 
            this.cheater2ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.cheater2ListView.HideSelection = false;
            this.cheater2ListView.Location = new System.Drawing.Point(600, 32);
            this.cheater2ListView.Margin = new System.Windows.Forms.Padding(4);
            this.cheater2ListView.Name = "cheater2ListView";
            this.cheater2ListView.Size = new System.Drawing.Size(463, 419);
            this.cheater2ListView.TabIndex = 1;
            this.cheater2ListView.UseCompatibleStateImageBehavior = false;
            this.cheater2ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bib";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 282;
            // 
            // ListDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 494);
            this.Controls.Add(this.cheater2ListView);
            this.Controls.Add(this.ballListView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListDisplay";
            this.Text = "BallListDisplay";
            this.Load += new System.EventHandler(this.ListDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ballListView;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader racerName;
        private System.Windows.Forms.ColumnHeader sensorId;
        private System.Windows.Forms.ListView cheater2ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}