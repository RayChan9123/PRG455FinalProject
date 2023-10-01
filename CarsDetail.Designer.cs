namespace PRG455FInalProject
{
    partial class CarsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsDetail));
            this.confirmBtn = new System.Windows.Forms.Button();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.carDescript1TextBox = new System.Windows.Forms.TextBox();
            this.car2TextBox = new System.Windows.Forms.TextBox();
            this.car3TextBox = new System.Windows.Forms.TextBox();
            this.car4TextBox = new System.Windows.Forms.TextBox();
            this.car5PictureBox = new System.Windows.Forms.PictureBox();
            this.car4PictureBox = new System.Windows.Forms.PictureBox();
            this.car3PictureBox = new System.Windows.Forms.PictureBox();
            this.car2PictureBox = new System.Windows.Forms.PictureBox();
            this.car1PictureBox = new System.Windows.Forms.PictureBox();
            this.car5TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.car5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(566, 340);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(156, 23);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm To Book";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(110, 340);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(75, 23);
            this.goBackBtn.TabIndex = 3;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // carDescript1TextBox
            // 
            this.carDescript1TextBox.Location = new System.Drawing.Point(357, 113);
            this.carDescript1TextBox.Multiline = true;
            this.carDescript1TextBox.Name = "carDescript1TextBox";
            this.carDescript1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.carDescript1TextBox.Size = new System.Drawing.Size(365, 157);
            this.carDescript1TextBox.TabIndex = 1;
            this.carDescript1TextBox.Text = resources.GetString("carDescript1TextBox.Text");
            // 
            // car2TextBox
            // 
            this.car2TextBox.Location = new System.Drawing.Point(357, 113);
            this.car2TextBox.Multiline = true;
            this.car2TextBox.Name = "car2TextBox";
            this.car2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.car2TextBox.Size = new System.Drawing.Size(365, 157);
            this.car2TextBox.TabIndex = 5;
            this.car2TextBox.Text = resources.GetString("car2TextBox.Text");
            // 
            // car3TextBox
            // 
            this.car3TextBox.Location = new System.Drawing.Point(357, 113);
            this.car3TextBox.Multiline = true;
            this.car3TextBox.Name = "car3TextBox";
            this.car3TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.car3TextBox.Size = new System.Drawing.Size(365, 157);
            this.car3TextBox.TabIndex = 7;
            this.car3TextBox.Text = resources.GetString("car3TextBox.Text");
            // 
            // car4TextBox
            // 
            this.car4TextBox.Location = new System.Drawing.Point(357, 113);
            this.car4TextBox.Multiline = true;
            this.car4TextBox.Name = "car4TextBox";
            this.car4TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.car4TextBox.Size = new System.Drawing.Size(365, 157);
            this.car4TextBox.TabIndex = 9;
            this.car4TextBox.Text = "Car\'s Description\r\n\r\nCoupe\r\n\r\nA coupe is defined as a closed roof, 2-door passeng" +
    "er car with a three-box\r\n body for the engine and the passenger compartment.\r\n\r\n" +
    "Color: Red\r\n\r\nPrice: 100";
            // 
            // car5PictureBox
            // 
            this.car5PictureBox.Image = global::PRG455FInalProject.Properties.Resources.muv1;
            this.car5PictureBox.Location = new System.Drawing.Point(110, 113);
            this.car5PictureBox.Name = "car5PictureBox";
            this.car5PictureBox.Size = new System.Drawing.Size(197, 157);
            this.car5PictureBox.TabIndex = 10;
            this.car5PictureBox.TabStop = false;
            // 
            // car4PictureBox
            // 
            this.car4PictureBox.Image = global::PRG455FInalProject.Properties.Resources.coupe;
            this.car4PictureBox.Location = new System.Drawing.Point(110, 113);
            this.car4PictureBox.Name = "car4PictureBox";
            this.car4PictureBox.Size = new System.Drawing.Size(197, 157);
            this.car4PictureBox.TabIndex = 8;
            this.car4PictureBox.TabStop = false;
            // 
            // car3PictureBox
            // 
            this.car3PictureBox.Image = global::PRG455FInalProject.Properties.Resources.suv2;
            this.car3PictureBox.Location = new System.Drawing.Point(110, 113);
            this.car3PictureBox.Name = "car3PictureBox";
            this.car3PictureBox.Size = new System.Drawing.Size(197, 157);
            this.car3PictureBox.TabIndex = 6;
            this.car3PictureBox.TabStop = false;
            // 
            // car2PictureBox
            // 
            this.car2PictureBox.Image = global::PRG455FInalProject.Properties.Resources.muv2;
            this.car2PictureBox.Location = new System.Drawing.Point(110, 113);
            this.car2PictureBox.Name = "car2PictureBox";
            this.car2PictureBox.Size = new System.Drawing.Size(197, 157);
            this.car2PictureBox.TabIndex = 4;
            this.car2PictureBox.TabStop = false;
            // 
            // car1PictureBox
            // 
            this.car1PictureBox.Image = global::PRG455FInalProject.Properties.Resources.suv1;
            this.car1PictureBox.Location = new System.Drawing.Point(110, 113);
            this.car1PictureBox.Name = "car1PictureBox";
            this.car1PictureBox.Size = new System.Drawing.Size(197, 157);
            this.car1PictureBox.TabIndex = 0;
            this.car1PictureBox.TabStop = false;
            // 
            // car5TextBox
            // 
            this.car5TextBox.Location = new System.Drawing.Point(357, 113);
            this.car5TextBox.Multiline = true;
            this.car5TextBox.Name = "car5TextBox";
            this.car5TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.car5TextBox.Size = new System.Drawing.Size(365, 157);
            this.car5TextBox.TabIndex = 11;
            this.car5TextBox.Text = resources.GetString("car5TextBox.Text");
            // 
            // CarsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.car5TextBox);
            this.Controls.Add(this.car5PictureBox);
            this.Controls.Add(this.car4TextBox);
            this.Controls.Add(this.car4PictureBox);
            this.Controls.Add(this.car3TextBox);
            this.Controls.Add(this.car3PictureBox);
            this.Controls.Add(this.car2TextBox);
            this.Controls.Add(this.car2PictureBox);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.carDescript1TextBox);
            this.Controls.Add(this.car1PictureBox);
            this.Name = "CarsDetail";
            this.Text = "Ray\'s Cars Rental";
            ((System.ComponentModel.ISupportInitialize)(this.car5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox car1PictureBox;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.TextBox carDescript1TextBox;
        private System.Windows.Forms.PictureBox car2PictureBox;
        private System.Windows.Forms.TextBox car2TextBox;
        private System.Windows.Forms.PictureBox car3PictureBox;
        private System.Windows.Forms.TextBox car3TextBox;
        private System.Windows.Forms.PictureBox car4PictureBox;
        private System.Windows.Forms.TextBox car4TextBox;
        private System.Windows.Forms.PictureBox car5PictureBox;
        private System.Windows.Forms.TextBox car5TextBox;
    }
}