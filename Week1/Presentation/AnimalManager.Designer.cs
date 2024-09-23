namespace Week1.Presentation
{
    partial class AnimalManager
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
            AnimalDataGridView = new DataGridView();
            OpenAnimalDetailBtn = new Button();
            SpeakBtn = new Button();
            BornBtn = new Button();
            ProduceMilkBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AnimalDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AnimalDataGridView
            // 
            AnimalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnimalDataGridView.Location = new Point(12, 12);
            AnimalDataGridView.Name = "AnimalDataGridView";
            AnimalDataGridView.RowHeadersWidth = 51;
            AnimalDataGridView.Size = new Size(414, 209);
            AnimalDataGridView.TabIndex = 0;
            // 
            // OpenAnimalDetailBtn
            // 
            OpenAnimalDetailBtn.Location = new Point(12, 247);
            OpenAnimalDetailBtn.Name = "OpenAnimalDetailBtn";
            OpenAnimalDetailBtn.Size = new Size(100, 44);
            OpenAnimalDetailBtn.TabIndex = 1;
            OpenAnimalDetailBtn.Text = "Add";
            OpenAnimalDetailBtn.UseVisualStyleBackColor = true;
            OpenAnimalDetailBtn.Click += OpenAnimalDetailBtn_Click;
            // 
            // SpeakBtn
            // 
            SpeakBtn.Location = new Point(114, 247);
            SpeakBtn.Name = "SpeakBtn";
            SpeakBtn.Size = new Size(100, 44);
            SpeakBtn.TabIndex = 2;
            SpeakBtn.Text = "Speak";
            SpeakBtn.UseVisualStyleBackColor = true;
            SpeakBtn.Click += SpeakBtn_Click;
            // 
            // BornBtn
            // 
            BornBtn.Location = new Point(220, 247);
            BornBtn.Name = "BornBtn";
            BornBtn.Size = new Size(100, 44);
            BornBtn.TabIndex = 4;
            BornBtn.Text = "Born";
            BornBtn.UseVisualStyleBackColor = true;
            BornBtn.Click += BornBtn_Click;
            // 
            // ProduceMilkBtn
            // 
            ProduceMilkBtn.Location = new Point(326, 247);
            ProduceMilkBtn.Name = "ProduceMilkBtn";
            ProduceMilkBtn.Size = new Size(100, 44);
            ProduceMilkBtn.TabIndex = 5;
            ProduceMilkBtn.Text = "ProduceMilk";
            ProduceMilkBtn.UseVisualStyleBackColor = true;
            ProduceMilkBtn.Click += ProduceMilkBtn_Click;
            // 
            // AnimalManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 315);
            Controls.Add(ProduceMilkBtn);
            Controls.Add(BornBtn);
            Controls.Add(SpeakBtn);
            Controls.Add(OpenAnimalDetailBtn);
            Controls.Add(AnimalDataGridView);
            Name = "AnimalManager";
            Text = "AnimalManager";
            Load += AnimalManager_Load;
            ((System.ComponentModel.ISupportInitialize)AnimalDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView AnimalDataGridView;
        private Button OpenAnimalDetailBtn;
        private Button SpeakBtn;
        private Button BornBtn;
        private Button ProduceMilkBtn;
    }
}