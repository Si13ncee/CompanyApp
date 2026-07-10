namespace CompanyApp
{
    partial class CompanyExplorer
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
            menuStrip1 = new MenuStrip();
            FileBTN = new ToolStripMenuItem();
            EmployeesBTN = new ToolStripMenuItem();
            HelpBTN = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            OrganisationView = new TreeView();
            splitContainer3 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            splitContainer4 = new SplitContainer();
            textBox1 = new TextBox();
            splitContainer5 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxCode = new TextBox();
            labelManager = new Label();
            labelType = new Label();
            labelCode = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            comboBoxType = new ComboBox();
            comboBoxManager = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonAddChild = new Button();
            buttonAddEmp = new Button();
            buttonEditEmp = new Button();
            buttonDeleteEmp = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileBTN, EmployeesBTN, HelpBTN });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // FileBTN
            // 
            FileBTN.Name = "FileBTN";
            FileBTN.Size = new Size(37, 20);
            FileBTN.Text = "File";
            // 
            // EmployeesBTN
            // 
            EmployeesBTN.Name = "EmployeesBTN";
            EmployeesBTN.Size = new Size(76, 20);
            EmployeesBTN.Text = "Employees";
            // 
            // HelpBTN
            // 
            HelpBTN.Name = "HelpBTN";
            HelpBTN.Size = new Size(44, 20);
            HelpBTN.Text = "Help";
            HelpBTN.Click += toolStripMenuItem3_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Panel2MinSize = 100;
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(OrganisationView);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer4);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint_1;
            splitContainer2.Size = new Size(800, 250);
            splitContainer2.SplitterDistance = 250;
            splitContainer2.TabIndex = 0;
            // 
            // OrganisationView
            // 
            OrganisationView.Dock = DockStyle.Fill;
            OrganisationView.HideSelection = false;
            OrganisationView.Location = new Point(0, 0);
            OrganisationView.Name = "OrganisationView";
            OrganisationView.Size = new Size(250, 250);
            OrganisationView.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer3.Panel1MinSize = 24;
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(dataGridView1);
            splitContainer3.Panel2MinSize = 24;
            splitContainer3.Size = new Size(800, 172);
            splitContainer3.SplitterDistance = 24;
            splitContainer3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonAddEmp);
            flowLayoutPanel1.Controls.Add(buttonEditEmp);
            flowLayoutPanel1.Controls.Add(buttonDeleteEmp);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 24);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 144);
            dataGridView1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer5);
            splitContainer4.Size = new Size(546, 250);
            splitContainer4.SplitterDistance = 25;
            splitContainer4.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(546, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Organization Unit Details";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer5.Size = new Size(546, 221);
            splitContainer5.SplitterDistance = 192;
            splitContainer5.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBoxCode, 1, 1);
            tableLayoutPanel1.Controls.Add(labelManager, 0, 3);
            tableLayoutPanel1.Controls.Add(labelType, 0, 2);
            tableLayoutPanel1.Controls.Add(labelCode, 0, 1);
            tableLayoutPanel1.Controls.Add(labelName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxName, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxType, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBoxManager, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(546, 192);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxCode
            // 
            textBoxCode.Dock = DockStyle.Fill;
            textBoxCode.Location = new Point(81, 58);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(447, 23);
            textBoxCode.TabIndex = 8;
            // 
            // labelManager
            // 
            labelManager.Anchor = AnchorStyles.Left;
            labelManager.AutoSize = true;
            labelManager.Location = new Point(18, 148);
            labelManager.Name = "labelManager";
            labelManager.Size = new Size(57, 15);
            labelManager.TabIndex = 6;
            labelManager.Text = "Manager:";
            labelManager.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelType
            // 
            labelType.Anchor = AnchorStyles.Left;
            labelType.AutoSize = true;
            labelType.Location = new Point(18, 107);
            labelType.Name = "labelType";
            labelType.Size = new Size(34, 15);
            labelType.TabIndex = 4;
            labelType.Text = "Type:";
            labelType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCode
            // 
            labelCode.Anchor = AnchorStyles.Left;
            labelCode.AutoSize = true;
            labelCode.Location = new Point(18, 67);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(38, 15);
            labelCode.TabIndex = 2;
            labelCode.Text = "Code:";
            labelCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Left;
            labelName.AutoSize = true;
            labelName.Location = new Point(18, 27);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Location = new Point(81, 18);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(447, 23);
            textBoxName.TabIndex = 7;
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Fill;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(81, 98);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(447, 23);
            comboBoxType.TabIndex = 9;
            // 
            // comboBoxManager
            // 
            comboBoxManager.Dock = DockStyle.Fill;
            comboBoxManager.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(81, 138);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(447, 23);
            comboBoxManager.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonSave);
            flowLayoutPanel2.Controls.Add(buttonDelete);
            flowLayoutPanel2.Controls.Add(buttonAddChild);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(546, 25);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Left;
            buttonSave.AutoSize = true;
            buttonSave.Location = new Point(3, 0);
            buttonSave.Margin = new Padding(3, 0, 3, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 25);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Left;
            buttonDelete.AutoSize = true;
            buttonDelete.Location = new Point(84, 0);
            buttonDelete.Margin = new Padding(3, 0, 3, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 25);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAddChild
            // 
            buttonAddChild.Anchor = AnchorStyles.Left;
            buttonAddChild.AutoSize = true;
            buttonAddChild.Location = new Point(165, 0);
            buttonAddChild.Margin = new Padding(3, 0, 3, 3);
            buttonAddChild.Name = "buttonAddChild";
            buttonAddChild.Size = new Size(75, 25);
            buttonAddChild.TabIndex = 2;
            buttonAddChild.Text = "Add Child";
            buttonAddChild.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmp
            // 
            buttonAddEmp.Anchor = AnchorStyles.Left;
            buttonAddEmp.AutoSize = true;
            buttonAddEmp.Location = new Point(3, 0);
            buttonAddEmp.Margin = new Padding(3, 0, 3, 3);
            buttonAddEmp.Name = "buttonAddEmp";
            buttonAddEmp.Size = new Size(94, 25);
            buttonAddEmp.TabIndex = 1;
            buttonAddEmp.Text = "Add Employee";
            buttonAddEmp.UseVisualStyleBackColor = true;
            // 
            // buttonEditEmp
            // 
            buttonEditEmp.Anchor = AnchorStyles.Left;
            buttonEditEmp.AutoSize = true;
            buttonEditEmp.Location = new Point(103, 0);
            buttonEditEmp.Margin = new Padding(3, 0, 3, 3);
            buttonEditEmp.Name = "buttonEditEmp";
            buttonEditEmp.Size = new Size(92, 25);
            buttonEditEmp.TabIndex = 2;
            buttonEditEmp.Text = "Edit Employee";
            buttonEditEmp.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmp
            // 
            buttonDeleteEmp.Anchor = AnchorStyles.Left;
            buttonDeleteEmp.AutoSize = true;
            buttonDeleteEmp.Location = new Point(201, 0);
            buttonDeleteEmp.Margin = new Padding(3, 0, 3, 3);
            buttonDeleteEmp.Name = "buttonDeleteEmp";
            buttonDeleteEmp.Size = new Size(105, 25);
            buttonDeleteEmp.TabIndex = 3;
            buttonDeleteEmp.Text = "Delete Employee";
            buttonDeleteEmp.UseVisualStyleBackColor = true;
            // 
            // CompanyExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CompanyExplorer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompanyExplorer";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileBTN;
        private ToolStripMenuItem EmployeesBTN;
        private ToolStripMenuItem HelpBTN;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TreeView OrganisationView;
        private SplitContainer splitContainer3;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer4;
        private TextBox textBox1;
        private SplitContainer splitContainer5;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxCode;
        private Label labelManager;
        private Label labelType;
        private Label labelCode;
        private Label labelName;
        private TextBox textBoxName;
        private ComboBox comboBoxType;
        private ComboBox comboBoxManager;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonAddChild;
        private Button buttonAddEmp;
        private Button buttonEditEmp;
        private Button buttonDeleteEmp;
    }
}