namespace ООО_Техносервис.View
{
    partial class RequestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestList));
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Мастер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberSearch = new System.Windows.Forms.TextBox();
            this.statusFilter = new System.Windows.Forms.ComboBox();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.buttonEditRequest = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.Location = new System.Drawing.Point(183, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список заявок";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.backButton.Location = new System.Drawing.Point(652, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(154, 46);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnDate,
            this.ColumnDevice,
            this.ColumnClient,
            this.ColumnStatus,
            this.Мастер,
            this.ColumnStage});
            this.dataGridViewRequest.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.Size = new System.Drawing.Size(806, 411);
            this.dataGridViewRequest.TabIndex = 3;
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnID.HeaderText = "Номер заявки";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDate.HeaderText = "Дата заявки";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnDevice
            // 
            this.ColumnDevice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDevice.HeaderText = "Оборудование";
            this.ColumnDevice.Name = "ColumnDevice";
            this.ColumnDevice.ReadOnly = true;
            // 
            // ColumnClient
            // 
            this.ColumnClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClient.HeaderText = "Клиент";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStatus.HeaderText = "Статус";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // Мастер
            // 
            this.Мастер.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Мастер.HeaderText = "Мастер";
            this.Мастер.Name = "Мастер";
            this.Мастер.ReadOnly = true;
            // 
            // ColumnStage
            // 
            this.ColumnStage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStage.HeaderText = "Этап";
            this.ColumnStage.Name = "ColumnStage";
            this.ColumnStage.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(420, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус заявки";
            // 
            // numberSearch
            // 
            this.numberSearch.Location = new System.Drawing.Point(152, 82);
            this.numberSearch.Name = "numberSearch";
            this.numberSearch.Size = new System.Drawing.Size(229, 20);
            this.numberSearch.TabIndex = 6;
            this.numberSearch.TextChanged += new System.EventHandler(this.numberSearch_TextChanged);
            // 
            // statusFilter
            // 
            this.statusFilter.FormattingEnabled = true;
            this.statusFilter.Location = new System.Drawing.Point(564, 82);
            this.statusFilter.Name = "statusFilter";
            this.statusFilter.Size = new System.Drawing.Size(254, 21);
            this.statusFilter.TabIndex = 7;
            this.statusFilter.SelectedIndexChanged += new System.EventHandler(this.statusFilter_SelectedIndexChanged_1);
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAddRequest.Location = new System.Drawing.Point(15, 550);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(243, 51);
            this.buttonAddRequest.TabIndex = 8;
            this.buttonAddRequest.Text = "Добавить новую заявку";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Visible = false;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click_1);
            // 
            // buttonEditRequest
            // 
            this.buttonEditRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonEditRequest.Location = new System.Drawing.Point(294, 550);
            this.buttonEditRequest.Name = "buttonEditRequest";
            this.buttonEditRequest.Size = new System.Drawing.Size(243, 51);
            this.buttonEditRequest.TabIndex = 9;
            this.buttonEditRequest.Text = "Редактировать заявку";
            this.buttonEditRequest.UseVisualStyleBackColor = true;
            this.buttonEditRequest.Visible = false;
            this.buttonEditRequest.Click += new System.EventHandler(this.buttonEditRequest_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonReport.Location = new System.Drawing.Point(575, 550);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(243, 51);
            this.buttonReport.TabIndex = 10;
            this.buttonReport.Text = "Создать отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Visible = false;
            // 
            // RequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 622);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonEditRequest);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.statusFilter);
            this.Controls.Add(this.numberSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRequest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestList";
            this.Text = "Список заявок";
            this.Activated += new System.EventHandler(this.RequestList_Activated);
            this.Load += new System.EventHandler(this.RequestList_Load);
            this.Shown += new System.EventHandler(this.RequestList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Мастер;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberSearch;
        private System.Windows.Forms.ComboBox statusFilter;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.Button buttonEditRequest;
        private System.Windows.Forms.Button buttonReport;
    }
}