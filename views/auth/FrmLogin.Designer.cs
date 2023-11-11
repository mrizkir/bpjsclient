namespace bpjsclient.views.auth
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.BPJS_CONS_ID_VCLAIM = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BPJS_USER_KEY_VCLAIM = new System.Windows.Forms.TextBox();
            this.BPJS_SECRET_KEY_VCLAIM = new System.Windows.Forms.TextBox();
            this.BPJS_CONS_ID_ANTROL = new System.Windows.Forms.TextBox();
            this.BPJS_USER_KEY_ANTROL = new System.Windows.Forms.TextBox();
            this.BPJS_SECRET_KEY_ANTROL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BPJS_CONS_ID_VCLAIM
            // 
            this.BPJS_CONS_ID_VCLAIM.Location = new System.Drawing.Point(153, 100);
            this.BPJS_CONS_ID_VCLAIM.Name = "BPJS_CONS_ID_VCLAIM";
            this.BPJS_CONS_ID_VCLAIM.Size = new System.Drawing.Size(286, 22);
            this.BPJS_CONS_ID_VCLAIM.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BPJS_USER_KEY_VCLAIM
            // 
            this.BPJS_USER_KEY_VCLAIM.Location = new System.Drawing.Point(153, 139);
            this.BPJS_USER_KEY_VCLAIM.Name = "BPJS_USER_KEY_VCLAIM";
            this.BPJS_USER_KEY_VCLAIM.Size = new System.Drawing.Size(286, 22);
            this.BPJS_USER_KEY_VCLAIM.TabIndex = 2;
            // 
            // BPJS_SECRET_KEY_VCLAIM
            // 
            this.BPJS_SECRET_KEY_VCLAIM.Location = new System.Drawing.Point(153, 183);
            this.BPJS_SECRET_KEY_VCLAIM.Name = "BPJS_SECRET_KEY_VCLAIM";
            this.BPJS_SECRET_KEY_VCLAIM.Size = new System.Drawing.Size(286, 22);
            this.BPJS_SECRET_KEY_VCLAIM.TabIndex = 3;
            // 
            // BPJS_CONS_ID_ANTROL
            // 
            this.BPJS_CONS_ID_ANTROL.Location = new System.Drawing.Point(153, 247);
            this.BPJS_CONS_ID_ANTROL.Name = "BPJS_CONS_ID_ANTROL";
            this.BPJS_CONS_ID_ANTROL.Size = new System.Drawing.Size(286, 22);
            this.BPJS_CONS_ID_ANTROL.TabIndex = 4;
            // 
            // BPJS_USER_KEY_ANTROL
            // 
            this.BPJS_USER_KEY_ANTROL.Location = new System.Drawing.Point(153, 306);
            this.BPJS_USER_KEY_ANTROL.Name = "BPJS_USER_KEY_ANTROL";
            this.BPJS_USER_KEY_ANTROL.Size = new System.Drawing.Size(286, 22);
            this.BPJS_USER_KEY_ANTROL.TabIndex = 5;
            // 
            // BPJS_SECRET_KEY_ANTROL
            // 
            this.BPJS_SECRET_KEY_ANTROL.Location = new System.Drawing.Point(153, 374);
            this.BPJS_SECRET_KEY_ANTROL.Name = "BPJS_SECRET_KEY_ANTROL";
            this.BPJS_SECRET_KEY_ANTROL.Size = new System.Drawing.Size(286, 22);
            this.BPJS_SECRET_KEY_ANTROL.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.BPJS_SECRET_KEY_ANTROL);
            this.Controls.Add(this.BPJS_USER_KEY_ANTROL);
            this.Controls.Add(this.BPJS_CONS_ID_ANTROL);
            this.Controls.Add(this.BPJS_SECRET_KEY_VCLAIM);
            this.Controls.Add(this.BPJS_USER_KEY_VCLAIM);
            this.Controls.Add(this.BPJS_CONS_ID_VCLAIM);
            this.Name = "FrmLogin";
            this.Text = "BPJS Client - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BPJS_CONS_ID_VCLAIM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox BPJS_USER_KEY_VCLAIM;
        private System.Windows.Forms.TextBox BPJS_SECRET_KEY_VCLAIM;
        private System.Windows.Forms.TextBox BPJS_CONS_ID_ANTROL;
        private System.Windows.Forms.TextBox BPJS_USER_KEY_ANTROL;
        private System.Windows.Forms.TextBox BPJS_SECRET_KEY_ANTROL;
    }
}