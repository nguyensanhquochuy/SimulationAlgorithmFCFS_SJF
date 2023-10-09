namespace MophongFCFS_SJF
{
    partial class FormSJF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grbAddProcess = new System.Windows.Forms.GroupBox();
            this.txtProcess = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvInput = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.nudArrivalTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudBurstTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblBurstTime = new System.Windows.Forms.Label();
            this.btnAnswer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.grbAnswer = new System.Windows.Forms.GroupBox();
            this.dgvOutput = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colOutputID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputBrustTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputWaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputTurnAroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputCompletionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAverageWaiting = new System.Windows.Forms.Label();
            this.lblAverageTurnAround = new System.Windows.Forms.Label();
            this.lblGanntChar = new System.Windows.Forms.Label();
            this.lblKhung = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.colInputID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputBurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitle.SuspendLayout();
            this.grbAddProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstTime)).BeginInit();
            this.grbAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(172)))), ((int)(((byte)(254)))));
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(679, 58);
            this.pnlTitle.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(638, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(246, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GIẢI THUẬT SJF";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(142, 65);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 23);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Loại:";
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.Transparent;
            this.cboType.BorderRadius = 10;
            this.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboType.ItemHeight = 30;
            this.cboType.Items.AddRange(new object[] {
            "SJF Non Arrival Time",
            "SJF Arrival Time"});
            this.cboType.Location = new System.Drawing.Point(212, 65);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(293, 36);
            this.cboType.TabIndex = 30;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // grbAddProcess
            // 
            this.grbAddProcess.Controls.Add(this.txtProcess);
            this.grbAddProcess.Controls.Add(this.dgvInput);
            this.grbAddProcess.Controls.Add(this.btnEdit);
            this.grbAddProcess.Controls.Add(this.nudArrivalTime);
            this.grbAddProcess.Controls.Add(this.nudBurstTime);
            this.grbAddProcess.Controls.Add(this.btnAdd);
            this.grbAddProcess.Controls.Add(this.lblProcess);
            this.grbAddProcess.Controls.Add(this.lblArrivalTime);
            this.grbAddProcess.Controls.Add(this.lblBurstTime);
            this.grbAddProcess.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddProcess.Location = new System.Drawing.Point(25, 124);
            this.grbAddProcess.Name = "grbAddProcess";
            this.grbAddProcess.Size = new System.Drawing.Size(629, 190);
            this.grbAddProcess.TabIndex = 31;
            this.grbAddProcess.TabStop = false;
            this.grbAddProcess.Text = "Thêm tiến trình";
            // 
            // txtProcess
            // 
            this.txtProcess.BorderRadius = 10;
            this.txtProcess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcess.DefaultText = "P1";
            this.txtProcess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProcess.ForeColor = System.Drawing.Color.Black;
            this.txtProcess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcess.Location = new System.Drawing.Point(179, 28);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.PasswordChar = '\0';
            this.txtProcess.PlaceholderText = "";
            this.txtProcess.ReadOnly = true;
            this.txtProcess.SelectedText = "";
            this.txtProcess.Size = new System.Drawing.Size(67, 36);
            this.txtProcess.TabIndex = 30;
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInput.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInput.ColumnHeadersHeight = 36;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInputID,
            this.colInputArrivalTime,
            this.colInputBurstTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInput.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInput.Location = new System.Drawing.Point(265, 24);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.ReadOnly = true;
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.RowHeadersWidth = 51;
            this.dgvInput.Size = new System.Drawing.Size(354, 156);
            this.dgvInput.TabIndex = 23;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInput.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInput.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInput.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInput.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInput.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInput.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInput.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInput.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvInput.ThemeStyle.ReadOnly = true;
            this.dgvInput.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInput.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInput.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInput.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInput.ThemeStyle.RowsStyle.Height = 22;
            this.dgvInput.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInput.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 6;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.FillColor2 = System.Drawing.Color.Magenta;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(99, 150);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nudArrivalTime
            // 
            this.nudArrivalTime.BackColor = System.Drawing.Color.Transparent;
            this.nudArrivalTime.BorderRadius = 10;
            this.nudArrivalTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudArrivalTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudArrivalTime.Location = new System.Drawing.Point(179, 70);
            this.nudArrivalTime.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudArrivalTime.Name = "nudArrivalTime";
            this.nudArrivalTime.Size = new System.Drawing.Size(67, 36);
            this.nudArrivalTime.TabIndex = 22;
            this.nudArrivalTime.UpDownButtonFillColor = System.Drawing.Color.Chartreuse;
            // 
            // nudBurstTime
            // 
            this.nudBurstTime.BackColor = System.Drawing.Color.Transparent;
            this.nudBurstTime.BorderRadius = 10;
            this.nudBurstTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudBurstTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudBurstTime.Location = new System.Drawing.Point(179, 112);
            this.nudBurstTime.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudBurstTime.Name = "nudBurstTime";
            this.nudBurstTime.Size = new System.Drawing.Size(67, 36);
            this.nudBurstTime.TabIndex = 22;
            this.nudBurstTime.UpDownButtonFillColor = System.Drawing.Color.Chartreuse;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FillColor2 = System.Drawing.Color.Magenta;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(13, 37);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(87, 23);
            this.lblProcess.TabIndex = 4;
            this.lblProcess.Text = "Tiến trình:";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(13, 79);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(124, 23);
            this.lblArrivalTime.TabIndex = 4;
            this.lblArrivalTime.Text = "Thời gian đến: ";
            // 
            // lblBurstTime
            // 
            this.lblBurstTime.AutoSize = true;
            this.lblBurstTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurstTime.Location = new System.Drawing.Point(9, 121);
            this.lblBurstTime.Name = "lblBurstTime";
            this.lblBurstTime.Size = new System.Drawing.Size(130, 23);
            this.lblBurstTime.TabIndex = 4;
            this.lblBurstTime.Text = " Thời gian xử lý:";
            // 
            // btnAnswer
            // 
            this.btnAnswer.BorderRadius = 6;
            this.btnAnswer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnswer.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAnswer.FillColor2 = System.Drawing.Color.Magenta;
            this.btnAnswer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.Color.White;
            this.btnAnswer.Location = new System.Drawing.Point(159, 320);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(89, 30);
            this.btnAnswer.TabIndex = 32;
            this.btnAnswer.Text = "Kết quả";
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 6;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FillColor2 = System.Drawing.Color.Magenta;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(367, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 30);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Xóa hết";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grbAnswer
            // 
            this.grbAnswer.Controls.Add(this.dgvOutput);
            this.grbAnswer.Controls.Add(this.lblAverageWaiting);
            this.grbAnswer.Controls.Add(this.lblAverageTurnAround);
            this.grbAnswer.Controls.Add(this.lblGanntChar);
            this.grbAnswer.Controls.Add(this.lblKhung);
            this.grbAnswer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAnswer.Location = new System.Drawing.Point(25, 356);
            this.grbAnswer.Name = "grbAnswer";
            this.grbAnswer.Size = new System.Drawing.Size(629, 373);
            this.grbAnswer.TabIndex = 34;
            this.grbAnswer.TabStop = false;
            this.grbAnswer.Text = "Kết quả";
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvOutput.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOutput.ColumnHeadersHeight = 36;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOutputID,
            this.colOutputArrivalTime,
            this.colOutputBrustTime,
            this.colOutputWaitingTime,
            this.colOutputTurnAroundTime,
            this.colOutputCompletionTime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutput.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOutput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOutput.Location = new System.Drawing.Point(6, 153);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.RowHeadersWidth = 51;
            this.dgvOutput.Size = new System.Drawing.Size(617, 168);
            this.dgvOutput.TabIndex = 23;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOutput.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOutput.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOutput.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOutput.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOutput.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOutput.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOutput.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOutput.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvOutput.ThemeStyle.ReadOnly = true;
            this.dgvOutput.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOutput.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOutput.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOutput.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOutput.ThemeStyle.RowsStyle.Height = 22;
            this.dgvOutput.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOutput.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colOutputID
            // 
            this.colOutputID.HeaderText = "Tiến trình";
            this.colOutputID.MinimumWidth = 6;
            this.colOutputID.Name = "colOutputID";
            this.colOutputID.ReadOnly = true;
            this.colOutputID.Width = 110;
            // 
            // colOutputArrivalTime
            // 
            this.colOutputArrivalTime.HeaderText = "Thời gian đến";
            this.colOutputArrivalTime.MinimumWidth = 6;
            this.colOutputArrivalTime.Name = "colOutputArrivalTime";
            this.colOutputArrivalTime.ReadOnly = true;
            this.colOutputArrivalTime.Width = 142;
            // 
            // colOutputBrustTime
            // 
            this.colOutputBrustTime.HeaderText = "Thời gian xử lý";
            this.colOutputBrustTime.MinimumWidth = 6;
            this.colOutputBrustTime.Name = "colOutputBrustTime";
            this.colOutputBrustTime.ReadOnly = true;
            this.colOutputBrustTime.Width = 148;
            // 
            // colOutputWaitingTime
            // 
            this.colOutputWaitingTime.HeaderText = "Thời gian chờ";
            this.colOutputWaitingTime.MinimumWidth = 6;
            this.colOutputWaitingTime.Name = "colOutputWaitingTime";
            this.colOutputWaitingTime.ReadOnly = true;
            this.colOutputWaitingTime.Width = 141;
            // 
            // colOutputTurnAroundTime
            // 
            this.colOutputTurnAroundTime.HeaderText = "Thời gian hoàn thành";
            this.colOutputTurnAroundTime.MinimumWidth = 6;
            this.colOutputTurnAroundTime.Name = "colOutputTurnAroundTime";
            this.colOutputTurnAroundTime.ReadOnly = true;
            this.colOutputTurnAroundTime.Width = 202;
            // 
            // colOutputCompletionTime
            // 
            this.colOutputCompletionTime.HeaderText = "Thời gian kết thúc";
            this.colOutputCompletionTime.MinimumWidth = 6;
            this.colOutputCompletionTime.Name = "colOutputCompletionTime";
            this.colOutputCompletionTime.ReadOnly = true;
            this.colOutputCompletionTime.Width = 175;
            // 
            // lblAverageWaiting
            // 
            this.lblAverageWaiting.AutoSize = true;
            this.lblAverageWaiting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageWaiting.Location = new System.Drawing.Point(6, 324);
            this.lblAverageWaiting.Name = "lblAverageWaiting";
            this.lblAverageWaiting.Size = new System.Drawing.Size(240, 23);
            this.lblAverageWaiting.TabIndex = 8;
            this.lblAverageWaiting.Text = "Thời gian chờ trung bình: 0.00";
            // 
            // lblAverageTurnAround
            // 
            this.lblAverageTurnAround.AutoSize = true;
            this.lblAverageTurnAround.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageTurnAround.Location = new System.Drawing.Point(6, 347);
            this.lblAverageTurnAround.Name = "lblAverageTurnAround";
            this.lblAverageTurnAround.Size = new System.Drawing.Size(301, 23);
            this.lblAverageTurnAround.TabIndex = 8;
            this.lblAverageTurnAround.Text = "Thời gian hoàn thành trung bình: 0.00";
            // 
            // lblGanntChar
            // 
            this.lblGanntChar.Location = new System.Drawing.Point(43, 42);
            this.lblGanntChar.Name = "lblGanntChar";
            this.lblGanntChar.Size = new System.Drawing.Size(553, 36);
            this.lblGanntChar.TabIndex = 25;
            // 
            // lblKhung
            // 
            this.lblKhung.BackColor = System.Drawing.Color.OldLace;
            this.lblKhung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhung.Location = new System.Drawing.Point(6, 24);
            this.lblKhung.Name = "lblKhung";
            this.lblKhung.Size = new System.Drawing.Size(617, 87);
            this.lblKhung.TabIndex = 24;
            this.lblKhung.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlTitle;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // colInputID
            // 
            this.colInputID.HeaderText = "Tiến trình";
            this.colInputID.MinimumWidth = 6;
            this.colInputID.Name = "colInputID";
            this.colInputID.ReadOnly = true;
            this.colInputID.Width = 110;
            // 
            // colInputArrivalTime
            // 
            this.colInputArrivalTime.HeaderText = "Thời gian đến";
            this.colInputArrivalTime.MinimumWidth = 6;
            this.colInputArrivalTime.Name = "colInputArrivalTime";
            this.colInputArrivalTime.ReadOnly = true;
            this.colInputArrivalTime.Width = 142;
            // 
            // colInputBurstTime
            // 
            this.colInputBurstTime.HeaderText = "Thời gian xử lý";
            this.colInputBurstTime.MinimumWidth = 6;
            this.colInputBurstTime.Name = "colInputBurstTime";
            this.colInputBurstTime.ReadOnly = true;
            this.colInputBurstTime.Width = 148;
            // 
            // FormSJF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 741);
            this.Controls.Add(this.grbAnswer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.grbAddProcess);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSJF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFCFS";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.grbAddProcess.ResumeLayout(false);
            this.grbAddProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstTime)).EndInit();
            this.grbAnswer.ResumeLayout(false);
            this.grbAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblType;
        private Guna.UI2.WinForms.Guna2ComboBox cboType;
        private System.Windows.Forms.GroupBox grbAddProcess;
        private Guna.UI2.WinForms.Guna2TextBox txtProcess;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInput;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudArrivalTime;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudBurstTime;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblBurstTime;
        private Guna.UI2.WinForms.Guna2GradientButton btnAnswer;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private System.Windows.Forms.GroupBox grbAnswer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOutput;
        private System.Windows.Forms.Label lblAverageWaiting;
        private System.Windows.Forms.Label lblAverageTurnAround;
        private System.Windows.Forms.Label lblGanntChar;
        private System.Windows.Forms.Label lblKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputBrustTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputWaitingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputTurnAroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputCompletionTime;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputBurstTime;
    }
}