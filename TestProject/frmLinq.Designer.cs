
namespace TestProject
{
  partial class frmLinq
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
      this.dgPersons = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtCity = new System.Windows.Forms.TextBox();
      this.txtZipCode = new System.Windows.Forms.TextBox();
      this.lblResult = new System.Windows.Forms.Label();
      this.btnSum = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgPersons)).BeginInit();
      this.SuspendLayout();
      // 
      // dgPersons
      // 
      this.dgPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgPersons.Location = new System.Drawing.Point(12, 1);
      this.dgPersons.Name = "dgPersons";
      this.dgPersons.Size = new System.Drawing.Size(776, 239);
      this.dgPersons.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 254);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(24, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "City";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(209, 254);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "ZipCode";
      // 
      // txtCity
      // 
      this.txtCity.Location = new System.Drawing.Point(53, 251);
      this.txtCity.Name = "txtCity";
      this.txtCity.Size = new System.Drawing.Size(100, 20);
      this.txtCity.TabIndex = 3;
      // 
      // txtZipCode
      // 
      this.txtZipCode.Location = new System.Drawing.Point(286, 251);
      this.txtZipCode.Name = "txtZipCode";
      this.txtZipCode.Size = new System.Drawing.Size(100, 20);
      this.txtZipCode.TabIndex = 4;
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Location = new System.Drawing.Point(12, 293);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(47, 13);
      this.lblResult.TabIndex = 5;
      this.lblResult.Text = "ZipCode";
      // 
      // btnSum
      // 
      this.btnSum.Location = new System.Drawing.Point(648, 249);
      this.btnSum.Name = "btnSum";
      this.btnSum.Size = new System.Drawing.Size(75, 23);
      this.btnSum.TabIndex = 6;
      this.btnSum.Text = "SUM";
      this.btnSum.UseVisualStyleBackColor = true;
      this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
      // 
      // frmLinq
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnSum);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.txtZipCode);
      this.Controls.Add(this.txtCity);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgPersons);
      this.Name = "frmLinq";
      this.Text = "LinqTest";
      this.Load += new System.EventHandler(this.frmLinq_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgPersons)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgPersons;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.TextBox txtZipCode;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.Button btnSum;
  }
}