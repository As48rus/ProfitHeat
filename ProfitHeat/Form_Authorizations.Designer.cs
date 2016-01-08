namespace ProfitHeat
{
    partial class Form_Аутентификация
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Имя = new System.Windows.Forms.TextBox();
            this.textBox_Пароль = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Имя
            // 
            this.textBox_Имя.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Имя.Location = new System.Drawing.Point(12, 12);
            this.textBox_Имя.Name = "textBox_Имя";
            this.textBox_Имя.Size = new System.Drawing.Size(183, 20);
            this.textBox_Имя.TabIndex = 1;
            this.textBox_Имя.Text = "Имя";
            this.textBox_Имя.Enter += new System.EventHandler(this.textBox_Имя_Enter);
            // 
            // textBox_Пароль
            // 
            this.textBox_Пароль.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Пароль.Location = new System.Drawing.Point(12, 38);
            this.textBox_Пароль.Name = "textBox_Пароль";
            this.textBox_Пароль.Size = new System.Drawing.Size(183, 20);
            this.textBox_Пароль.TabIndex = 2;
            this.textBox_Пароль.Text = "Пароль";
            this.textBox_Пароль.Enter += new System.EventHandler(this.textBox_Пароль_Enter);
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_OK.Location = new System.Drawing.Point(237, 91);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(10, 10);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_Аутентификация
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 75);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_Пароль);
            this.Controls.Add(this.textBox_Имя);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Аутентификация";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Имя;
        private System.Windows.Forms.TextBox textBox_Пароль;
        private System.Windows.Forms.Button button_OK;
    }
}

