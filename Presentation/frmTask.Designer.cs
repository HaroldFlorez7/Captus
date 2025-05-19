namespace Presentation
{
    partial class frmTask
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelFull = new System.Windows.Forms.Panel();
            this.btnGuardarTaskList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Honeydew;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(841, 38);
            this.panelTop.TabIndex = 0;
            // 
            // panelFull
            // 
            this.panelFull.BackColor = System.Drawing.Color.Honeydew;
            this.panelFull.Controls.Add(this.btnGuardarTaskList);
            this.panelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFull.Location = new System.Drawing.Point(0, 38);
            this.panelFull.Name = "panelFull";
            this.panelFull.Size = new System.Drawing.Size(841, 508);
            this.panelFull.TabIndex = 1;
            // 
            // btnGuardarTaskList
            // 
            this.btnGuardarTaskList.BackColor = System.Drawing.Color.Green;
            this.btnGuardarTaskList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarTaskList.FlatAppearance.BorderSize = 0;
            this.btnGuardarTaskList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarTaskList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTaskList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTaskList.ForeColor = System.Drawing.Color.Honeydew;
            this.btnGuardarTaskList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarTaskList.Location = new System.Drawing.Point(320, 383);
            this.btnGuardarTaskList.Name = "btnGuardarTaskList";
            this.btnGuardarTaskList.Size = new System.Drawing.Size(200, 40);
            this.btnGuardarTaskList.TabIndex = 42;
            this.btnGuardarTaskList.Text = "Guardar";
            this.btnGuardarTaskList.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "TaskList";
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 546);
            this.Controls.Add(this.panelFull);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTask";
            this.Text = "frmTask";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFull.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFull;
        private System.Windows.Forms.Button btnGuardarTaskList;
        private System.Windows.Forms.Label label1;
    }
}