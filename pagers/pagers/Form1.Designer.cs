namespace pagers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.downButton = new FontAwesome.Sharp.IconButton();
            this.upButton = new FontAwesome.Sharp.IconButton();
            this.rightButton = new FontAwesome.Sharp.IconButton();
            this.leftButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.watchButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("a_LCDNova", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1, 1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(420, 130);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.downButton);
            this.panel1.Controls.Add(this.upButton);
            this.panel1.Controls.Add(this.rightButton);
            this.panel1.Controls.Add(this.leftButton);
            this.panel1.Location = new System.Drawing.Point(181, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 100);
            this.panel1.TabIndex = 3;
            // 
            // downButton
            // 
            this.downButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downButton.FlatAppearance.BorderSize = 0;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.downButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.downButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.downButton.IconSize = 60;
            this.downButton.Location = new System.Drawing.Point(80, 50);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(80, 50);
            this.downButton.TabIndex = 7;
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.upButton.FlatAppearance.BorderSize = 0;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.upButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.upButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.upButton.IconSize = 60;
            this.upButton.Location = new System.Drawing.Point(80, 0);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(80, 50);
            this.upButton.TabIndex = 6;
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightButton.FlatAppearance.BorderSize = 0;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.IconChar = FontAwesome.Sharp.IconChar.CaretSquareRight;
            this.rightButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.rightButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.rightButton.IconSize = 100;
            this.rightButton.Location = new System.Drawing.Point(160, 0);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(80, 100);
            this.rightButton.TabIndex = 5;
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // leftButton
            // 
            this.leftButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftButton.FlatAppearance.BorderSize = 0;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.IconChar = FontAwesome.Sharp.IconChar.CaretSquareLeft;
            this.leftButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.leftButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.leftButton.IconSize = 100;
            this.leftButton.Location = new System.Drawing.Point(0, 0);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(80, 100);
            this.leftButton.TabIndex = 4;
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.watchButton);
            this.panel2.Location = new System.Drawing.Point(1, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 100);
            this.panel2.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteButton.IconColor = System.Drawing.Color.IndianRed;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.deleteButton.IconSize = 100;
            this.deleteButton.Location = new System.Drawing.Point(85, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 100);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // watchButton
            // 
            this.watchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.watchButton.FlatAppearance.BorderSize = 0;
            this.watchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchButton.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.watchButton.IconColor = System.Drawing.Color.YellowGreen;
            this.watchButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.watchButton.IconSize = 100;
            this.watchButton.Location = new System.Drawing.Point(0, 0);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(85, 100);
            this.watchButton.TabIndex = 5;
            this.watchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(422, 241);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pager | by Alexander Seleznev";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton leftButton;
        private FontAwesome.Sharp.IconButton rightButton;
        private FontAwesome.Sharp.IconButton upButton;
        private FontAwesome.Sharp.IconButton downButton;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton watchButton;
        private FontAwesome.Sharp.IconButton deleteButton;
    }
}

