namespace ShowArgs {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnShowArgs = new System.Windows.Forms.Button();
            this.lvArgs = new System.Windows.Forms.ListView();
            this.btnClearLV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowArgs
            // 
            this.btnShowArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowArgs.Location = new System.Drawing.Point(13, 13);
            this.btnShowArgs.Name = "btnShowArgs";
            this.btnShowArgs.Size = new System.Drawing.Size(259, 23);
            this.btnShowArgs.TabIndex = 0;
            this.btnShowArgs.Text = "Show Startup Arguments";
            this.btnShowArgs.UseVisualStyleBackColor = true;
            this.btnShowArgs.Click += new System.EventHandler(this.btnShowArgs_Click);
            // 
            // lvArgs
            // 
            this.lvArgs.AllowDrop = true;
            this.lvArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvArgs.Location = new System.Drawing.Point(13, 74);
            this.lvArgs.Name = "lvArgs";
            this.lvArgs.Size = new System.Drawing.Size(260, 297);
            this.lvArgs.TabIndex = 1;
            this.lvArgs.UseCompatibleStateImageBehavior = false;
            this.lvArgs.View = System.Windows.Forms.View.Details;
            this.lvArgs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvArgs_DragDrop);
            this.lvArgs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvArgs_DragEnter);
            // 
            // btnClearLV
            // 
            this.btnClearLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLV.Location = new System.Drawing.Point(13, 45);
            this.btnClearLV.Name = "btnClearLV";
            this.btnClearLV.Size = new System.Drawing.Size(260, 23);
            this.btnClearLV.TabIndex = 2;
            this.btnClearLV.Text = "Clear List";
            this.btnClearLV.UseVisualStyleBackColor = true;
            this.btnClearLV.Click += new System.EventHandler(this.btnClearLV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 383);
            this.Controls.Add(this.btnClearLV);
            this.Controls.Add(this.lvArgs);
            this.Controls.Add(this.btnShowArgs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 422);
            this.Name = "FormMain";
            this.Text = "Argument Util";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowArgs;
        private System.Windows.Forms.ListView lvArgs;
        private System.Windows.Forms.Button btnClearLV;
    }
}