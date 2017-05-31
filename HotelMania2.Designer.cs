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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageGuestRegister = new System.Windows.Forms.TabPage();
			this.tabPageFloor1 = new System.Windows.Forms.TabPage();
			this.dataGridViewFloor1 = new System.Windows.Forms.DataGridView();
			this.tabPageFloor2 = new System.Windows.Forms.TabPage();
			this.dataGridViewFloor2 = new System.Windows.Forms.DataGridView();
			this.tabPageFloor3 = new System.Windows.Forms.TabPage();
			this.dataGridViewFloor3 = new System.Windows.Forms.DataGridView();
			this.roomNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floorNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.roomNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floorNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.inputFieldName = new System.Windows.Forms.TextBox();
			this.submitNewGuestButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.removeGuestLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			labelForNameInputBox = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.guestListDataGrid)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPageGuestRegister.SuspendLayout();
			this.tabPageFloor1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor1)).BeginInit();
			this.tabPageFloor2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor2)).BeginInit();
			this.tabPageFloor3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// guestListDataGrid
			// 
			this.guestListDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.guestListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.guestListDataGrid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.guestBindingSource, "hasRoom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.guestListDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.guestListDataGrid.Location = new System.Drawing.Point(12, 12);
			this.guestListDataGrid.MultiSelect = false;
			this.guestListDataGrid.Name = "guestListDataGrid";
			this.guestListDataGrid.ReadOnly = true;
			this.guestListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.guestListDataGrid.Size = new System.Drawing.Size(453, 509);
			this.guestListDataGrid.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageGuestRegister);
			this.tabControl.Controls.Add(this.tabPageFloor1);
			this.tabControl.Controls.Add(this.tabPageFloor2);
			this.tabControl.Controls.Add(this.tabPageFloor3);
			this.tabControl.Location = new System.Drawing.Point(471, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(539, 509);
			this.tabControl.TabIndex = 1;
			// 
			// tabPageGuestRegister
			// 
			this.tabPageGuestRegister.Controls.Add(this.label2);
			this.tabPageGuestRegister.Controls.Add(this.removeGuestLabel);
			this.tabPageGuestRegister.Controls.Add(this.label1);
			this.tabPageGuestRegister.Controls.Add(this.button2);
			this.tabPageGuestRegister.Controls.Add(this.submitNewGuestButton);
			this.tabPageGuestRegister.Controls.Add(labelForNameInputBox);
			this.tabPageGuestRegister.Controls.Add(this.inputFieldName);
			this.tabPageGuestRegister.Location = new System.Drawing.Point(4, 22);
			this.tabPageGuestRegister.Name = "tabPageGuestRegister";
			this.tabPageGuestRegister.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGuestRegister.Size = new System.Drawing.Size(531, 483);
			this.tabPageGuestRegister.TabIndex = 0;
			this.tabPageGuestRegister.Text = "Guest Registration";
			this.tabPageGuestRegister.UseVisualStyleBackColor = true;
			// 
			// tabPageFloor1
			// 
			this.tabPageFloor1.Controls.Add(this.dataGridViewFloor1);
			this.tabPageFloor1.Location = new System.Drawing.Point(4, 22);
			this.tabPageFloor1.Name = "tabPageFloor1";
			this.tabPageFloor1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFloor1.Size = new System.Drawing.Size(531, 483);
			this.tabPageFloor1.TabIndex = 1;
			this.tabPageFloor1.Text = "Floor 1";
			this.tabPageFloor1.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFloor1
			// 
			this.dataGridViewFloor1.AutoGenerateColumns = false;
			this.dataGridViewFloor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFloor1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn2,
            this.floorNumberDataGridViewTextBoxColumn2});
			this.dataGridViewFloor1.DataSource = this.hotelRoomBindingSource;
			this.dataGridViewFloor1.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewFloor1.Name = "dataGridViewFloor1";
			this.dataGridViewFloor1.Size = new System.Drawing.Size(519, 471);
			this.dataGridViewFloor1.TabIndex = 0;
			// 
			// tabPageFloor2
			// 
			this.tabPageFloor2.Controls.Add(this.dataGridViewFloor2);
			this.tabPageFloor2.Location = new System.Drawing.Point(4, 22);
			this.tabPageFloor2.Name = "tabPageFloor2";
			this.tabPageFloor2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFloor2.Size = new System.Drawing.Size(531, 483);
			this.tabPageFloor2.TabIndex = 2;
			this.tabPageFloor2.Text = "Floor 2";
			this.tabPageFloor2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFloor2
			// 
			this.dataGridViewFloor2.AutoGenerateColumns = false;
			this.dataGridViewFloor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFloor2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn1,
            this.floorNumberDataGridViewTextBoxColumn1});
			this.dataGridViewFloor2.DataSource = this.hotelRoomBindingSource;
			this.dataGridViewFloor2.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewFloor2.Name = "dataGridViewFloor2";
			this.dataGridViewFloor2.Size = new System.Drawing.Size(519, 471);
			this.dataGridViewFloor2.TabIndex = 0;
			// 
			// tabPageFloor3
			// 
			this.tabPageFloor3.Controls.Add(this.dataGridViewFloor3);
			this.tabPageFloor3.Location = new System.Drawing.Point(4, 22);
			this.tabPageFloor3.Name = "tabPageFloor3";
			this.tabPageFloor3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFloor3.Size = new System.Drawing.Size(531, 483);
			this.tabPageFloor3.TabIndex = 3;
			this.tabPageFloor3.Text = "Floor 3";
			this.tabPageFloor3.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFloor3
			// 
			this.dataGridViewFloor3.AutoGenerateColumns = false;
			this.dataGridViewFloor3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFloor3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.floorNumberDataGridViewTextBoxColumn});
			this.dataGridViewFloor3.DataSource = this.hotelRoomBindingSource;
			this.dataGridViewFloor3.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewFloor3.Name = "dataGridViewFloor3";
			this.dataGridViewFloor3.Size = new System.Drawing.Size(519, 471);
			this.dataGridViewFloor3.TabIndex = 0;
			// 
			// roomNumberDataGridViewTextBoxColumn2
			// 
			this.roomNumberDataGridViewTextBoxColumn2.DataPropertyName = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn2.HeaderText = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn2.Name = "roomNumberDataGridViewTextBoxColumn2";
			// 
			// floorNumberDataGridViewTextBoxColumn2
			// 
			this.floorNumberDataGridViewTextBoxColumn2.DataPropertyName = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn2.HeaderText = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn2.Name = "floorNumberDataGridViewTextBoxColumn2";
			// 
			// hotelRoomBindingSource
			// 
			this.hotelRoomBindingSource.DataSource = typeof(HotelRoom);
			// 
			// roomNumberDataGridViewTextBoxColumn1
			// 
			this.roomNumberDataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn1.HeaderText = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn1.Name = "roomNumberDataGridViewTextBoxColumn1";
			// 
			// floorNumberDataGridViewTextBoxColumn1
			// 
			this.floorNumberDataGridViewTextBoxColumn1.DataPropertyName = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn1.HeaderText = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn1.Name = "floorNumberDataGridViewTextBoxColumn1";
			// 
			// roomNumberDataGridViewTextBoxColumn
			// 
			this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
			this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
			// 
			// floorNumberDataGridViewTextBoxColumn
			// 
			this.floorNumberDataGridViewTextBoxColumn.DataPropertyName = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn.HeaderText = "FloorNumber";
			this.floorNumberDataGridViewTextBoxColumn.Name = "floorNumberDataGridViewTextBoxColumn";
			// 
			// guestBindingSource
			// 
			this.guestBindingSource.DataSource = typeof(Guest);
			// 
			// inputFieldName
			// 
			this.inputFieldName.Location = new System.Drawing.Point(32, 59);
			this.inputFieldName.Name = "inputFieldName";
			this.inputFieldName.Size = new System.Drawing.Size(100, 20);
			this.inputFieldName.TabIndex = 0;
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
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(33, 174);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Submit Removal";
			this.button2.UseVisualStyleBackColor = true;
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
			// removeGuestLabel
			// 
			this.removeGuestLabel.AutoSize = true;
			this.removeGuestLabel.Location = new System.Drawing.Point(40, 144);
			this.removeGuestLabel.Name = "removeGuestLabel";
			this.removeGuestLabel.Size = new System.Drawing.Size(78, 13);
			this.removeGuestLabel.TabIndex = 6;
			this.removeGuestLabel.Text = "Remove Guest";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 212);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Verify by clicking again";
			// 
			// HotelMania
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1191, 533);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.guestListDataGrid);
			this.Name = "HotelMania";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.guestListDataGrid)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabPageGuestRegister.ResumeLayout(false);
			this.tabPageGuestRegister.PerformLayout();
			this.tabPageFloor1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor1)).EndInit();
			this.tabPageFloor2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor2)).EndInit();
			this.tabPageFloor3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView guestListDataGrid;
		private System.Windows.Forms.BindingSource guestBindingSource;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageGuestRegister;
		private System.Windows.Forms.TabPage tabPageFloor1;
		private System.Windows.Forms.TabPage tabPageFloor2;
		private System.Windows.Forms.TabPage tabPageFloor3;
		private System.Windows.Forms.DataGridView dataGridViewFloor1;
		private System.Windows.Forms.DataGridView dataGridViewFloor2;
		private System.Windows.Forms.DataGridView dataGridViewFloor3;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource hotelRoomBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn1;
		private System.Windows.Forms.Label removeGuestLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button submitNewGuestButton;
		private System.Windows.Forms.TextBox inputFieldName;
		private System.Windows.Forms.Label label2;
	}
}

