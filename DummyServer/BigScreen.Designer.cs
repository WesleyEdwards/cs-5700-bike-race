namespace DummyServer
{
    partial class BigScreen
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
            this.SuspendLayout();
            // 
            // ballListView
            // 
            this.ballListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.racerName});
            this.ballListView.HideSelection = false;
            this.ballListView.Location = new System.Drawing.Point(53, 16);
            this.ballListView.Margin = new System.Windows.Forms.Padding(4);
            this.ballListView.Name = "ballListView";
            this.ballListView.Size = new System.Drawing.Size(695, 419);
            this.ballListView.TabIndex = 1;
            this.ballListView.UseCompatibleStateImageBehavior = false;
            this.ballListView.View = System.Windows.Forms.View.Details;
            this.ballListView.SelectedIndexChanged += new System.EventHandler(this.ballListView_SelectedIndexChanged);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "Bib";
            this.idColumnHeader.Width = 52;
            // 
            // racerName
            // 
            this.racerName.Text = "Name";
            this.racerName.Width = 282;
            // 
            // Winners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ballListView);
            this.Name = "Winners";
            this.Text = "Winners";
            this.Load += new System.EventHandler(this.Winners_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ballListView;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader racerName;
    }
}