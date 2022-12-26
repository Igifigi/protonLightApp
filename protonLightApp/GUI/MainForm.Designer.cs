
namespace protonLightApp
{
    partial class MainForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.RankingPage = new System.Windows.Forms.TabPage();
            this.RankingPageTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ClassRankingListBox = new System.Windows.Forms.ListBox();
            this.IndividualRankingListBox = new System.Windows.Forms.ListBox();
            this.TableLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfPositionsToDisplayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TableLayout3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.TableLayout4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateRankingPDFButton = new System.Windows.Forms.Button();
            this.SelectSexComboBox = new System.Windows.Forms.ComboBox();
            this.EventsPage = new System.Windows.Forms.TabPage();
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.ManagementPage = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.RankingPage.SuspendLayout();
            this.RankingPageTableLayout.SuspendLayout();
            this.TableLayout1.SuspendLayout();
            this.TableLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPositionsToDisplayNumericUpDown)).BeginInit();
            this.TableLayout3.SuspendLayout();
            this.TableLayout4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.RankingPage);
            this.MainTabControl.Controls.Add(this.EventsPage);
            this.MainTabControl.Controls.Add(this.StudentsPage);
            this.MainTabControl.Controls.Add(this.ManagementPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1106, 961);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainTabControl.TabIndex = 0;
            // 
            // RankingPage
            // 
            this.RankingPage.Controls.Add(this.RankingPageTableLayout);
            this.RankingPage.Location = new System.Drawing.Point(4, 29);
            this.RankingPage.Name = "RankingPage";
            this.RankingPage.Padding = new System.Windows.Forms.Padding(3);
            this.RankingPage.Size = new System.Drawing.Size(1098, 928);
            this.RankingPage.TabIndex = 0;
            this.RankingPage.Text = "Ranking";
            this.RankingPage.UseVisualStyleBackColor = true;
            // 
            // RankingPageTableLayout
            // 
            this.RankingPageTableLayout.ColumnCount = 2;
            this.RankingPageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RankingPageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RankingPageTableLayout.Controls.Add(this.ClassRankingListBox, 1, 1);
            this.RankingPageTableLayout.Controls.Add(this.IndividualRankingListBox, 0, 1);
            this.RankingPageTableLayout.Controls.Add(this.TableLayout1, 0, 0);
            this.RankingPageTableLayout.Controls.Add(this.TableLayout3, 1, 0);
            this.RankingPageTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankingPageTableLayout.Location = new System.Drawing.Point(3, 3);
            this.RankingPageTableLayout.Name = "RankingPageTableLayout";
            this.RankingPageTableLayout.RowCount = 2;
            this.RankingPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.RankingPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RankingPageTableLayout.Size = new System.Drawing.Size(1092, 922);
            this.RankingPageTableLayout.TabIndex = 0;
            // 
            // ClassRankingListBox
            // 
            this.ClassRankingListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassRankingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClassRankingListBox.FormattingEnabled = true;
            this.ClassRankingListBox.ItemHeight = 20;
            this.ClassRankingListBox.Location = new System.Drawing.Point(549, 123);
            this.ClassRankingListBox.Name = "ClassRankingListBox";
            this.ClassRankingListBox.Size = new System.Drawing.Size(540, 796);
            this.ClassRankingListBox.TabIndex = 6;
            // 
            // IndividualRankingListBox
            // 
            this.IndividualRankingListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndividualRankingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IndividualRankingListBox.FormattingEnabled = true;
            this.IndividualRankingListBox.ItemHeight = 20;
            this.IndividualRankingListBox.Location = new System.Drawing.Point(3, 123);
            this.IndividualRankingListBox.Name = "IndividualRankingListBox";
            this.IndividualRankingListBox.Size = new System.Drawing.Size(540, 796);
            this.IndividualRankingListBox.TabIndex = 5;
            // 
            // TableLayout1
            // 
            this.TableLayout1.ColumnCount = 1;
            this.TableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout1.Controls.Add(this.TableLayout2, 0, 0);
            this.TableLayout1.Controls.Add(this.label2, 0, 1);
            this.TableLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout1.Location = new System.Drawing.Point(3, 3);
            this.TableLayout1.Name = "TableLayout1";
            this.TableLayout1.RowCount = 2;
            this.TableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayout1.Size = new System.Drawing.Size(540, 114);
            this.TableLayout1.TabIndex = 0;
            // 
            // TableLayout2
            // 
            this.TableLayout2.ColumnCount = 3;
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayout2.Controls.Add(this.RefreshButton, 0, 0);
            this.TableLayout2.Controls.Add(this.label1, 1, 0);
            this.TableLayout2.Controls.Add(this.NumberOfPositionsToDisplayNumericUpDown, 2, 0);
            this.TableLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout2.Location = new System.Drawing.Point(3, 3);
            this.TableLayout2.Name = "TableLayout2";
            this.TableLayout2.RowCount = 1;
            this.TableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout2.Size = new System.Drawing.Size(534, 62);
            this.TableLayout2.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshButton.Location = new System.Drawing.Point(3, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(215, 56);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Odśwież";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(225, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba pozycji do wyświetlenia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfPositionsToDisplayNumericUpDown
            // 
            this.NumberOfPositionsToDisplayNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfPositionsToDisplayNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfPositionsToDisplayNumericUpDown.Location = new System.Drawing.Point(454, 18);
            this.NumberOfPositionsToDisplayNumericUpDown.Name = "NumberOfPositionsToDisplayNumericUpDown";
            this.NumberOfPositionsToDisplayNumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.NumberOfPositionsToDisplayNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 46);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ranking indywidualny";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayout3
            // 
            this.TableLayout3.ColumnCount = 1;
            this.TableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout3.Controls.Add(this.label4, 0, 1);
            this.TableLayout3.Controls.Add(this.TableLayout4, 0, 0);
            this.TableLayout3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout3.Location = new System.Drawing.Point(549, 3);
            this.TableLayout3.Name = "TableLayout3";
            this.TableLayout3.RowCount = 2;
            this.TableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayout3.Size = new System.Drawing.Size(540, 114);
            this.TableLayout3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(534, 46);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ranking klasowy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayout4
            // 
            this.TableLayout4.ColumnCount = 3;
            this.TableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayout4.Controls.Add(this.label3, 0, 0);
            this.TableLayout4.Controls.Add(this.CreateRankingPDFButton, 2, 0);
            this.TableLayout4.Controls.Add(this.SelectSexComboBox, 1, 0);
            this.TableLayout4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout4.Location = new System.Drawing.Point(3, 3);
            this.TableLayout4.Name = "TableLayout4";
            this.TableLayout4.RowCount = 1;
            this.TableLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout4.Size = new System.Drawing.Size(534, 62);
            this.TableLayout4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 56);
            this.label3.TabIndex = 37;
            this.label3.Text = "Płeć:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateRankingPDFButton
            // 
            this.CreateRankingPDFButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateRankingPDFButton.Location = new System.Drawing.Point(309, 3);
            this.CreateRankingPDFButton.Name = "CreateRankingPDFButton";
            this.CreateRankingPDFButton.Size = new System.Drawing.Size(222, 56);
            this.CreateRankingPDFButton.TabIndex = 0;
            this.CreateRankingPDFButton.Text = "Utwórz PDF";
            this.CreateRankingPDFButton.UseVisualStyleBackColor = true;
            // 
            // SelectSexComboBox
            // 
            this.SelectSexComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectSexComboBox.FormattingEnabled = true;
            this.SelectSexComboBox.Items.AddRange(new object[] {
            "Obie",
            "Chłopcy",
            "Dziewczyny"});
            this.SelectSexComboBox.Location = new System.Drawing.Point(53, 17);
            this.SelectSexComboBox.Name = "SelectSexComboBox";
            this.SelectSexComboBox.Size = new System.Drawing.Size(250, 28);
            this.SelectSexComboBox.TabIndex = 3;
            // 
            // EventsPage
            // 
            this.EventsPage.Location = new System.Drawing.Point(4, 29);
            this.EventsPage.Name = "EventsPage";
            this.EventsPage.Padding = new System.Windows.Forms.Padding(3);
            this.EventsPage.Size = new System.Drawing.Size(1098, 928);
            this.EventsPage.TabIndex = 1;
            this.EventsPage.Text = "Wydarzenia";
            this.EventsPage.UseVisualStyleBackColor = true;
            // 
            // StudentsPage
            // 
            this.StudentsPage.Location = new System.Drawing.Point(4, 29);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsPage.Size = new System.Drawing.Size(1098, 928);
            this.StudentsPage.TabIndex = 2;
            this.StudentsPage.Text = "Uczniowie";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // ManagementPage
            // 
            this.ManagementPage.Location = new System.Drawing.Point(4, 29);
            this.ManagementPage.Name = "ManagementPage";
            this.ManagementPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManagementPage.Size = new System.Drawing.Size(1098, 928);
            this.ManagementPage.TabIndex = 3;
            this.ManagementPage.Text = "Zarządzanie";
            this.ManagementPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 961);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainForm";
            this.Text = "Proton";
            this.MainTabControl.ResumeLayout(false);
            this.RankingPage.ResumeLayout(false);
            this.RankingPageTableLayout.ResumeLayout(false);
            this.TableLayout1.ResumeLayout(false);
            this.TableLayout2.ResumeLayout(false);
            this.TableLayout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPositionsToDisplayNumericUpDown)).EndInit();
            this.TableLayout3.ResumeLayout(false);
            this.TableLayout4.ResumeLayout(false);
            this.TableLayout4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage RankingPage;
        private System.Windows.Forms.TabPage EventsPage;
        private System.Windows.Forms.TableLayoutPanel RankingPageTableLayout;
        private System.Windows.Forms.ListBox ClassRankingListBox;
        private System.Windows.Forms.ListBox IndividualRankingListBox;
        private System.Windows.Forms.TableLayoutPanel TableLayout1;
        private System.Windows.Forms.TableLayoutPanel TableLayout2;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumberOfPositionsToDisplayNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel TableLayout3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel TableLayout4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateRankingPDFButton;
        private System.Windows.Forms.ComboBox SelectSexComboBox;
        private System.Windows.Forms.TabPage StudentsPage;
        private System.Windows.Forms.TabPage ManagementPage;
    }
}

