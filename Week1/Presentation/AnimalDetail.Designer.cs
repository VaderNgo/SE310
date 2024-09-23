namespace Week1.Presentation
{
    partial class AnimalDetail
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
            AnimalPictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            AnimalTextBox = new TextBox();
            AddAnimalDetail = new Button();
            CancelAnimalDetail = new Button();
            AnimalsComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)AnimalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AnimalPictureBox
            // 
            AnimalPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AnimalPictureBox.Location = new Point(111, 25);
            AnimalPictureBox.Name = "AnimalPictureBox";
            AnimalPictureBox.Size = new Size(100, 100);
            AnimalPictureBox.TabIndex = 0;
            AnimalPictureBox.TabStop = false;
            AnimalPictureBox.Click += AnimalPictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 153);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 2;
            label1.Text = "Type: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 205);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Quantity: ";
            // 
            // AnimalTextBox
            // 
            AnimalTextBox.Location = new Point(111, 202);
            AnimalTextBox.Name = "AnimalTextBox";
            AnimalTextBox.Size = new Size(138, 27);
            AnimalTextBox.TabIndex = 4;
            AnimalTextBox.TextChanged += AnimalTextBox_TextChanged;
            // 
            // AddAnimalDetail
            // 
            AddAnimalDetail.Location = new Point(33, 285);
            AddAnimalDetail.Name = "AddAnimalDetail";
            AddAnimalDetail.Size = new Size(94, 29);
            AddAnimalDetail.TabIndex = 5;
            AddAnimalDetail.Text = "Add";
            AddAnimalDetail.UseVisualStyleBackColor = true;
            AddAnimalDetail.Click += AddAnimalDetail_Click;
            // 
            // CancelAnimalDetail
            // 
            CancelAnimalDetail.Location = new Point(180, 285);
            CancelAnimalDetail.Name = "CancelAnimalDetail";
            CancelAnimalDetail.Size = new Size(94, 29);
            CancelAnimalDetail.TabIndex = 6;
            CancelAnimalDetail.Text = "Cancel";
            CancelAnimalDetail.UseVisualStyleBackColor = true;
            CancelAnimalDetail.Click += CancelAnimalDetail_Click;
            // 
            // AnimalsComboBox
            // 
            AnimalsComboBox.FormattingEnabled = true;
            AnimalsComboBox.Location = new Point(111, 145);
            AnimalsComboBox.Name = "AnimalsComboBox";
            AnimalsComboBox.Size = new Size(138, 28);
            AnimalsComboBox.TabIndex = 7;
            AnimalsComboBox.SelectedIndexChanged += AnimalsComboBox_SelectedIndexChanged;
            // 
            // AnimalDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 342);
            Controls.Add(AnimalsComboBox);
            Controls.Add(CancelAnimalDetail);
            Controls.Add(AddAnimalDetail);
            Controls.Add(AnimalTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AnimalPictureBox);
            MaximizeBox = false;
            Name = "AnimalDetail";
            Text = "AnimalDetail";
            FormClosing += AnimalDetail_FormClosing;
            Load += AnimalDetail_Load;
            ((System.ComponentModel.ISupportInitialize)AnimalPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AnimalPictureBox;
        private Label label1;
        private Label label2;
        private TextBox AnimalTextBox;
        private Button AddAnimalDetail;
        private Button CancelAnimalDetail;
        private ComboBox AnimalsComboBox;
    }
}