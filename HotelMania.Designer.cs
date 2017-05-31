namespace HotelMania
{
	partial class HotelMania
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
			System.Windows.Forms.Label labelForNameInputBox;
			this.guestListDataGrid = new System.Windows.Forms.DataGridView();
			this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hotelRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.removeGuestLabel = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridViewGuestsWithRooms = new System.Windows.Forms.DataGridView();
			this.saveData = new System.Windows.Forms.Button();
			this.loadData = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tabPageFloor3 = new System.Windows.Forms.TabPage();
			this.dataGridViewFloor3 = new System.Windows.Forms.DataGridView();
			this.nameOfOccupant1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageFloor2 = new System.Windows.Forms.TabPage();
			this.dataGridViewFloor2 = new System.Windows.Forms.DataGridView();
			this.nameOfOccupant2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floorNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageFloor1 = new System.Windows.Forms.TabPage();
			this.dataGridViewFloor1 = new System.Windows.Forms.DataGridView();
			this.nameOfOccupant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floorNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageGuestRegister = new System.Windows.Forms.TabPage();
			this.inputFieldName = new System.Windows.Forms.TextBox();
			this.submitNewGuestButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ErrorMsgLoad = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floorNumberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomNumberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floorNumberDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomNumberDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			labelForNameInputBox = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.guestListDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestsWithRooms)).BeginInit();
			this.tabPageFloor3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor3)).BeginInit();
			this.tabPageFloor2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor2)).BeginInit();
			this.tabPageFloor1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor1)).BeginInit();
			this.tabPageGuestRegister.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// guestListDataGrid
			// 
			this.guestListDataGrid.AllowDrop = true;
			this.guestListDataGrid.AutoGenerateColumns = false;
			this.guestListDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.guestListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.guestListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestNameDataGridViewTextBoxColumn,
            this.floorNumberDataGridViewTextBoxColumn3,
            this.roomNumberDataGridViewTextBoxColumn3});
			this.guestListDataGrid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.guestBindingSource, "GuestName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
			this.guestListDataGrid.DataSource = this.guestBindingSource;
			this.guestListDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.guestListDataGrid.Location = new System.Drawing.Point(8, 6);
			this.guestListDataGrid.MultiSelect = false;
			this.guestListDataGrid.Name = "guestListDataGrid";
			this.guestListDataGrid.ReadOnly = true;
			this.guestListDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.guestListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.guestListDataGrid.Size = new System.Drawing.Size(347, 483);
			this.guestListDataGrid.TabIndex = 0;
			this.guestListDataGrid.DragOver += new System.Windows.Forms.DragEventHandler(this.guestListDataGrid_DragOver);
			this.guestListDataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guestListDataGrid_MouseDown);
			this.guestListDataGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guestListDataGrid_MouseMove);
			// 
			// guestBindingSource
			// 
			this.guestBindingSource.DataSource = typeof(Guest);
			// 
			// hotelRoomBindingSource
			// 
			this.hotelRoomBindingSource.DataSource = typeof(HotelRoom);
			// 
			// hotelRoomBindingSource1
			// 
			this.hotelRoomBindingSource1.DataSource = typeof(HotelRoom);
			// 
			// removeGuestLabel
			// 
			this.removeGuestLabel.AutoSize = true;
			this.removeGuestLabel.Location = new System.Drawing.Point(748, 287);
			this.removeGuestLabel.Name = "removeGuestLabel";
			this.removeGuestLabel.Size = new System.Drawing.Size(84, 13);
			this.removeGuestLabel.TabIndex = 6;
			this.removeGuestLabel.Text = "Checkout Guest";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(742, 303);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Submit Checkout";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(751, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 41);
			this.button1.TabIndex = 2;
			this.button1.Text = "Move Guest To Room";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(366, 521);
			this.tabControl1.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.guestListDataGrid);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(358, 495);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Guests without rooms";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridViewGuestsWithRooms);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(358, 495);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Guests with rooms";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewGuestsWithRooms
			// 
			this.dataGridViewGuestsWithRooms.AutoGenerateColumns = false;
			this.dataGridViewGuestsWithRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGuestsWithRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestName,
            this.floorNumberDataGridViewTextBoxColumn4,
            this.roomNumberDataGridViewTextBoxColumn4});
			this.dataGridViewGuestsWithRooms.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.guestBindingSource, "hasRoom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.dataGridViewGuestsWithRooms.DataSource = this.guestBindingSource;
			this.dataGridViewGuestsWithRooms.Location = new System.Drawing.Point(8, 6);
			this.dataGridViewGuestsWithRooms.MultiSelect = false;
			this.dataGridViewGuestsWithRooms.Name = "dataGridViewGuestsWithRooms";
			this.dataGridViewGuestsWithRooms.ReadOnly = true;
			this.dataGridViewGuestsWithRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewGuestsWithRooms.Size = new System.Drawing.Size(347, 483);
			this.dataGridViewGuestsWithRooms.TabIndex = 4;
			// 
			// saveData
			// 
			this.saveData.Location = new System.Drawing.Point(751, 361);
			this.saveData.Name = "saveData";
			this.saveData.Size = new System.Drawing.Size(75, 23);
			this.saveData.TabIndex = 6;
			this.saveData.Text = "Save";
			this.saveData.UseVisualStyleBackColor = true;
			this.saveData.Click += new System.EventHandler(this.saveData_Click);
			// 
			// loadData
			// 
			this.loadData.Location = new System.Drawing.Point(751, 399);
			this.loadData.Name = "loadData";
			this.loadData.Size = new System.Drawing.Size(75, 23);
			this.loadData.TabIndex = 9;
			this.loadData.Text = "Load";
			this.loadData.UseVisualStyleBackColor = true;
			this.loadData.Click += new System.EventHandler(this.loadData_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(751, 73);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 59);
			this.button3.TabIndex = 10;
			this.button3.Text = "Remove Guest From Room";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// tabPageFloor3
			// 
			this.tabPageFloor3.Controls.Add(this.dataGridViewFloor3);
			this.tabPageFloor3.Location = new System.Drawing.Point(4, 22);
			this.tabPageFloor3.Name = "tabPageFloor3";
			this.tabPageFloor3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFloor3.Size = new System.Drawing.Size(356, 495);
			this.tabPageFloor3.TabIndex = 3;
			this.tabPageFloor3.Text = "Floor 3";
			this.tabPageFloor3.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFloor3
			// 
			this.dataGridViewFloor3.AllowDrop = true;
			this.dataGridViewFloor3.AutoGenerateColumns = false;
			this.dataGridViewFloor3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFloor3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.floorNumberDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.nameOfOccupant1});
			this.dataGridViewFloor3.DataSource = this.hotelRoomBindingSource;
			this.dataGridViewFloor3.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewFloor3.Name = "dataGridViewFloor3";
			this.dataGridViewFloor3.ReadOnly = true;
			this.dataGridViewFloor3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewFloor3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewFloor3.Size = new System.Drawing.Size(347, 483);
			this.dataGridViewFloor3.TabIndex = 0;
			this.dataGridViewFloor3.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewFloor3_DragDrop);
			// 
			// nameOfOccupant1
			// 
			this.nameOfOccupant1.DataPropertyName = "nameOfOccupant";
			this.nameOfOccupant1.HeaderText = "Guest Name";
			this.nameOfOccupant1.Name = "nameOfOccupant1";
			this.nameOfOccupant1.ReadOnly = true;
			// 
			// roomNumberDataGridViewTextBoxColumn
			// 
			this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
			this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// floorNumberDataGridViewTextBoxColumn
			// 
			this.floorNumberDataGridViewTextBoxColumn.DataPropertyName = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn.HeaderText = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn.Name = "floorNumberDataGridViewTextBoxColumn";
			this.floorNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tabPageFloor2
			// 
			this.tabPageFloor2.Controls.Add(this.dataGridViewFloor2);
			this.tabPageFloor2.Location = new System.Drawing.Point(4, 22);
			this.tabPageFloor2.Name = "tabPageFloor2";
			this.tabPageFloor2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFloor2.Size = new System.Drawing.Size(356, 495);
			this.tabPageFloor2.TabIndex = 2;
			this.tabPageFloor2.Text = "Floor 2";
			this.tabPageFloor2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFloor2
			// 
			this.dataGridViewFloor2.AllowDrop = true;
			this.dataGridViewFloor2.AutoGenerateColumns = false;
			this.dataGridViewFloor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFloor2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.floorNumberDataGridViewTextBoxColumn1,
            this.roomNumberDataGridViewTextBoxColumn1,
            this.nameOfOccupant2});
			this.dataGridViewFloor2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.hotelRoomBindingSource, "currOccupant", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.dataGridViewFloor2.DataSource = this.hotelRoomBindingSource;
			this.dataGridViewFloor2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridViewFloor2.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewFloor2.MultiSelect = false;
			this.dataGridViewFloor2.Name = "dataGridViewFloor2";
			this.dataGridViewFloor2.ReadOnly = true;
			this.dataGridViewFloor2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewFloor2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewFloor2.Size = new System.Drawing.Size(347, 483);
			this.dataGridViewFloor2.TabIndex = 0;
			this.dataGridViewFloor2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewFloor2_DragDrop);
			// 
			// nameOfOccupant2
			// 
			this.nameOfOccupant2.DataPropertyName = "nameOfOccupant";
			this.nameOfOccupant2.HeaderText = "Guest Name";
			this.nameOfOccupant2.Name = "nameOfOccupant2";
			this.nameOfOccupant2.ReadOnly = true;
			// 
			// roomNumberDataGridViewTextBoxColumn1
			// 
			this.roomNumberDataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn1.HeaderText = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn1.Name = "roomNumberDataGridViewTextBoxColumn1";
			this.roomNumberDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// floorNumberDataGridViewTextBoxColumn1
			// 
			this.floorNumberDataGridViewTextBoxColumn1.DataPropertyName = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn1.HeaderText = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn1.Name = "floorNumberDataGridViewTextBoxColumn1";
			this.floorNumberDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// tabPageFloor1
			// 
			this.tabPageFloor1.Controls.Add(this.dataGridViewFloor1);
			this.tabPageFloor1.Location = new System.Drawing.Point(4, 22);
			this.tabPageFloor1.Name = "tabPageFloor1";
			this.tabPageFloor1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFloor1.Size = new System.Drawing.Size(356, 495);
			this.tabPageFloor1.TabIndex = 1;
			this.tabPageFloor1.Text = "Floor 1";
			this.tabPageFloor1.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFloor1
			// 
			this.dataGridViewFloor1.AllowDrop = true;
			this.dataGridViewFloor1.AutoGenerateColumns = false;
			this.dataGridViewFloor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFloor1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.floorNumberDataGridViewTextBoxColumn2,
            this.roomNumberDataGridViewTextBoxColumn2,
            this.nameOfOccupant});
			this.dataGridViewFloor1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.hotelRoomBindingSource, "isNotOccupied", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
			this.dataGridViewFloor1.DataSource = this.hotelRoomBindingSource1;
			this.dataGridViewFloor1.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewFloor1.MultiSelect = false;
			this.dataGridViewFloor1.Name = "dataGridViewFloor1";
			this.dataGridViewFloor1.ReadOnly = true;
			this.dataGridViewFloor1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewFloor1.Size = new System.Drawing.Size(347, 483);
			this.dataGridViewFloor1.TabIndex = 0;
			this.dataGridViewFloor1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewFloor1_DragDrop);
			// 
			// nameOfOccupant
			// 
			this.nameOfOccupant.DataPropertyName = "nameOfOccupant";
			this.nameOfOccupant.HeaderText = "Guest Name";
			this.nameOfOccupant.Name = "nameOfOccupant";
			this.nameOfOccupant.ReadOnly = true;
			// 
			// roomNumberDataGridViewTextBoxColumn2
			// 
			this.roomNumberDataGridViewTextBoxColumn2.DataPropertyName = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn2.HeaderText = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn2.Name = "roomNumberDataGridViewTextBoxColumn2";
			this.roomNumberDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// floorNumberDataGridViewTextBoxColumn2
			// 
			this.floorNumberDataGridViewTextBoxColumn2.DataPropertyName = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn2.HeaderText = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn2.Name = "floorNumberDataGridViewTextBoxColumn2";
			this.floorNumberDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// tabPageGuestRegister
			// 
			this.tabPageGuestRegister.Controls.Add(this.ErrorMsgLoad);
			this.tabPageGuestRegister.Controls.Add(this.inputFieldName);
			this.tabPageGuestRegister.Controls.Add(this.label1);
			this.tabPageGuestRegister.Controls.Add(this.submitNewGuestButton);
			this.tabPageGuestRegister.Controls.Add(labelForNameInputBox);
			this.tabPageGuestRegister.Location = new System.Drawing.Point(4, 22);
			this.tabPageGuestRegister.Name = "tabPageGuestRegister";
			this.tabPageGuestRegister.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGuestRegister.Size = new System.Drawing.Size(356, 495);
			this.tabPageGuestRegister.TabIndex = 0;
			this.tabPageGuestRegister.Text = "Guest Registration";
			this.tabPageGuestRegister.UseVisualStyleBackColor = true;
			// 
			// inputFieldName
			// 
			this.inputFieldName.Location = new System.Drawing.Point(32, 59);
			this.inputFieldName.Name = "inputFieldName";
			this.inputFieldName.Size = new System.Drawing.Size(100, 20);
			this.inputFieldName.TabIndex = 0;
			this.inputFieldName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputFieldName_KeyDown);
			// 
			// labelForNameInputBox
			// 
			labelForNameInputBox.AutoSize = true;
			labelForNameInputBox.Location = new System.Drawing.Point(65, 43);
			labelForNameInputBox.Name = "labelForNameInputBox";
			labelForNameInputBox.Size = new System.Drawing.Size(35, 13);
			labelForNameInputBox.TabIndex = 1;
			labelForNameInputBox.Text = "Name";
			// 
			// submitNewGuestButton
			// 
			this.submitNewGuestButton.Location = new System.Drawing.Point(32, 85);
			this.submitNewGuestButton.Name = "submitNewGuestButton";
			this.submitNewGuestButton.Size = new System.Drawing.Size(100, 23);
			this.submitNewGuestButton.TabIndex = 2;
			this.submitNewGuestButton.Text = "Submit Guest";
			this.submitNewGuestButton.UseVisualStyleBackColor = true;
			this.submitNewGuestButton.Click += new System.EventHandler(this.submitNewGuestButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Register New Guest";
			// 
			// ErrorMsgLoad
			// 
			this.ErrorMsgLoad.Location = new System.Drawing.Point(6, 176);
			this.ErrorMsgLoad.Multiline = true;
			this.ErrorMsgLoad.Name = "ErrorMsgLoad";
			this.ErrorMsgLoad.ReadOnly = true;
			this.ErrorMsgLoad.Size = new System.Drawing.Size(162, 63);
			this.ErrorMsgLoad.TabIndex = 11;
			this.ErrorMsgLoad.Visible = false;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageGuestRegister);
			this.tabControl.Controls.Add(this.tabPageFloor1);
			this.tabControl.Controls.Add(this.tabPageFloor2);
			this.tabControl.Controls.Add(this.tabPageFloor3);
			this.tabControl.Location = new System.Drawing.Point(372, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(364, 521);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// guestNameDataGridViewTextBoxColumn
			// 
			this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
			this.guestNameDataGridViewTextBoxColumn.HeaderText = "GuestName";
			this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
			this.guestNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// floorNumberDataGridViewTextBoxColumn3
			// 
			this.floorNumberDataGridViewTextBoxColumn3.DataPropertyName = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn3.HeaderText = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn3.Name = "floorNumberDataGridViewTextBoxColumn3";
			this.floorNumberDataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// roomNumberDataGridViewTextBoxColumn3
			// 
			this.roomNumberDataGridViewTextBoxColumn3.DataPropertyName = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn3.HeaderText = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn3.Name = "roomNumberDataGridViewTextBoxColumn3";
			this.roomNumberDataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// GuestName
			// 
			this.GuestName.DataPropertyName = "GuestName";
			this.GuestName.HeaderText = "GuestName";
			this.GuestName.Name = "GuestName";
			this.GuestName.ReadOnly = true;
			// 
			// floorNumberDataGridViewTextBoxColumn4
			// 
			this.floorNumberDataGridViewTextBoxColumn4.DataPropertyName = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn4.HeaderText = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn4.Name = "floorNumberDataGridViewTextBoxColumn4";
			this.floorNumberDataGridViewTextBoxColumn4.ReadOnly = true;
			this.floorNumberDataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// roomNumberDataGridViewTextBoxColumn4
			// 
			this.roomNumberDataGridViewTextBoxColumn4.DataPropertyName = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn4.HeaderText = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn4.Name = "roomNumberDataGridViewTextBoxColumn4";
			this.roomNumberDataGridViewTextBoxColumn4.ReadOnly = true;
			this.roomNumberDataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// HotelMania
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 533);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.loadData);
			this.Controls.Add(this.saveData);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.removeGuestLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl);
			this.Name = "HotelMania";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.guestListDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestsWithRooms)).EndInit();
			this.tabPageFloor3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor3)).EndInit();
			this.tabPageFloor2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor2)).EndInit();
			this.tabPageFloor1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor1)).EndInit();
			this.tabPageGuestRegister.ResumeLayout(false);
			this.tabPageGuestRegister.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView guestListDataGrid;
		private System.Windows.Forms.BindingSource guestBindingSource;
		private System.Windows.Forms.BindingSource hotelRoomBindingSource;
		private System.Windows.Forms.Label removeGuestLabel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewGuestsWithRooms;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.Button loadData;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
		private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn4;
		private System.Windows.Forms.TabPage tabPageFloor3;
		private System.Windows.Forms.DataGridView dataGridViewFloor3;
		private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOfOccupant1;
		private System.Windows.Forms.TabPage tabPageFloor2;
		private System.Windows.Forms.DataGridView dataGridViewFloor2;
		private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOfOccupant2;
		private System.Windows.Forms.TabPage tabPageFloor1;
		private System.Windows.Forms.DataGridView dataGridViewFloor1;
		private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOfOccupant;
		private System.Windows.Forms.TabPage tabPageGuestRegister;
		private System.Windows.Forms.TextBox ErrorMsgLoad;
		private System.Windows.Forms.TextBox inputFieldName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button submitNewGuestButton;
		private System.Windows.Forms.TabControl tabControl;
	}
}

