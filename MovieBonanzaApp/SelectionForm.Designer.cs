namespace MovieBonanzaApp
{
    partial class SelectionForm
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
            this.SelectFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectionFormLabel = new System.Windows.Forms.Label();
            this.CurrentMoviesTextBox = new System.Windows.Forms.Label();
            this.MovieDropDownList = new System.Windows.Forms.ComboBox();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.GroupBoxTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MovieCostTextBox = new System.Windows.Forms.TextBox();
            this.MovieCategoryTextBox = new System.Windows.Forms.TextBox();
            this.MovieCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.MovieCategoryLabel = new System.Windows.Forms.Label();
            this.MovieCostLabel = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectFormTableLayoutPanel.SuspendLayout();
            this.YourSelectionGroupBox.SuspendLayout();
            this.GroupBoxTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieCoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFormTableLayoutPanel
            // 
            this.SelectFormTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFormTableLayoutPanel.ColumnCount = 2;
            this.SelectFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.53572F));
            this.SelectFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.46429F));
            this.SelectFormTableLayoutPanel.Controls.Add(this.SelectionFormLabel, 0, 0);
            this.SelectFormTableLayoutPanel.Controls.Add(this.CurrentMoviesTextBox, 0, 1);
            this.SelectFormTableLayoutPanel.Controls.Add(this.MovieDropDownList, 0, 2);
            this.SelectFormTableLayoutPanel.Controls.Add(this.YourSelectionGroupBox, 1, 2);
            this.SelectFormTableLayoutPanel.Controls.Add(this.NextButton, 1, 3);
            this.SelectFormTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.SelectFormTableLayoutPanel.Name = "SelectFormTableLayoutPanel";
            this.SelectFormTableLayoutPanel.RowCount = 4;
            this.SelectFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.171597F));
            this.SelectFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.39645F));
            this.SelectFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.55621F));
            this.SelectFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.467456F));
            this.SelectFormTableLayoutPanel.Size = new System.Drawing.Size(560, 338);
            this.SelectFormTableLayoutPanel.TabIndex = 0;
            // 
            // SelectionFormLabel
            // 
            this.SelectionFormLabel.AutoSize = true;
            this.SelectFormTableLayoutPanel.SetColumnSpan(this.SelectionFormLabel, 2);
            this.SelectionFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionFormLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectionFormLabel.Name = "SelectionFormLabel";
            this.SelectionFormLabel.Size = new System.Drawing.Size(342, 13);
            this.SelectionFormLabel.TabIndex = 0;
            this.SelectionFormLabel.Text = "Choose the movie you wish to STREAM from the list below.";
            // 
            // CurrentMoviesTextBox
            // 
            this.CurrentMoviesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentMoviesTextBox.AutoSize = true;
            this.CurrentMoviesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMoviesTextBox.Location = new System.Drawing.Point(39, 35);
            this.CurrentMoviesTextBox.Name = "CurrentMoviesTextBox";
            this.CurrentMoviesTextBox.Size = new System.Drawing.Size(92, 13);
            this.CurrentMoviesTextBox.TabIndex = 1;
            this.CurrentMoviesTextBox.Text = "Current Movies";
            // 
            // MovieDropDownList
            // 
            this.MovieDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieDropDownList.FormattingEnabled = true;
            this.MovieDropDownList.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.MovieDropDownList.Location = new System.Drawing.Point(3, 57);
            this.MovieDropDownList.Name = "MovieDropDownList";
            this.MovieDropDownList.Size = new System.Drawing.Size(165, 21);
            this.MovieDropDownList.Sorted = true;
            this.MovieDropDownList.TabIndex = 2;
            this.MovieDropDownList.SelectedValueChanged += new System.EventHandler(this.MovieDropDownList_SelectedValueChanged);
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.GroupBoxTableLayoutPanel);
            this.YourSelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(174, 57);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(383, 234);
            this.YourSelectionGroupBox.TabIndex = 3;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // GroupBoxTableLayoutPanel
            // 
            this.GroupBoxTableLayoutPanel.ColumnCount = 2;
            this.GroupBoxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.3783F));
            this.GroupBoxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.6217F));
            this.GroupBoxTableLayoutPanel.Controls.Add(this.MovieCostTextBox, 1, 5);
            this.GroupBoxTableLayoutPanel.Controls.Add(this.MovieCategoryTextBox, 1, 3);
            this.GroupBoxTableLayoutPanel.Controls.Add(this.MovieCoverPictureBox, 0, 0);
            this.GroupBoxTableLayoutPanel.Controls.Add(this.MovieTitle, 1, 0);
            this.GroupBoxTableLayoutPanel.Controls.Add(this.MovieCategoryLabel, 1, 2);
            this.GroupBoxTableLayoutPanel.Controls.Add(this.MovieCostLabel, 1, 4);
            this.GroupBoxTableLayoutPanel.Controls.Add(this.MovieTitleTextBox, 1, 1);
            this.GroupBoxTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.GroupBoxTableLayoutPanel.Name = "GroupBoxTableLayoutPanel";
            this.GroupBoxTableLayoutPanel.RowCount = 7;
            this.GroupBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.GroupBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75F));
            this.GroupBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.GroupBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75F));
            this.GroupBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.GroupBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75F));
            this.GroupBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.75F));
            this.GroupBoxTableLayoutPanel.Size = new System.Drawing.Size(374, 212);
            this.GroupBoxTableLayoutPanel.TabIndex = 0;
            // 
            // MovieCostTextBox
            // 
            this.MovieCostTextBox.BackColor = System.Drawing.Color.White;
            this.MovieCostTextBox.ForeColor = System.Drawing.Color.Black;
            this.MovieCostTextBox.Location = new System.Drawing.Point(120, 114);
            this.MovieCostTextBox.Name = "MovieCostTextBox";
            this.MovieCostTextBox.ReadOnly = true;
            this.MovieCostTextBox.Size = new System.Drawing.Size(251, 20);
            this.MovieCostTextBox.TabIndex = 6;
            // 
            // MovieCategoryTextBox
            // 
            this.MovieCategoryTextBox.BackColor = System.Drawing.Color.White;
            this.MovieCategoryTextBox.ForeColor = System.Drawing.Color.Black;
            this.MovieCategoryTextBox.Location = new System.Drawing.Point(120, 68);
            this.MovieCategoryTextBox.Name = "MovieCategoryTextBox";
            this.MovieCategoryTextBox.ReadOnly = true;
            this.MovieCategoryTextBox.Size = new System.Drawing.Size(251, 20);
            this.MovieCategoryTextBox.TabIndex = 5;
            // 
            // MovieCoverPictureBox
            // 
            this.MovieCoverPictureBox.BackColor = System.Drawing.Color.White;
            this.MovieCoverPictureBox.Location = new System.Drawing.Point(3, 3);
            this.MovieCoverPictureBox.Name = "MovieCoverPictureBox";
            this.GroupBoxTableLayoutPanel.SetRowSpan(this.MovieCoverPictureBox, 6);
            this.MovieCoverPictureBox.Size = new System.Drawing.Size(111, 132);
            this.MovieCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MovieCoverPictureBox.TabIndex = 0;
            this.MovieCoverPictureBox.TabStop = false;
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Location = new System.Drawing.Point(120, 0);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(32, 13);
            this.MovieTitle.TabIndex = 1;
            this.MovieTitle.Text = "Title";
            // 
            // MovieCategoryLabel
            // 
            this.MovieCategoryLabel.AutoSize = true;
            this.MovieCategoryLabel.Location = new System.Drawing.Point(120, 46);
            this.MovieCategoryLabel.Name = "MovieCategoryLabel";
            this.MovieCategoryLabel.Size = new System.Drawing.Size(57, 13);
            this.MovieCategoryLabel.TabIndex = 2;
            this.MovieCategoryLabel.Text = "Category";
            // 
            // MovieCostLabel
            // 
            this.MovieCostLabel.AutoSize = true;
            this.MovieCostLabel.Location = new System.Drawing.Point(120, 92);
            this.MovieCostLabel.Name = "MovieCostLabel";
            this.MovieCostLabel.Size = new System.Drawing.Size(32, 13);
            this.MovieCostLabel.TabIndex = 3;
            this.MovieCostLabel.Text = "Cost";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.BackColor = System.Drawing.Color.White;
            this.MovieTitleTextBox.ForeColor = System.Drawing.Color.Black;
            this.MovieTitleTextBox.Location = new System.Drawing.Point(120, 22);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(251, 20);
            this.MovieTitleTextBox.TabIndex = 4;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(482, 312);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.ControlBox = false;
            this.Controls.Add(this.SelectFormTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a Movie";
            this.SelectFormTableLayoutPanel.ResumeLayout(false);
            this.SelectFormTableLayoutPanel.PerformLayout();
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.GroupBoxTableLayoutPanel.ResumeLayout(false);
            this.GroupBoxTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieCoverPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SelectFormTableLayoutPanel;
        private System.Windows.Forms.Label SelectionFormLabel;
        private System.Windows.Forms.Label CurrentMoviesTextBox;
        private System.Windows.Forms.ComboBox MovieDropDownList;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel GroupBoxTableLayoutPanel;
        private System.Windows.Forms.TextBox MovieCostTextBox;
        private System.Windows.Forms.TextBox MovieCategoryTextBox;
        private System.Windows.Forms.PictureBox MovieCoverPictureBox;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Label MovieCategoryLabel;
        private System.Windows.Forms.Label MovieCostLabel;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Button NextButton;
    }
}

