namespace DatabaseINC
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
            Connect = new Button();
            CreateDatabase = new Button();
            CreateTable = new Button();
            Disconnect = new Button();
            SuspendLayout();
            // 
            // Connect
            // 
            Connect.Location = new Point(301, 46);
            Connect.Name = "Connect";
            Connect.Size = new Size(200, 40);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // CreateDatabase
            // 
            CreateDatabase.Location = new Point(301, 103);
            CreateDatabase.Name = "CreateDatabase";
            CreateDatabase.Size = new Size(200, 40);
            CreateDatabase.TabIndex = 1;
            CreateDatabase.Text = "Create Database";
            CreateDatabase.UseVisualStyleBackColor = true;
            CreateDatabase.Click += CreateDatabase_Click;
            // 
            // CreateTable
            // 
            CreateTable.Location = new Point(301, 161);
            CreateTable.Name = "CreateTable";
            CreateTable.Size = new Size(200, 40);
            CreateTable.TabIndex = 2;
            CreateTable.Text = "Create Table";
            CreateTable.UseVisualStyleBackColor = true;
            CreateTable.Click += CreateTable_Click;
            // 
            // Disconnect
            // 
            Disconnect.Location = new Point(301, 218);
            Disconnect.Name = "Disconnect";
            Disconnect.Size = new Size(200, 40);
            Disconnect.TabIndex = 3;
            Disconnect.Text = "Disconnect";
            Disconnect.UseVisualStyleBackColor = true;
            Disconnect.Click += Disconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Disconnect);
            Controls.Add(CreateTable);
            Controls.Add(CreateDatabase);
            Controls.Add(Connect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Connect;
        private Button CreateDatabase;
        private Button CreateTable;
        private Button Disconnect;
    }
}
