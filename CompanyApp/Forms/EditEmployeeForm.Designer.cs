namespace CompanyApp.Forms
{
    partial class EditEmployeeForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxLastName = new TextBox();
            comboBoxDepartment = new ComboBox();
            labelDepartment = new Label();
            labelEmail = new Label();
            textBoxFirstName = new TextBox();
            labelPhone = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            labelName = new Label();
            textBoxTitle = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxPhone, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxLastName, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBoxDepartment, 1, 5);
            tableLayoutPanel1.Controls.Add(labelDepartment, 0, 5);
            tableLayoutPanel1.Controls.Add(labelEmail, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxFirstName, 1, 1);
            tableLayoutPanel1.Controls.Add(labelPhone, 0, 3);
            tableLayoutPanel1.Controls.Add(labelLastName, 0, 2);
            tableLayoutPanel1.Controls.Add(labelFirstName, 0, 1);
            tableLayoutPanel1.Controls.Add(labelName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
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
            tableLayoutPanel1.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Location = new Point(97, 258);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(685, 23);
            textBoxEmail.TabIndex = 20;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Dock = DockStyle.Fill;
            textBoxPhone.Location = new Point(97, 198);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(685, 23);
            textBoxPhone.TabIndex = 19;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Dock = DockStyle.Fill;
            textBoxLastName.Location = new Point(97, 138);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(685, 23);
            textBoxLastName.TabIndex = 18;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Dock = DockStyle.Fill;
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(97, 318);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(685, 23);
            comboBoxDepartment.TabIndex = 17;
            // 
            // labelDepartment
            // 
            labelDepartment.Anchor = AnchorStyles.Left;
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(18, 317);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(73, 15);
            labelDepartment.TabIndex = 16;
            labelDepartment.Text = "Department:";
            labelDepartment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Left;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(18, 277);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 11;
            labelEmail.Text = "Email:";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Dock = DockStyle.Fill;
            textBoxFirstName.Location = new Point(97, 78);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(685, 23);
            textBoxFirstName.TabIndex = 8;
            // 
            // labelPhone
            // 
            labelPhone.Anchor = AnchorStyles.Left;
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(18, 217);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(44, 15);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Phone:";
            labelPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLastName
            // 
            labelLastName.Anchor = AnchorStyles.Left;
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(18, 157);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(66, 15);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last Name:";
            labelLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFirstName
            // 
            labelFirstName.Anchor = AnchorStyles.Left;
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(18, 97);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(67, 15);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name:";
            labelFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Left;
            labelName.AutoSize = true;
            labelName.Location = new Point(18, 37);
            labelName.Name = "labelName";
            labelName.Size = new Size(32, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Title:";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Dock = DockStyle.Fill;
            textBoxTitle.Location = new Point(97, 18);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(685, 23);
            textBoxTitle.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Controls.Add(buttonConfirm);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 96);
            flowLayoutPanel1.TabIndex = 0;
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
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(641, 3);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 23);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxLastName;
        private ComboBox comboBoxDepartment;
        private Label labelDepartment;
        private Label labelEmail;
        private TextBox textBoxFirstName;
        private Label labelPhone;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelName;
        private TextBox textBoxTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}