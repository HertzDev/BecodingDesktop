﻿namespace BecodingDesktop.Views.Base
{
    partial class FrmBasicCatalogContainer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleTotal = new System.Windows.Forms.Label();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.rdoActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoInactive = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitleTotal, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbFilters, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgvCatalog, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoActive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdoInactive, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCount, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitleTotal
            // 
            this.lblTitleTotal.AutoSize = true;
            this.lblTitleTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTotal.Location = new System.Drawing.Point(532, 420);
            this.lblTitleTotal.Name = "lblTitleTotal";
            this.lblTitleTotal.Size = new System.Drawing.Size(153, 20);
            this.lblTitleTotal.TabIndex = 10;
            this.lblTitleTotal.Text = "Total de Resultados:";
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Hint = "Ingrese nombre";
            this.txtName.Location = new System.Drawing.Point(13, 62);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(394, 23);
            this.txtName.TabIndex = 4;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(13, 106);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(84, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtSearch, 2);
            this.txtSearch.Depth = 0;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Hint = "Ingrese una palabra para buscar";
            this.txtSearch.Location = new System.Drawing.Point(521, 153);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(266, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // cmbFilters
            // 
            this.cmbFilters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tableLayoutPanel1.SetColumnSpan(this.cmbFilters, 2);
            this.cmbFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Location = new System.Drawing.Point(521, 187);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(266, 21);
            this.cmbFilters.TabIndex = 6;
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCatalog, 4);
            this.dgvCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatalog.Location = new System.Drawing.Point(13, 222);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.Size = new System.Drawing.Size(774, 195);
            this.dgvCatalog.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(13, 10);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(59, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TITULO";
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Depth = 0;
            this.rdoActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoActive.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoActive.Location = new System.Drawing.Point(410, 59);
            this.rdoActive.Margin = new System.Windows.Forms.Padding(0);
            this.rdoActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Ripple = true;
            this.rdoActive.Size = new System.Drawing.Size(108, 44);
            this.rdoActive.TabIndex = 8;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Activo";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // rdoInactive
            // 
            this.rdoInactive.AutoSize = true;
            this.rdoInactive.Depth = 0;
            this.rdoInactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoInactive.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoInactive.Location = new System.Drawing.Point(518, 59);
            this.rdoInactive.Margin = new System.Windows.Forms.Padding(0);
            this.rdoInactive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoInactive.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoInactive.Name = "rdoInactive";
            this.rdoInactive.Ripple = true;
            this.rdoInactive.Size = new System.Drawing.Size(170, 44);
            this.rdoInactive.TabIndex = 9;
            this.rdoInactive.TabStop = true;
            this.rdoInactive.Text = "Inactivo";
            this.rdoInactive.UseVisualStyleBackColor = true;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(691, 420);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(16, 16);
            this.lblTotalCount.TabIndex = 11;
            this.lblTotalCount.Text = "0";
            // 
            // FrmBasicCatalogContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBasicCatalogContainer";
            this.ShowIcon = false;
            this.Text = "FrmBasicCatalogContainer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        protected MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        protected System.Windows.Forms.ComboBox cmbFilters;
        protected System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.Label lblTitleTotal;
        public System.Windows.Forms.Label lblTotalCount;
        protected MaterialSkin.Controls.MaterialRadioButton rdoActive;
        protected MaterialSkin.Controls.MaterialRadioButton rdoInactive;
    }
}