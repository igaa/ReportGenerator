
namespace ReportGenerator
{
    partial class mainform
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
            this._reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this._generate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._reportViewer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _reportViewer
            // 
            this._reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._reportViewer.LocalReport.ReportEmbeddedResource = "ReportGenerator.rdlc.ListCBJournal.rdlc";
            this._reportViewer.Location = new System.Drawing.Point(3, 100);
            this._reportViewer.Name = "_reportViewer";
            this._reportViewer.ServerReport.BearerToken = null;
            this._reportViewer.Size = new System.Drawing.Size(808, 263);
            this._reportViewer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._generate);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 91);
            this.panel1.TabIndex = 1;
            // 
            // _generate
            // 
            this._generate.Location = new System.Drawing.Point(9, 49);
            this._generate.Name = "_generate";
            this._generate.Size = new System.Drawing.Size(75, 23);
            this._generate.TabIndex = 0;
            this._generate.Text = "Generate";
            this._generate.UseVisualStyleBackColor = true;
            this._generate.Click += new System.EventHandler(this._generate_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer _reportViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _generate;
    }
}

