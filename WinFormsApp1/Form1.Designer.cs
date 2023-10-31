namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            connectionText = new Label();
            dataGrid = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // connectionText
            // 
            connectionText.AutoSize = true;
            connectionText.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            connectionText.ForeColor = SystemColors.ActiveCaptionText;
            connectionText.Location = new Point(487, 9);
            connectionText.Name = "connectionText";
            connectionText.Size = new Size(320, 22);
            connectionText.TabIndex = 0;
            connectionText.Text = "Conectando no banco de dados...";
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(35, 319);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(1080, 301);
            dataGrid.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(188, 95);
            button1.Name = "button1";
            button1.Size = new Size(134, 78);
            button1.TabIndex = 2;
            button1.Text = "Primeiro select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(818, 95);
            button2.Name = "button2";
            button2.Size = new Size(134, 78);
            button2.TabIndex = 3;
            button2.Text = "Segundo Select";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 646);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGrid);
            Controls.Add(connectionText);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App Checkpoint";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label connectionText;
        private DataGridView dataGrid;
        private Button button1;
        private Button button2;
    }
}