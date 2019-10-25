namespace BecodingDesktop.Views.Base
{
    partial class FrmBaseActionContainer
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
            this.tblContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnMainAction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tblContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblContainer
            // 
            this.tblContainer.AutoSize = true;
            this.tblContainer.ColumnCount = 3;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.30712F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.69288F));
            this.tblContainer.Controls.Add(this.btnMainAction, 2, 2);
            this.tblContainer.Controls.Add(this.btnCancel, 1, 2);
            this.tblContainer.Controls.Add(this.lblTitle, 0, 0);
            this.tblContainer.Controls.Add(this.flyContainer, 0, 1);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(0, 0);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 3;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.822086F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.17792F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblContainer.Size = new System.Drawing.Size(426, 661);
            this.tblContainer.TabIndex = 0;
            // 
            // btnMainAction
            // 
            this.btnMainAction.AutoSize = true;
            this.btnMainAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMainAction.Depth = 0;
            this.btnMainAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMainAction.Icon = null;
            this.btnMainAction.Location = new System.Drawing.Point(314, 616);
            this.btnMainAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMainAction.Name = "btnMainAction";
            this.btnMainAction.Primary = true;
            this.btnMainAction.Size = new System.Drawing.Size(109, 42);
            this.btnMainAction.TabIndex = 3;
            this.btnMainAction.Text = "ACTUALIZAR";
            this.btnMainAction.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Depth = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(217, 616);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(91, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.tblContainer.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titulo";
            // 
            // flyContainer
            // 
            this.flyContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblContainer.SetColumnSpan(this.flyContainer, 3);
            this.flyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flyContainer.Location = new System.Drawing.Point(3, 51);
            this.flyContainer.Name = "flyContainer";
            this.flyContainer.Size = new System.Drawing.Size(420, 559);
            this.flyContainer.TabIndex = 5;
            // 
            // FrmBaseActionContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(426, 661);
            this.Controls.Add(this.tblContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(442, 700);
            this.Name = "FrmBaseActionContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaseActionContainer";
            this.tblContainer.ResumeLayout(false);
            this.tblContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tblContainer;
        public System.Windows.Forms.Label lblTitle;
        public MaterialSkin.Controls.MaterialRaisedButton btnMainAction;
        public MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        protected System.Windows.Forms.FlowLayoutPanel flyContainer;
    }
}