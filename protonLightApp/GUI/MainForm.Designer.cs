
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
            this.SelectGenderComboBox = new System.Windows.Forms.ComboBox();
            this.EventsPage = new System.Windows.Forms.TabPage();
            this.TableLayout5 = new System.Windows.Forms.TableLayoutPanel();
            this.EventsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TableLayout6 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteEventButton = new System.Windows.Forms.Button();
            this.EditEventButton = new System.Windows.Forms.Button();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.RefreshEventsButton = new System.Windows.Forms.Button();
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.RefreshStudentsButton = new System.Windows.Forms.Button();
            this.ManagementPage = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.RankingPage.SuspendLayout();
            this.RankingPageTableLayout.SuspendLayout();
            this.TableLayout1.SuspendLayout();
            this.TableLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPositionsToDisplayNumericUpDown)).BeginInit();
            this.TableLayout3.SuspendLayout();
            this.TableLayout4.SuspendLayout();
            this.EventsPage.SuspendLayout();
            this.TableLayout5.SuspendLayout();
            this.TableLayout6.SuspendLayout();
            this.StudentsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.MainTabControl.Size = new System.Drawing.Size(984, 611);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainTabControl.TabIndex = 0;
            // 
            // RankingPage
            // 
            this.RankingPage.Controls.Add(this.RankingPageTableLayout);
            this.RankingPage.Location = new System.Drawing.Point(8, 51);
            this.RankingPage.Name = "RankingPage";
            this.RankingPage.Padding = new System.Windows.Forms.Padding(3);
            this.RankingPage.Size = new System.Drawing.Size(968, 552);
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
            this.RankingPageTableLayout.Size = new System.Drawing.Size(962, 546);
            this.RankingPageTableLayout.TabIndex = 0;
            // 
            // ClassRankingListBox
            // 
            this.ClassRankingListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassRankingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClassRankingListBox.FormattingEnabled = true;
            this.ClassRankingListBox.ItemHeight = 37;
            this.ClassRankingListBox.Location = new System.Drawing.Point(484, 123);
            this.ClassRankingListBox.Name = "ClassRankingListBox";
            this.ClassRankingListBox.Size = new System.Drawing.Size(475, 420);
            this.ClassRankingListBox.TabIndex = 6;
            // 
            // IndividualRankingListBox
            // 
            this.IndividualRankingListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndividualRankingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IndividualRankingListBox.FormattingEnabled = true;
            this.IndividualRankingListBox.ItemHeight = 37;
            this.IndividualRankingListBox.Location = new System.Drawing.Point(3, 123);
            this.IndividualRankingListBox.Name = "IndividualRankingListBox";
            this.IndividualRankingListBox.Size = new System.Drawing.Size(475, 420);
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
            this.TableLayout1.Size = new System.Drawing.Size(475, 114);
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
            this.TableLayout2.Size = new System.Drawing.Size(469, 62);
            this.TableLayout2.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshButton.Location = new System.Drawing.Point(3, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(161, 56);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Odśwież";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(178, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba pozycji do wyświetlenia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfPositionsToDisplayNumericUpDown
            // 
            this.NumberOfPositionsToDisplayNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfPositionsToDisplayNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfPositionsToDisplayNumericUpDown.Location = new System.Drawing.Point(400, 9);
            this.NumberOfPositionsToDisplayNumericUpDown.Name = "NumberOfPositionsToDisplayNumericUpDown";
            this.NumberOfPositionsToDisplayNumericUpDown.Size = new System.Drawing.Size(66, 44);
            this.NumberOfPositionsToDisplayNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 46);
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
            this.TableLayout3.Location = new System.Drawing.Point(484, 3);
            this.TableLayout3.Name = "TableLayout3";
            this.TableLayout3.RowCount = 2;
            this.TableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayout3.Size = new System.Drawing.Size(475, 114);
            this.TableLayout3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 46);
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
            this.TableLayout4.Controls.Add(this.SelectGenderComboBox, 1, 0);
            this.TableLayout4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout4.Location = new System.Drawing.Point(3, 3);
            this.TableLayout4.Name = "TableLayout4";
            this.TableLayout4.RowCount = 1;
            this.TableLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout4.Size = new System.Drawing.Size(469, 62);
            this.TableLayout4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 56);
            this.label3.TabIndex = 37;
            this.label3.Text = "Płeć:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateRankingPDFButton
            // 
            this.CreateRankingPDFButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateRankingPDFButton.Location = new System.Drawing.Point(220, 3);
            this.CreateRankingPDFButton.Name = "CreateRankingPDFButton";
            this.CreateRankingPDFButton.Size = new System.Drawing.Size(246, 56);
            this.CreateRankingPDFButton.TabIndex = 0;
            this.CreateRankingPDFButton.Text = "Utwórz PDF";
            this.CreateRankingPDFButton.UseVisualStyleBackColor = true;
            // 
            // SelectGenderComboBox
            // 
            this.SelectGenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectGenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectGenderComboBox.FormattingEnabled = true;
            this.SelectGenderComboBox.Items.AddRange(new object[] {
            "Obie",
            "Chłopcy",
            "Dziewczyny"});
            this.SelectGenderComboBox.Location = new System.Drawing.Point(53, 8);
            this.SelectGenderComboBox.Name = "SelectGenderComboBox";
            this.SelectGenderComboBox.Size = new System.Drawing.Size(161, 45);
            this.SelectGenderComboBox.TabIndex = 3;
            // 
            // EventsPage
            // 
            this.EventsPage.Controls.Add(this.TableLayout5);
            this.EventsPage.Location = new System.Drawing.Point(8, 51);
            this.EventsPage.Name = "EventsPage";
            this.EventsPage.Padding = new System.Windows.Forms.Padding(3);
            this.EventsPage.Size = new System.Drawing.Size(968, 552);
            this.EventsPage.TabIndex = 1;
            this.EventsPage.Text = "Wydarzenia";
            this.EventsPage.UseVisualStyleBackColor = true;
            // 
            // TableLayout5
            // 
            this.TableLayout5.ColumnCount = 1;
            this.TableLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout5.Controls.Add(this.EventsCheckedListBox, 0, 1);
            this.TableLayout5.Controls.Add(this.TableLayout6, 0, 0);
            this.TableLayout5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout5.Location = new System.Drawing.Point(3, 3);
            this.TableLayout5.Name = "TableLayout5";
            this.TableLayout5.RowCount = 2;
            this.TableLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout5.Size = new System.Drawing.Size(962, 546);
            this.TableLayout5.TabIndex = 0;
            // 
            // EventsCheckedListBox
            // 
            this.EventsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EventsCheckedListBox.FormattingEnabled = true;
            this.EventsCheckedListBox.HorizontalScrollbar = true;
            this.EventsCheckedListBox.Location = new System.Drawing.Point(3, 103);
            this.EventsCheckedListBox.Name = "EventsCheckedListBox";
            this.EventsCheckedListBox.ScrollAlwaysVisible = true;
            this.EventsCheckedListBox.Size = new System.Drawing.Size(956, 440);
            this.EventsCheckedListBox.TabIndex = 1;
            // 
            // TableLayout6
            // 
            this.TableLayout6.ColumnCount = 4;
            this.TableLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout6.Controls.Add(this.DeleteEventButton, 0, 0);
            this.TableLayout6.Controls.Add(this.EditEventButton, 0, 0);
            this.TableLayout6.Controls.Add(this.AddEventButton, 0, 0);
            this.TableLayout6.Controls.Add(this.RefreshEventsButton, 3, 0);
            this.TableLayout6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout6.Location = new System.Drawing.Point(3, 3);
            this.TableLayout6.Name = "TableLayout6";
            this.TableLayout6.RowCount = 1;
            this.TableLayout6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout6.Size = new System.Drawing.Size(956, 94);
            this.TableLayout6.TabIndex = 0;
            // 
            // DeleteEventButton
            // 
            this.DeleteEventButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteEventButton.Enabled = false;
            this.DeleteEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteEventButton.Location = new System.Drawing.Point(481, 3);
            this.DeleteEventButton.Name = "DeleteEventButton";
            this.DeleteEventButton.Size = new System.Drawing.Size(233, 88);
            this.DeleteEventButton.TabIndex = 4;
            this.DeleteEventButton.Text = "Usuń wydarzenie";
            this.DeleteEventButton.UseVisualStyleBackColor = true;
            // 
            // EditEventButton
            // 
            this.EditEventButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditEventButton.Enabled = false;
            this.EditEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditEventButton.Location = new System.Drawing.Point(242, 3);
            this.EditEventButton.Name = "EditEventButton";
            this.EditEventButton.Size = new System.Drawing.Size(233, 88);
            this.EditEventButton.TabIndex = 3;
            this.EditEventButton.Text = "Edytuj wydarzenie";
            this.EditEventButton.UseVisualStyleBackColor = true;
            // 
            // AddEventButton
            // 
            this.AddEventButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddEventButton.Location = new System.Drawing.Point(3, 3);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(233, 88);
            this.AddEventButton.TabIndex = 2;
            this.AddEventButton.Text = "Dodaj wydarzenie";
            this.AddEventButton.UseVisualStyleBackColor = true;
            // 
            // RefreshEventsButton
            // 
            this.RefreshEventsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshEventsButton.Location = new System.Drawing.Point(720, 3);
            this.RefreshEventsButton.Name = "RefreshEventsButton";
            this.RefreshEventsButton.Size = new System.Drawing.Size(233, 88);
            this.RefreshEventsButton.TabIndex = 5;
            this.RefreshEventsButton.Text = "Odśwież";
            this.RefreshEventsButton.UseVisualStyleBackColor = true;
            // 
            // StudentsPage
            // 
            this.StudentsPage.Controls.Add(this.tableLayoutPanel1);
            this.StudentsPage.Location = new System.Drawing.Point(8, 51);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsPage.Size = new System.Drawing.Size(968, 552);
            this.StudentsPage.TabIndex = 2;
            this.StudentsPage.Text = "Uczniowie";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.StudentsCheckedListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 546);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // StudentsCheckedListBox
            // 
            this.StudentsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentsCheckedListBox.FormattingEnabled = true;
            this.StudentsCheckedListBox.HorizontalScrollbar = true;
            this.StudentsCheckedListBox.Location = new System.Drawing.Point(3, 103);
            this.StudentsCheckedListBox.Name = "StudentsCheckedListBox";
            this.StudentsCheckedListBox.ScrollAlwaysVisible = true;
            this.StudentsCheckedListBox.Size = new System.Drawing.Size(956, 440);
            this.StudentsCheckedListBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditStudentButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddStudentButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RefreshStudentsButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(956, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(481, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 88);
            this.button1.TabIndex = 4;
            this.button1.Text = "Usuń ucznia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditStudentButton.Enabled = false;
            this.EditStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditStudentButton.Location = new System.Drawing.Point(242, 3);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(233, 88);
            this.EditStudentButton.TabIndex = 3;
            this.EditStudentButton.Text = "Edytuj ucznia";
            this.EditStudentButton.UseVisualStyleBackColor = true;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddStudentButton.Location = new System.Drawing.Point(3, 3);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(233, 88);
            this.AddStudentButton.TabIndex = 2;
            this.AddStudentButton.Text = "Dodaj ucznia";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            // 
            // RefreshStudentsButton
            // 
            this.RefreshStudentsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshStudentsButton.Location = new System.Drawing.Point(720, 3);
            this.RefreshStudentsButton.Name = "RefreshStudentsButton";
            this.RefreshStudentsButton.Size = new System.Drawing.Size(233, 88);
            this.RefreshStudentsButton.TabIndex = 5;
            this.RefreshStudentsButton.Text = "Odśwież";
            this.RefreshStudentsButton.UseVisualStyleBackColor = true;
            // 
            // ManagementPage
            // 
            this.ManagementPage.Location = new System.Drawing.Point(8, 51);
            this.ManagementPage.Name = "ManagementPage";
            this.ManagementPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManagementPage.Size = new System.Drawing.Size(968, 552);
            this.ManagementPage.TabIndex = 3;
            this.ManagementPage.Text = "Zarządzanie";
            this.ManagementPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
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
            this.EventsPage.ResumeLayout(false);
            this.TableLayout5.ResumeLayout(false);
            this.TableLayout6.ResumeLayout(false);
            this.StudentsPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox SelectGenderComboBox;
        private System.Windows.Forms.TabPage StudentsPage;
        private System.Windows.Forms.TabPage ManagementPage;
        private System.Windows.Forms.TableLayoutPanel TableLayout5;
        private System.Windows.Forms.TableLayoutPanel TableLayout6;
        private System.Windows.Forms.Button DeleteEventButton;
        private System.Windows.Forms.Button EditEventButton;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button RefreshEventsButton;
        private System.Windows.Forms.CheckedListBox EventsCheckedListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox StudentsCheckedListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button RefreshStudentsButton;
    }
}

