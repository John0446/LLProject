namespace LLProject
{
    partial class frmiteminfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvItemInfo = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtQulity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtqQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.gvItemInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(516, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 612);
            this.panel1.TabIndex = 0;
            // 
            // gvItemInfo
            // 
            this.gvItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemInfo.Location = new System.Drawing.Point(15, 60);
            this.gvItemInfo.Name = "gvItemInfo";
            this.gvItemInfo.Size = new System.Drawing.Size(257, 529);
            this.gvItemInfo.TabIndex = 0;
            this.gvItemInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvItemInfo_MouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(285, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(69, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateStart
            // 
            this.dateStart.BackColor = System.Drawing.Color.SeaGreen;
            this.dateStart.BorderRadius = 0;
            this.dateStart.ForeColor = System.Drawing.Color.White;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateStart.FormatCustom = null;
            this.dateStart.Location = new System.Drawing.Point(69, 411);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(379, 36);
            this.dateStart.TabIndex = 16;
            this.dateStart.Value = new System.DateTime(2018, 9, 26, 16, 12, 10, 828);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtPrice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtPrice.LineThickness = 2;
            this.txtPrice.Location = new System.Drawing.Point(69, 336);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(379, 33);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.Text = "Price";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtQulity
            // 
            this.txtQulity.BackColor = System.Drawing.Color.White;
            this.txtQulity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQulity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQulity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQulity.HintForeColor = System.Drawing.Color.Empty;
            this.txtQulity.HintText = "";
            this.txtQulity.isPassword = false;
            this.txtQulity.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtQulity.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtQulity.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtQulity.LineThickness = 2;
            this.txtQulity.Location = new System.Drawing.Point(69, 203);
            this.txtQulity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQulity.Name = "txtQulity";
            this.txtQulity.Size = new System.Drawing.Size(379, 33);
            this.txtQulity.TabIndex = 14;
            this.txtQulity.Text = "Quality";
            this.txtQulity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtqQty
            // 
            this.txtqQty.BackColor = System.Drawing.Color.White;
            this.txtqQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtqQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtqQty.HintForeColor = System.Drawing.Color.Empty;
            this.txtqQty.HintText = "";
            this.txtqQty.isPassword = false;
            this.txtqQty.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtqQty.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtqQty.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtqQty.LineThickness = 2;
            this.txtqQty.Location = new System.Drawing.Point(69, 262);
            this.txtqQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqQty.Name = "txtqQty";
            this.txtqQty.Size = new System.Drawing.Size(379, 33);
            this.txtqQty.TabIndex = 13;
            this.txtqQty.Text = "Quantity";
            this.txtqQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtName.LineThickness = 2;
            this.txtName.Location = new System.Drawing.Point(69, 125);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 33);
            this.txtName.TabIndex = 12;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(188, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Item Info";
            // 
            // frmiteminfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQulity);
            this.Controls.Add(this.txtqQty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmiteminfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Info";
            this.Load += new System.EventHandler(this.frmiteminfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvItemInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuDatepicker dateStart;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQulity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtqQty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvItemInfo;
    }
}