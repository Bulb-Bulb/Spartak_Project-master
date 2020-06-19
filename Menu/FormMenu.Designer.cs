namespace Spartak_Project
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenMaterials = new System.Windows.Forms.Button();
            this.buttonOpenStaff = new System.Windows.Forms.Button();
            this.buttonOpenStorage = new System.Windows.Forms.Button();
            this.buttonOpenOrders = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenClients.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenClients.ForeColor = System.Drawing.Color.White;
            this.buttonOpenClients.Location = new System.Drawing.Point(12, 114);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonOpenMaterials
            // 
            this.buttonOpenMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.buttonOpenMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenMaterials.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenMaterials.ForeColor = System.Drawing.Color.White;
            this.buttonOpenMaterials.Location = new System.Drawing.Point(12, 156);
            this.buttonOpenMaterials.Name = "buttonOpenMaterials";
            this.buttonOpenMaterials.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenMaterials.TabIndex = 2;
            this.buttonOpenMaterials.Text = "Материалы";
            this.buttonOpenMaterials.UseVisualStyleBackColor = false;
            this.buttonOpenMaterials.Click += new System.EventHandler(this.buttonOpenMaterials_Click);
            // 
            // buttonOpenStaff
            // 
            this.buttonOpenStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.buttonOpenStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenStaff.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenStaff.ForeColor = System.Drawing.Color.White;
            this.buttonOpenStaff.Location = new System.Drawing.Point(12, 198);
            this.buttonOpenStaff.Name = "buttonOpenStaff";
            this.buttonOpenStaff.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenStaff.TabIndex = 3;
            this.buttonOpenStaff.Text = "Сотрудники";
            this.buttonOpenStaff.UseVisualStyleBackColor = false;
            this.buttonOpenStaff.Click += new System.EventHandler(this.buttonOpenStaff_Click);
            // 
            // buttonOpenStorage
            // 
            this.buttonOpenStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.buttonOpenStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenStorage.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenStorage.ForeColor = System.Drawing.Color.White;
            this.buttonOpenStorage.Location = new System.Drawing.Point(12, 240);
            this.buttonOpenStorage.Name = "buttonOpenStorage";
            this.buttonOpenStorage.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenStorage.TabIndex = 4;
            this.buttonOpenStorage.Text = "Склад";
            this.buttonOpenStorage.UseVisualStyleBackColor = false;
            this.buttonOpenStorage.Click += new System.EventHandler(this.buttonOpenStorage_Click);
            // 
            // buttonOpenOrders
            // 
            this.buttonOpenOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.buttonOpenOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenOrders.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOpenOrders.Location = new System.Drawing.Point(12, 282);
            this.buttonOpenOrders.Name = "buttonOpenOrders";
            this.buttonOpenOrders.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenOrders.TabIndex = 5;
            this.buttonOpenOrders.Text = "Заказы";
            this.buttonOpenOrders.UseVisualStyleBackColor = false;
            this.buttonOpenOrders.Click += new System.EventHandler(this.buttonOpenOrders_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Spartak_Project.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(280, 72);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 331);
            this.Controls.Add(this.buttonOpenOrders);
            this.Controls.Add(this.buttonOpenStorage);
            this.Controls.Add(this.buttonOpenStaff);
            this.Controls.Add(this.buttonOpenMaterials);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 370);
            this.MinimumSize = new System.Drawing.Size(320, 370);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenMaterials;
        private System.Windows.Forms.Button buttonOpenStaff;
        private System.Windows.Forms.Button buttonOpenStorage;
        private System.Windows.Forms.Button buttonOpenOrders;
    }
}

