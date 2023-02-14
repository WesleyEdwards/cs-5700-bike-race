namespace DummyServer
{
    partial class ControlForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.otherBallsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.otherBallLabel = new System.Windows.Forms.Label();
            this.observersLabel = new System.Windows.Forms.Label();
            this.observedBallsLabel = new System.Windows.Forms.Label();
            this.observedBallsListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.observersListView = new System.Windows.Forms.ListView();
            this.unscribeButton = new System.Windows.Forms.Button();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.createObserverButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(880, 394);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // otherBallsListView
            // 
            this.otherBallsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.otherBallsListView.FullRowSelect = true;
            this.otherBallsListView.HideSelection = false;
            this.otherBallsListView.Location = new System.Drawing.Point(700, 53);
            this.otherBallsListView.Margin = new System.Windows.Forms.Padding(4);
            this.otherBallsListView.Name = "otherBallsListView";
            this.otherBallsListView.Size = new System.Drawing.Size(279, 330);
            this.otherBallsListView.TabIndex = 1;
            this.otherBallsListView.UseCompatibleStateImageBehavior = false;
            this.otherBallsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bib";
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 250;
            // 
            // otherBallLabel
            // 
            this.otherBallLabel.AutoSize = true;
            this.otherBallLabel.Location = new System.Drawing.Point(696, 32);
            this.otherBallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otherBallLabel.Name = "otherBallLabel";
            this.otherBallLabel.Size = new System.Drawing.Size(75, 16);
            this.otherBallLabel.TabIndex = 2;
            this.otherBallLabel.Text = "Other Balls:";
            // 
            // observersLabel
            // 
            this.observersLabel.AutoSize = true;
            this.observersLabel.Location = new System.Drawing.Point(16, 32);
            this.observersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observersLabel.Name = "observersLabel";
            this.observersLabel.Size = new System.Drawing.Size(73, 16);
            this.observersLabel.TabIndex = 3;
            this.observersLabel.Text = "Observers:";
            // 
            // observedBallsLabel
            // 
            this.observedBallsLabel.AutoSize = true;
            this.observedBallsLabel.Location = new System.Drawing.Point(323, 32);
            this.observedBallsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observedBallsLabel.Name = "observedBallsLabel";
            this.observedBallsLabel.Size = new System.Drawing.Size(99, 16);
            this.observedBallsLabel.TabIndex = 5;
            this.observedBallsLabel.Text = "Subscribed To:";
            // 
            // observedBallsListView
            // 
            this.observedBallsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.observedBallsListView.FullRowSelect = true;
            this.observedBallsListView.HideSelection = false;
            this.observedBallsListView.Location = new System.Drawing.Point(327, 55);
            this.observedBallsListView.Margin = new System.Windows.Forms.Padding(4);
            this.observedBallsListView.Name = "observedBallsListView";
            this.observedBallsListView.Size = new System.Drawing.Size(279, 330);
            this.observedBallsListView.TabIndex = 6;
            this.observedBallsListView.UseCompatibleStateImageBehavior = false;
            this.observedBallsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bib";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // observersListView
            // 
            this.observersListView.HideSelection = false;
            this.observersListView.Location = new System.Drawing.Point(16, 53);
            this.observersListView.Margin = new System.Windows.Forms.Padding(4);
            this.observersListView.MultiSelect = false;
            this.observersListView.Name = "observersListView";
            this.observersListView.Size = new System.Drawing.Size(261, 333);
            this.observersListView.TabIndex = 7;
            this.observersListView.UseCompatibleStateImageBehavior = false;
            this.observersListView.View = System.Windows.Forms.View.List;
            this.observersListView.SelectedIndexChanged += new System.EventHandler(this.observersListView_SelectedIndexChanged);
            // 
            // unscribeButton
            // 
            this.unscribeButton.Location = new System.Drawing.Point(627, 201);
            this.unscribeButton.Margin = new System.Windows.Forms.Padding(4);
            this.unscribeButton.Name = "unscribeButton";
            this.unscribeButton.Size = new System.Drawing.Size(55, 28);
            this.unscribeButton.TabIndex = 8;
            this.unscribeButton.Text = ">";
            this.unscribeButton.UseVisualStyleBackColor = true;
            this.unscribeButton.Click += new System.EventHandler(this.unscribeButton_Click);
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(627, 158);
            this.subscribeButton.Margin = new System.Windows.Forms.Padding(4);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(55, 28);
            this.subscribeButton.TabIndex = 9;
            this.subscribeButton.Text = "<";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // createObserverButton
            // 
            this.createObserverButton.Location = new System.Drawing.Point(16, 394);
            this.createObserverButton.Margin = new System.Windows.Forms.Padding(4);
            this.createObserverButton.Name = "createObserverButton";
            this.createObserverButton.Size = new System.Drawing.Size(100, 28);
            this.createObserverButton.TabIndex = 11;
            this.createObserverButton.Text = "Create";
            this.createObserverButton.UseVisualStyleBackColor = true;
            this.createObserverButton.Click += new System.EventHandler(this.createObserverButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create a Ball";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createBallButton_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createObserverButton);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.unscribeButton);
            this.Controls.Add(this.observersListView);
            this.Controls.Add(this.observedBallsListView);
            this.Controls.Add(this.observedBallsLabel);
            this.Controls.Add(this.observersLabel);
            this.Controls.Add(this.otherBallLabel);
            this.Controls.Add(this.otherBallsListView);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlForm_FormClosed);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView otherBallsListView;
        private System.Windows.Forms.Label otherBallLabel;
        private System.Windows.Forms.Label observersLabel;
        private System.Windows.Forms.Label observedBallsLabel;
        private System.Windows.Forms.ListView observedBallsListView;
        private System.Windows.Forms.ListView observersListView;
        private System.Windows.Forms.Button unscribeButton;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.Button createObserverButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
    }
}