namespace Trvel
{
    partial class form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            this.btnFlight = new System.Windows.Forms.Button();
            this.btnHotels = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnBlog = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBoxFlight = new System.Windows.Forms.GroupBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPassenger = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblDepartDate = new System.Windows.Forms.Label();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonRound = new System.Windows.Forms.RadioButton();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.groupBoxFlight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFlight
            // 
            this.btnFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlight.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFlight.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFlight.Location = new System.Drawing.Point(765, 168);
            this.btnFlight.Name = "btnFlight";
            this.btnFlight.Size = new System.Drawing.Size(113, 52);
            this.btnFlight.TabIndex = 0;
            this.btnFlight.Text = "Flights";
            this.btnFlight.UseVisualStyleBackColor = false;
            this.btnFlight.Click += new System.EventHandler(this.btnFlight_Click);
            // 
            // btnHotels
            // 
            this.btnHotels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotels.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotels.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHotels.Location = new System.Drawing.Point(943, 168);
            this.btnHotels.Name = "btnHotels";
            this.btnHotels.Size = new System.Drawing.Size(113, 52);
            this.btnHotels.TabIndex = 1;
            this.btnHotels.Text = "Hotels";
            this.btnHotels.UseVisualStyleBackColor = false;
            // 
            // btnCars
            // 
            this.btnCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCars.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCars.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCars.Location = new System.Drawing.Point(1114, 168);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(113, 52);
            this.btnCars.TabIndex = 2;
            this.btnCars.Text = "Cars";
            this.btnCars.UseVisualStyleBackColor = false;
            // 
            // btnBlog
            // 
            this.btnBlog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlog.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlog.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBlog.Location = new System.Drawing.Point(1287, 168);
            this.btnBlog.Name = "btnBlog";
            this.btnBlog.Size = new System.Drawing.Size(113, 52);
            this.btnBlog.TabIndex = 3;
            this.btnBlog.Text = "Blog";
            this.btnBlog.UseVisualStyleBackColor = false;
            this.btnBlog.Click += new System.EventHandler(this.btnBlog_Click);
            // 
            // groupBoxFlight
            // 
            this.groupBoxFlight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxFlight.Controls.Add(this.btnSubmitRequest);
            this.groupBoxFlight.Controls.Add(this.dateTimePickerReturn);
            this.groupBoxFlight.Controls.Add(this.dateTimePickerDepart);
            this.groupBoxFlight.Controls.Add(this.comboBoxPassenger);
            this.groupBoxFlight.Controls.Add(this.comboBoxClass);
            this.groupBoxFlight.Controls.Add(this.comboBoxTo);
            this.groupBoxFlight.Controls.Add(this.comboBoxFrom);
            this.groupBoxFlight.Controls.Add(this.lblReturnDate);
            this.groupBoxFlight.Controls.Add(this.lblDepartDate);
            this.groupBoxFlight.Controls.Add(this.lblPassenger);
            this.groupBoxFlight.Controls.Add(this.lblClass);
            this.groupBoxFlight.Controls.Add(this.lblTo);
            this.groupBoxFlight.Controls.Add(this.lblFrom);
            this.groupBoxFlight.Controls.Add(this.panel1);
            this.groupBoxFlight.Controls.Add(this.lblType);
            this.groupBoxFlight.Location = new System.Drawing.Point(545, 259);
            this.groupBoxFlight.Name = "groupBoxFlight";
            this.groupBoxFlight.Size = new System.Drawing.Size(1003, 724);
            this.groupBoxFlight.TabIndex = 4;
            this.groupBoxFlight.TabStop = false;
            this.groupBoxFlight.Text = "Flights";
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitRequest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmitRequest.Location = new System.Drawing.Point(714, 546);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(252, 69);
            this.btnSubmitRequest.TabIndex = 19;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReturn.Location = new System.Drawing.Point(742, 265);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(224, 29);
            this.dateTimePickerReturn.TabIndex = 18;
            // 
            // dateTimePickerDepart
            // 
            this.dateTimePickerDepart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDepart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDepart.Location = new System.Drawing.Point(742, 166);
            this.dateTimePickerDepart.Name = "dateTimePickerDepart";
            this.dateTimePickerDepart.Size = new System.Drawing.Size(224, 29);
            this.dateTimePickerDepart.TabIndex = 5;
            // 
            // comboBoxPassenger
            // 
            this.comboBoxPassenger.FormattingEnabled = true;
            this.comboBoxPassenger.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxPassenger.Location = new System.Drawing.Point(236, 471);
            this.comboBoxPassenger.Name = "comboBoxPassenger";
            this.comboBoxPassenger.Size = new System.Drawing.Size(275, 24);
            this.comboBoxPassenger.TabIndex = 17;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "Economy",
            "Premium Economy",
            "Business",
            "First"});
            this.comboBoxClass.Location = new System.Drawing.Point(236, 364);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(275, 24);
            this.comboBoxClass.TabIndex = 16;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "LaGuardia Airport (LGA)",
            "John F Kennedy Intl Airport (JFK)",
            "Newark Liberty Intl Airport (EWR)",
            "Westchester County Airport (HPN)",
            "Hartsfield-Jackson Atlanta Intl Airport (ATL)",
            "Bergstrom Intl Airport (AUS)",
            "Gen Edward Logan Intl Airport (BOS)",
            "Buffalo Niagara Intl Airport (BUF)",
            "Charlotte Douglas Intl Airport (CLT)",
            "O\'Hare Intl Airport (ORD)",
            "Hopkins Intl Airport (CLE)",
            "Dallas/Fort Worth Intl Airport (DFW)",
            "Denver Intl Airport (DEN)",
            "Hollywood Intl Airport (FLL)",
            "George Bush Intl Airport (IAH)",
            "McCarran Intl Airport (LAS)",
            "Los Angeles Intl Airport (LAX)"});
            this.comboBoxTo.Location = new System.Drawing.Point(236, 272);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(275, 24);
            this.comboBoxTo.TabIndex = 15;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "LaGuardia Airport (LGA)",
            "John F Kennedy Intl Airport (JFK)",
            "Newark Liberty Intl Airport (EWR)",
            "Westchester County Airport (HPN)",
            "Hartsfield-Jackson Atlanta Intl Airport (ATL)",
            "Bergstrom Intl Airport (AUS)",
            "Gen Edward Logan Intl Airport (BOS)",
            "Buffalo Niagara Intl Airport (BUF)",
            "Charlotte Douglas Intl Airport (CLT)",
            "O\'Hare Intl Airport (ORD)",
            "Hopkins Intl Airport (CLE)",
            "Dallas/Fort Worth Intl Airport (DFW)",
            "Denver Intl Airport (DEN)",
            "Hollywood Intl Airport (FLL)",
            "George Bush Intl Airport (IAH)",
            "McCarran Intl Airport (LAS)",
            "Los Angeles Intl Airport (LAX)"});
            this.comboBoxFrom.Location = new System.Drawing.Point(232, 173);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(275, 24);
            this.comboBoxFrom.TabIndex = 5;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblReturnDate.Location = new System.Drawing.Point(554, 265);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(172, 29);
            this.lblReturnDate.TabIndex = 14;
            this.lblReturnDate.Text = "Return Date : ";
            // 
            // lblDepartDate
            // 
            this.lblDepartDate.AutoSize = true;
            this.lblDepartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDepartDate.Location = new System.Drawing.Point(554, 166);
            this.lblDepartDate.Name = "lblDepartDate";
            this.lblDepartDate.Size = new System.Drawing.Size(173, 29);
            this.lblDepartDate.TabIndex = 13;
            this.lblDepartDate.Text = "Depart Date : ";
            // 
            // lblPassenger
            // 
            this.lblPassenger.AutoSize = true;
            this.lblPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassenger.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPassenger.Location = new System.Drawing.Point(69, 471);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(159, 29);
            this.lblPassenger.TabIndex = 11;
            this.lblPassenger.Text = "Passenger : ";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClass.Location = new System.Drawing.Point(69, 364);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(99, 29);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "Class : ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTo.Location = new System.Drawing.Point(69, 272);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(66, 29);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To : ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFrom.Location = new System.Drawing.Point(69, 173);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(95, 29);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonRound);
            this.panel1.Controls.Add(this.radioButtonOne);
            this.panel1.Location = new System.Drawing.Point(232, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 62);
            this.panel1.TabIndex = 7;
            // 
            // radioButtonRound
            // 
            this.radioButtonRound.AutoSize = true;
            this.radioButtonRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonRound.Location = new System.Drawing.Point(28, 19);
            this.radioButtonRound.Name = "radioButtonRound";
            this.radioButtonRound.Size = new System.Drawing.Size(123, 24);
            this.radioButtonRound.TabIndex = 5;
            this.radioButtonRound.TabStop = true;
            this.radioButtonRound.Text = "Round-Trip";
            this.radioButtonRound.UseVisualStyleBackColor = true;
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOne.Location = new System.Drawing.Point(196, 19);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(103, 24);
            this.radioButtonOne.TabIndex = 6;
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.Text = "One-way";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblType.Location = new System.Drawing.Point(69, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(93, 29);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type : ";
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1594, 1010);
            this.Controls.Add(this.groupBoxFlight);
            this.Controls.Add(this.btnBlog);
            this.Controls.Add(this.btnCars);
            this.Controls.Add(this.btnHotels);
            this.Controls.Add(this.btnFlight);
            this.Name = "form2";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.form2_Load);
            this.groupBoxFlight.ResumeLayout(false);
            this.groupBoxFlight.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFlight;
        private System.Windows.Forms.Button btnHotels;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnBlog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBoxFlight;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblDepartDate;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonRound;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
        private System.Windows.Forms.ComboBox comboBoxPassenger;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
    }
}