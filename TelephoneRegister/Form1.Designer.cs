namespace TelephoneRegister
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvTelephoneList = new DataGridView();
            txtBoxID = new TextBox();
            txtBoxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            msktxtBoxTelephone = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTelephoneList).BeginInit();
            SuspendLayout();
            // 
            // dgvTelephoneList
            // 
            dgvTelephoneList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTelephoneList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTelephoneList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelephoneList.Location = new Point(12, 158);
            dgvTelephoneList.Name = "dgvTelephoneList";
            dgvTelephoneList.RowHeadersWidth = 51;
            dgvTelephoneList.RowTemplate.Height = 29;
            dgvTelephoneList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTelephoneList.Size = new Size(776, 280);
            dgvTelephoneList.TabIndex = 0;
            dgvTelephoneList.CellMouseClick += dgvTelephoneList_CellMouseClick;
            // 
            // txtBoxID
            // 
            txtBoxID.Location = new Point(170, 21);
            txtBoxID.MaxLength = 50;
            txtBoxID.Name = "txtBoxID";
            txtBoxID.Size = new Size(125, 27);
            txtBoxID.TabIndex = 1;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(170, 54);
            txtBoxFirstName.MaxLength = 50;
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(125, 27);
            txtBoxFirstName.TabIndex = 2;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(170, 87);
            txtBoxLastName.MaxLength = 50;
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(125, 27);
            txtBoxLastName.TabIndex = 3;
            // 
            // msktxtBoxTelephone
            // 
            msktxtBoxTelephone.Location = new Point(170, 120);
            msktxtBoxTelephone.Mask = "(999) 000-0000";
            msktxtBoxTelephone.Name = "msktxtBoxTelephone";
            msktxtBoxTelephone.Size = new Size(125, 27);
            msktxtBoxTelephone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 8;
            label4.Text = "Telephone Number";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(433, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Tag = "1";
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(433, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Tag = "2";
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(433, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Tag = "3";
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(msktxtBoxTelephone);
            Controls.Add(txtBoxLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(txtBoxID);
            Controls.Add(dgvTelephoneList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Telephone Register";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTelephoneList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTelephoneList;
        private TextBox txtBoxID;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private MaskedTextBox msktxtBoxTelephone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}