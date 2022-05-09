
namespace Examen.Presentation.Formularios
{
    partial class DetailsHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbldetail = new System.Windows.Forms.Label();
            this.lblDetailValue = new System.Windows.Forms.Label();
            this.lblDetailValue2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldetail
            // 
            this.lbldetail.AutoSize = true;
            this.lbldetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldetail.Location = new System.Drawing.Point(42, 14);
            this.lbldetail.Name = "lbldetail";
            this.lbldetail.Size = new System.Drawing.Size(35, 13);
            this.lbldetail.TabIndex = 0;
            this.lbldetail.Text = "label1";
            this.lbldetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetailValue
            // 
            this.lblDetailValue.AutoSize = true;
            this.lblDetailValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetailValue.Location = new System.Drawing.Point(29, 65);
            this.lblDetailValue.Name = "lblDetailValue";
            this.lblDetailValue.Size = new System.Drawing.Size(60, 18);
            this.lblDetailValue.TabIndex = 1;
            this.lblDetailValue.Text = "label1";
            this.lblDetailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetailValue2
            // 
            this.lblDetailValue2.AutoSize = true;
            this.lblDetailValue2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetailValue2.Location = new System.Drawing.Point(29, 36);
            this.lblDetailValue2.Name = "lblDetailValue2";
            this.lblDetailValue2.Size = new System.Drawing.Size(60, 18);
            this.lblDetailValue2.TabIndex = 2;
            this.lblDetailValue2.Text = "label1";
            this.lblDetailValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetailValue2);
            this.Controls.Add(this.lblDetailValue);
            this.Controls.Add(this.lbldetail);
            this.Name = "DetailsHistory";
            this.Size = new System.Drawing.Size(118, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.Label lblDetailValue;
        private System.Windows.Forms.Label lblDetailValue2;
    }
}
