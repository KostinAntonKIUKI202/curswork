namespace Coursework_Kostin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonFlash = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFlash = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonUnlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(147, 109);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(73, 54);
            this.buttonFolder.TabIndex = 0;
            this.buttonFolder.Text = "Choose folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonFlash
            // 
            this.buttonFlash.Location = new System.Drawing.Point(226, 109);
            this.buttonFlash.Name = "buttonFlash";
            this.buttonFlash.Size = new System.Drawing.Size(73, 54);
            this.buttonFlash.TabIndex = 1;
            this.buttonFlash.Text = "Choose FLASH";
            this.buttonFlash.UseVisualStyleBackColor = true;
            this.buttonFlash.Click += new System.EventHandler(this.buttonFlash_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(305, 109);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(73, 54);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Protect folder";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected folder path: ";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(179, 37);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(23, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selected FLASH device:";
            // 
            // labelFlash
            // 
            this.labelFlash.AutoSize = true;
            this.labelFlash.Location = new System.Drawing.Point(194, 67);
            this.labelFlash.Name = "labelFlash";
            this.labelFlash.Size = new System.Drawing.Size(23, 13);
            this.labelFlash.TabIndex = 6;
            this.labelFlash.Text = "null";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(68, 109);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(73, 54);
            this.buttonClean.TabIndex = 7;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonUnlock
            // 
            this.buttonUnlock.Location = new System.Drawing.Point(384, 109);
            this.buttonUnlock.MaximumSize = new System.Drawing.Size(73, 54);
            this.buttonUnlock.MinimumSize = new System.Drawing.Size(73, 54);
            this.buttonUnlock.Name = "buttonUnlock";
            this.buttonUnlock.Size = new System.Drawing.Size(73, 54);
            this.buttonUnlock.TabIndex = 8;
            this.buttonUnlock.Text = "Unlock";
            this.buttonUnlock.UseVisualStyleBackColor = true;
            this.buttonUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.buttonUnlock);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.labelFlash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonFlash);
            this.Controls.Add(this.buttonFolder);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 250);
            this.MinimumSize = new System.Drawing.Size(550, 250);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder locker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonFlash;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFlash;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonUnlock;
    }
}

