namespace InventoryMaintenance
{
    partial class frmNewItem
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
            label1 = new System.Windows.Forms.Label();
            txtItemNo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 21);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Item no:";
            // 
            // txtItemNo
            // 
            txtItemNo.Location = new System.Drawing.Point(110, 19);
            txtItemNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new System.Drawing.Size(121, 27);
            txtItemNo.TabIndex = 1;
            txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 64);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(110, 61);
            txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(293, 27);
            txtDescription.TabIndex = 3;
            txtDescription.Tag = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 107);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(110, 104);
            txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(121, 27);
            txtPrice.TabIndex = 5;
            txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(110, 159);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(89, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(235, 159);
            btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(89, 33);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmNewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(425, 211);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtItemNo);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}