namespace Calculadora_Windows
{
    partial class Calculadora_windows
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSomar = new System.Windows.Forms.Label();
            this.lblDiminuir = new System.Windows.Forms.Label();
            this.lblMult = new System.Windows.Forms.Label();
            this.lblDividir = new System.Windows.Forms.Label();
            this.lblZerar = new System.Windows.Forms.Label();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVirgula = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(45)))), ((int)(((byte)(103)))));
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(9, 6);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(285, 59);
            this.display.TabIndex = 10;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(23)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblSomar, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblDiminuir, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblMult, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDividir, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblZerar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(217, 70);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(87, 313);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblSomar
            // 
            this.lblSomar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSomar.AutoSize = true;
            this.lblSomar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSomar.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomar.ForeColor = System.Drawing.Color.White;
            this.lblSomar.Location = new System.Drawing.Point(14, 254);
            this.lblSomar.Name = "lblSomar";
            this.lblSomar.Size = new System.Drawing.Size(59, 53);
            this.lblSomar.TabIndex = 7;
            this.lblSomar.Text = "+";
            this.lblSomar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSomar.Click += new System.EventHandler(this.lblSomar_Click);
            // 
            // lblDiminuir
            // 
            this.lblDiminuir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiminuir.AutoSize = true;
            this.lblDiminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDiminuir.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiminuir.ForeColor = System.Drawing.Color.White;
            this.lblDiminuir.Location = new System.Drawing.Point(21, 190);
            this.lblDiminuir.Name = "lblDiminuir";
            this.lblDiminuir.Size = new System.Drawing.Size(44, 53);
            this.lblDiminuir.TabIndex = 6;
            this.lblDiminuir.Text = "-";
            this.lblDiminuir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiminuir.Click += new System.EventHandler(this.lblDiminuir_Click);
            // 
            // lblMult
            // 
            this.lblMult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMult.AutoSize = true;
            this.lblMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMult.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMult.ForeColor = System.Drawing.Color.White;
            this.lblMult.Location = new System.Drawing.Point(17, 128);
            this.lblMult.Name = "lblMult";
            this.lblMult.Size = new System.Drawing.Size(53, 53);
            this.lblMult.TabIndex = 5;
            this.lblMult.Text = "X";
            this.lblMult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMult.Click += new System.EventHandler(this.lblMult_Click);
            // 
            // lblDividir
            // 
            this.lblDividir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDividir.AutoSize = true;
            this.lblDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDividir.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividir.ForeColor = System.Drawing.Color.White;
            this.lblDividir.Location = new System.Drawing.Point(21, 66);
            this.lblDividir.Name = "lblDividir";
            this.lblDividir.Size = new System.Drawing.Size(44, 53);
            this.lblDividir.TabIndex = 4;
            this.lblDividir.Text = "/";
            this.lblDividir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDividir.Click += new System.EventHandler(this.lblDividir_Click);
            // 
            // lblZerar
            // 
            this.lblZerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZerar.AutoSize = true;
            this.lblZerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblZerar.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZerar.ForeColor = System.Drawing.Color.White;
            this.lblZerar.Location = new System.Drawing.Point(16, 4);
            this.lblZerar.Name = "lblZerar";
            this.lblZerar.Size = new System.Drawing.Size(54, 53);
            this.lblZerar.TabIndex = 3;
            this.lblZerar.Text = "C";
            this.lblZerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblZerar.Click += new System.EventHandler(this.lblZerar_Click);
            // 
            // lblCalcular
            // 
            this.lblCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcular.ForeColor = System.Drawing.Color.White;
            this.lblCalcular.Location = new System.Drawing.Point(144, 239);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(59, 53);
            this.lblCalcular.TabIndex = 11;
            this.lblCalcular.Text = "=";
            this.lblCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCalcular.Click += new System.EventHandler(this.lblCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(45)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.display);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 70);
            this.panel1.TabIndex = 6;
            // 
            // lblVirgula
            // 
            this.lblVirgula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVirgula.AutoSize = true;
            this.lblVirgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVirgula.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirgula.ForeColor = System.Drawing.Color.White;
            this.lblVirgula.Location = new System.Drawing.Point(83, 239);
            this.lblVirgula.Name = "lblVirgula";
            this.lblVirgula.Size = new System.Drawing.Size(40, 53);
            this.lblVirgula.TabIndex = 10;
            this.lblVirgula.Text = ".";
            this.lblVirgula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVirgula.Click += new System.EventHandler(this.lblVirgula_Click);
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoSize = true;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl3.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(148, 163);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(51, 53);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "3";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl2.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(78, 163);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(51, 53);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "2";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(9, 163);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 53);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "1";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl6
            // 
            this.lbl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl6.AutoSize = true;
            this.lbl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl6.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(148, 87);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(51, 53);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "6";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // lbl5
            // 
            this.lbl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5.AutoSize = true;
            this.lbl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl5.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(78, 87);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(51, 53);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "5";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4.AutoSize = true;
            this.lbl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl4.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(9, 87);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(51, 53);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "4";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // lbl9
            // 
            this.lbl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl9.AutoSize = true;
            this.lbl9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl9.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.ForeColor = System.Drawing.Color.White;
            this.lbl9.Location = new System.Drawing.Point(148, 11);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(51, 53);
            this.lbl9.TabIndex = 2;
            this.lbl9.Text = "9";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl9.Click += new System.EventHandler(this.lbl9_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblCalcular, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVirgula, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(209, 304);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbl0
            // 
            this.lbl0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl0.AutoSize = true;
            this.lbl0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl0.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.Color.White;
            this.lbl0.Location = new System.Drawing.Point(9, 239);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(51, 53);
            this.lbl0.TabIndex = 9;
            this.lbl0.Text = "0";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl0.Click += new System.EventHandler(this.lbl0_Click);
            // 
            // lbl8
            // 
            this.lbl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl8.AutoSize = true;
            this.lbl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl8.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(78, 11);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(51, 53);
            this.lbl8.TabIndex = 1;
            this.lbl8.Text = "8";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl8.Click += new System.EventHandler(this.lbl8_Click);
            // 
            // lbl7
            // 
            this.lbl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl7.AutoSize = true;
            this.lbl7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl7.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(9, 11);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(51, 53);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "7";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // Calculadora_windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 387);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calculadora_windows";
            this.Text = "Calculadora Windows";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSomar;
        private System.Windows.Forms.Label lblDiminuir;
        private System.Windows.Forms.Label lblMult;
        private System.Windows.Forms.Label lblDividir;
        private System.Windows.Forms.Label lblZerar;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVirgula;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
    }
}

