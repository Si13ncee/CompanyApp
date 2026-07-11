namespace CompanyApp.Forms
{
    partial class AddOrganizationForm
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
            splitContainer1 = new SplitContainer();
            labelTitle = new Label();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBoxParent = new ComboBox();
            comboBoxManager = new ComboBox();
            labelManager = new Label();
            textBoxCode = new TextBox();
            labelParent = new Label();
            labelType = new Label();
            labelCode = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            comboBoxType = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(labelTitle);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 25;
            splitContainer1.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Nová Organizačná Jednotka";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new Size(800, 421);
            splitContainer2.SplitterDistance = 350;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(comboBoxParent, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBoxManager, 1, 4);
            tableLayoutPanel1.Controls.Add(labelManager, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxCode, 1, 1);
            tableLayoutPanel1.Controls.Add(labelParent, 0, 3);
            tableLayoutPanel1.Controls.Add(labelType, 0, 2);
            tableLayoutPanel1.Controls.Add(labelCode, 0, 1);
            tableLayoutPanel1.Controls.Add(labelName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxName, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxType, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 350);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // comboBoxParent
            // 
            comboBoxParent.Dock = DockStyle.Fill;
            comboBoxParent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxParent.FormattingEnabled = true;
            comboBoxParent.Location = new Point(81, 198);
            comboBoxParent.Name = "comboBoxParent";
            comboBoxParent.Size = new Size(701, 23);
            comboBoxParent.TabIndex = 14;
            // 
            // comboBoxManager
            // 
            comboBoxManager.Dock = DockStyle.Fill;
            comboBoxManager.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(81, 258);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(701, 23);
            comboBoxManager.TabIndex = 13;
            // 
            // labelManager
            // 
            labelManager.Anchor = AnchorStyles.Left;
            labelManager.AutoSize = true;
            labelManager.Location = new Point(18, 277);
            labelManager.Name = "labelManager";
            labelManager.Size = new Size(57, 15);
            labelManager.TabIndex = 11;
            labelManager.Text = "Manager:";
            labelManager.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxCode
            // 
            textBoxCode.Dock = DockStyle.Fill;
            textBoxCode.Location = new Point(81, 78);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(701, 23);
            textBoxCode.TabIndex = 8;
            // 
            // labelParent
            // 
            labelParent.Anchor = AnchorStyles.Left;
            labelParent.AutoSize = true;
            labelParent.Location = new Point(18, 217);
            labelParent.Name = "labelParent";
            labelParent.Size = new Size(47, 15);
            labelParent.TabIndex = 6;
            labelParent.Text = "Parent: ";
            labelParent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelType
            // 
            labelType.Anchor = AnchorStyles.Left;
            labelType.AutoSize = true;
            labelType.Location = new Point(18, 157);
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
            labelCode.Location = new Point(18, 97);
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
            labelName.Location = new Point(18, 37);
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
            textBoxName.Size = new Size(701, 23);
            textBoxName.TabIndex = 7;
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Fill;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(81, 138);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(701, 23);
            comboBoxType.TabIndex = 9;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Controls.Add(buttonCreate);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 67);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(722, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(641, 3);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // AddOrganizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "AddOrganizationForm";
            Text = "Formulár pridania novej organizačnej jednotky";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label labelTitle;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxParent;
        private ComboBox comboBoxManager;
        private Label labelManager;
        private TextBox textBoxCode;
        private Label labelParent;
        private Label labelType;
        private Label labelCode;
        private Label labelName;
        private TextBox textBoxName;
        private ComboBox comboBoxType;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCancel;
        private Button buttonCreate;
    }
}