namespace CarRental
{
    partial class FormVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehicle));
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePickerRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.comboBoxIsDeleted = new System.Windows.Forms.ComboBox();
            this.lblIsDeleted = new System.Windows.Forms.Label();
            this.comboBoxIsRented = new System.Windows.Forms.ComboBox();
            this.lblIsRented = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblCountItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountItemNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.lblImageList = new System.Windows.Forms.Label();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.listViewComments = new System.Windows.Forms.ListView();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.groupBoxMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.btnCancel);
            this.groupBoxMain.Controls.Add(this.dateTimePickerRegisterDate);
            this.groupBoxMain.Controls.Add(this.lblRegisterDate);
            this.groupBoxMain.Controls.Add(this.comboBoxIsDeleted);
            this.groupBoxMain.Controls.Add(this.lblIsDeleted);
            this.groupBoxMain.Controls.Add(this.comboBoxIsRented);
            this.groupBoxMain.Controls.Add(this.lblIsRented);
            this.groupBoxMain.Controls.Add(this.txtPrice);
            this.groupBoxMain.Controls.Add(this.lblPrice);
            this.groupBoxMain.Controls.Add(this.txtColor);
            this.groupBoxMain.Controls.Add(this.lblColor);
            this.groupBoxMain.Controls.Add(this.txtYear);
            this.groupBoxMain.Controls.Add(this.lblYear);
            this.groupBoxMain.Controls.Add(this.txtBrand);
            this.groupBoxMain.Controls.Add(this.btnSearch);
            this.groupBoxMain.Controls.Add(this.btnDelete);
            this.groupBoxMain.Controls.Add(this.btnEdit);
            this.groupBoxMain.Controls.Add(this.btnSave);
            this.groupBoxMain.Controls.Add(this.comboBoxVehicleType);
            this.groupBoxMain.Controls.Add(this.lblVehicleType);
            this.groupBoxMain.Controls.Add(this.txtID);
            this.groupBoxMain.Controls.Add(this.lblID);
            this.groupBoxMain.Controls.Add(this.lblBrand);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(600, 195);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Employee info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(394, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePickerRegisterDate
            // 
            this.dateTimePickerRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRegisterDate.Location = new System.Drawing.Point(386, 130);
            this.dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            this.dateTimePickerRegisterDate.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerRegisterDate.TabIndex = 22;
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.Location = new System.Drawing.Point(307, 134);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(73, 13);
            this.lblRegisterDate.TabIndex = 21;
            this.lblRegisterDate.Text = "Register date:";
            // 
            // comboBoxIsDeleted
            // 
            this.comboBoxIsDeleted.FormattingEnabled = true;
            this.comboBoxIsDeleted.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.comboBoxIsDeleted.Location = new System.Drawing.Point(386, 103);
            this.comboBoxIsDeleted.Name = "comboBoxIsDeleted";
            this.comboBoxIsDeleted.Size = new System.Drawing.Size(80, 21);
            this.comboBoxIsDeleted.TabIndex = 20;
            // 
            // lblIsDeleted
            // 
            this.lblIsDeleted.AutoSize = true;
            this.lblIsDeleted.Location = new System.Drawing.Point(322, 106);
            this.lblIsDeleted.Name = "lblIsDeleted";
            this.lblIsDeleted.Size = new System.Drawing.Size(58, 13);
            this.lblIsDeleted.TabIndex = 19;
            this.lblIsDeleted.Text = "Is Deleted:";
            // 
            // comboBoxIsRented
            // 
            this.comboBoxIsRented.FormattingEnabled = true;
            this.comboBoxIsRented.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.comboBoxIsRented.Location = new System.Drawing.Point(386, 76);
            this.comboBoxIsRented.Name = "comboBoxIsRented";
            this.comboBoxIsRented.Size = new System.Drawing.Size(80, 21);
            this.comboBoxIsRented.TabIndex = 18;
            // 
            // lblIsRented
            // 
            this.lblIsRented.AutoSize = true;
            this.lblIsRented.Location = new System.Drawing.Point(329, 79);
            this.lblIsRented.Name = "lblIsRented";
            this.lblIsRented.Size = new System.Drawing.Size(51, 13);
            this.lblIsRented.TabIndex = 17;
            this.lblIsRented.Text = "Is rented:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(75, 127);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 20);
            this.txtPrice.TabIndex = 16;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(31, 130);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(75, 101);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(156, 20);
            this.txtColor.TabIndex = 14;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(31, 104);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(75, 75);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(156, 20);
            this.txtYear.TabIndex = 12;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(31, 78);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Year:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(75, 49);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(156, 20);
            this.txtBrand.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(475, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(237, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(156, 162);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Location = new System.Drawing.Point(386, 49);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(164, 21);
            this.comboBoxVehicleType.TabIndex = 5;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(346, 52);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(34, 13);
            this.lblVehicleType.TabIndex = 4;
            this.lblVehicleType.Text = "Type:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(75, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(31, 52);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand:";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCountItem,
            this.lblCountItemNo});
            this.statusStripMain.Location = new System.Drawing.Point(0, 539);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(784, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lblCountItem
            // 
            this.lblCountItem.Name = "lblCountItem";
            this.lblCountItem.Size = new System.Drawing.Size(70, 17);
            this.lblCountItem.Text = "Item Count:";
            // 
            // lblCountItemNo
            // 
            this.lblCountItemNo.Name = "lblCountItemNo";
            this.lblCountItemNo.Size = new System.Drawing.Size(13, 17);
            this.lblCountItemNo.Text = "0";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(618, 213);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(154, 102);
            this.pictureBoxMain.TabIndex = 5;
            this.pictureBoxMain.TabStop = false;
            // 
            // lblImageList
            // 
            this.lblImageList.AutoSize = true;
            this.lblImageList.Location = new System.Drawing.Point(615, 12);
            this.lblImageList.Name = "lblImageList";
            this.lblImageList.Size = new System.Drawing.Size(91, 13);
            this.lblImageList.TabIndex = 6;
            this.lblImageList.Text = "Vehicle image list:";
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Image = global::CarRental.Properties.Resources.Trash_can_icon;
            this.btnDeleteImage.Location = new System.Drawing.Point(735, 28);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(34, 33);
            this.btnDeleteImage.TabIndex = 7;
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Image = global::CarRental.Properties.Resources.camera_icon;
            this.btnAddImage.Location = new System.Drawing.Point(615, 28);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(34, 33);
            this.btnAddImage.TabIndex = 8;
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // listViewComments
            // 
            this.listViewComments.HideSelection = false;
            this.listViewComments.Location = new System.Drawing.Point(12, 213);
            this.listViewComments.Name = "listViewComments";
            this.listViewComments.Size = new System.Drawing.Size(600, 102);
            this.listViewComments.TabIndex = 9;
            this.listViewComments.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(760, 215);
            this.dataGridViewMain.TabIndex = 10;
            // 
            // listViewImages
            // 
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(618, 67);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(154, 140);
            this.listViewImages.TabIndex = 11;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            this.listViewImages.SelectedIndexChanged += new System.EventHandler(this.listViewImages_SelectedIndexChanged);
            // 
            // FormVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listViewImages);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.listViewComments);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.lblImageList);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.groupBoxMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.FormVehicle_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblCountItem;
        private System.Windows.Forms.ToolStripStatusLabel lblCountItemNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.ComboBox comboBoxIsRented;
        private System.Windows.Forms.Label lblIsRented;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisterDate;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.ComboBox comboBoxIsDeleted;
        private System.Windows.Forms.Label lblIsDeleted;
        private System.Windows.Forms.ListView listViewComments;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.Button btnCancel;
    }
}