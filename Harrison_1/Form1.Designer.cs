namespace Harrison_1
{
    partial class motorwayMotelFrm
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
            this.motelPictureBox = new System.Windows.Forms.PictureBox();
            this.motorWayTitleLabel = new System.Windows.Forms.Label();
            this.checkOutLabel = new System.Windows.Forms.Label();
            this.checkOutMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.guestGroupBox = new System.Windows.Forms.GroupBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.roomGroupBox = new System.Windows.Forms.GroupBox();
            this.nightlyRateTextBox = new System.Windows.Forms.TextBox();
            this.nightlyRateLabel = new System.Windows.Forms.Label();
            this.roomNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stayedNightsTextBox = new System.Windows.Forms.TextBox();
            this.stayedNightsLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.additionalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.miniBarTextBox = new System.Windows.Forms.TextBox();
            this.miscellaneousTextBox = new System.Windows.Forms.TextBox();
            this.miscellaneousLabel = new System.Windows.Forms.Label();
            this.telePhoneTextBox = new System.Windows.Forms.TextBox();
            this.telePhoneLabel = new System.Windows.Forms.Label();
            this.miniBarLabel = new System.Windows.Forms.Label();
            this.billSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesOutputLabel = new System.Windows.Forms.Label();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.dividerGroupBox = new System.Windows.Forms.GroupBox();
            this.taxAmountOutputLabel = new System.Windows.Forms.Label();
            this.subTotalOutputLabel = new System.Windows.Forms.Label();
            this.totalAdditionalChargesOutputLabel = new System.Windows.Forms.Label();
            this.roomChargesOutputLabel = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalAdditionalChargesLabel = new System.Windows.Forms.Label();
            this.roomChargesLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.motelPictureBox)).BeginInit();
            this.guestGroupBox.SuspendLayout();
            this.roomGroupBox.SuspendLayout();
            this.additionalChargesGroupBox.SuspendLayout();
            this.billSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // motelPictureBox
            // 
            this.motelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.motelPictureBox.Image = global::Harrison_1.Properties.Resources.motorwayMotel;
            this.motelPictureBox.Location = new System.Drawing.Point(25, 13);
            this.motelPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.motelPictureBox.Name = "motelPictureBox";
            this.motelPictureBox.Size = new System.Drawing.Size(224, 96);
            this.motelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motelPictureBox.TabIndex = 0;
            this.motelPictureBox.TabStop = false;
            // 
            // motorWayTitleLabel
            // 
            this.motorWayTitleLabel.BackColor = System.Drawing.Color.Gold;
            this.motorWayTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.motorWayTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.motorWayTitleLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.motorWayTitleLabel.Location = new System.Drawing.Point(281, 14);
            this.motorWayTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.motorWayTitleLabel.Name = "motorWayTitleLabel";
            this.motorWayTitleLabel.Size = new System.Drawing.Size(196, 95);
            this.motorWayTitleLabel.TabIndex = 0;
            this.motorWayTitleLabel.Text = "Motorway Motel";
            this.motorWayTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.Location = new System.Drawing.Point(137, 123);
            this.checkOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(116, 17);
            this.checkOutLabel.TabIndex = 1;
            this.checkOutLabel.Text = "Checkout Date: ";
            this.checkOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkOutMaskedTextBox
            // 
            this.checkOutMaskedTextBox.Location = new System.Drawing.Point(261, 121);
            this.checkOutMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkOutMaskedTextBox.Mask = "00/00/0000";
            this.checkOutMaskedTextBox.Name = "checkOutMaskedTextBox";
            this.checkOutMaskedTextBox.Size = new System.Drawing.Size(85, 22);
            this.checkOutMaskedTextBox.TabIndex = 2;
            this.checkOutMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // guestGroupBox
            // 
            this.guestGroupBox.Controls.Add(this.lastNameTextBox);
            this.guestGroupBox.Controls.Add(this.firstNameTextBox);
            this.guestGroupBox.Controls.Add(this.lastNameLabel);
            this.guestGroupBox.Controls.Add(this.firstNameLabel);
            this.guestGroupBox.Location = new System.Drawing.Point(35, 146);
            this.guestGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.guestGroupBox.Name = "guestGroupBox";
            this.guestGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.guestGroupBox.Size = new System.Drawing.Size(433, 96);
            this.guestGroupBox.TabIndex = 3;
            this.guestGroupBox.TabStop = false;
            this.guestGroupBox.Text = "Guest Information";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(227, 55);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(119, 22);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(227, 19);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(119, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(131, 58);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(88, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name: ";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(135, 22);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(84, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name: ";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roomGroupBox
            // 
            this.roomGroupBox.Controls.Add(this.nightlyRateTextBox);
            this.roomGroupBox.Controls.Add(this.nightlyRateLabel);
            this.roomGroupBox.Controls.Add(this.roomNumberMaskedTextBox);
            this.roomGroupBox.Controls.Add(this.stayedNightsTextBox);
            this.roomGroupBox.Controls.Add(this.stayedNightsLabel);
            this.roomGroupBox.Controls.Add(this.roomNumberLabel);
            this.roomGroupBox.Location = new System.Drawing.Point(35, 250);
            this.roomGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomGroupBox.Name = "roomGroupBox";
            this.roomGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.roomGroupBox.Size = new System.Drawing.Size(433, 132);
            this.roomGroupBox.TabIndex = 4;
            this.roomGroupBox.TabStop = false;
            this.roomGroupBox.Text = "Room Information";
            // 
            // nightlyRateTextBox
            // 
            this.nightlyRateTextBox.Location = new System.Drawing.Point(227, 92);
            this.nightlyRateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nightlyRateTextBox.Name = "nightlyRateTextBox";
            this.nightlyRateTextBox.Size = new System.Drawing.Size(75, 22);
            this.nightlyRateTextBox.TabIndex = 5;
            this.nightlyRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nightlyRateLabel
            // 
            this.nightlyRateLabel.Location = new System.Drawing.Point(100, 95);
            this.nightlyRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nightlyRateLabel.Name = "nightlyRateLabel";
            this.nightlyRateLabel.Size = new System.Drawing.Size(114, 17);
            this.nightlyRateLabel.TabIndex = 4;
            this.nightlyRateLabel.Text = "Nightly Rate ($):";
            this.nightlyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roomNumberMaskedTextBox
            // 
            this.roomNumberMaskedTextBox.Location = new System.Drawing.Point(226, 18);
            this.roomNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomNumberMaskedTextBox.Mask = "000";
            this.roomNumberMaskedTextBox.Name = "roomNumberMaskedTextBox";
            this.roomNumberMaskedTextBox.Size = new System.Drawing.Size(34, 22);
            this.roomNumberMaskedTextBox.TabIndex = 1;
            // 
            // stayedNightsTextBox
            // 
            this.stayedNightsTextBox.Location = new System.Drawing.Point(227, 55);
            this.stayedNightsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stayedNightsTextBox.Name = "stayedNightsTextBox";
            this.stayedNightsTextBox.Size = new System.Drawing.Size(61, 22);
            this.stayedNightsTextBox.TabIndex = 3;
            this.stayedNightsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stayedNightsLabel
            // 
            this.stayedNightsLabel.Location = new System.Drawing.Point(110, 58);
            this.stayedNightsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stayedNightsLabel.Name = "stayedNightsLabel";
            this.stayedNightsLabel.Size = new System.Drawing.Size(104, 17);
            this.stayedNightsLabel.TabIndex = 2;
            this.stayedNightsLabel.Text = "Stayed Nights:";
            this.stayedNightsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.Location = new System.Drawing.Point(108, 21);
            this.roomNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(110, 17);
            this.roomNumberLabel.TabIndex = 0;
            this.roomNumberLabel.Text = "Room Number: ";
            this.roomNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // additionalChargesGroupBox
            // 
            this.additionalChargesGroupBox.Controls.Add(this.miniBarTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.miscellaneousTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.miscellaneousLabel);
            this.additionalChargesGroupBox.Controls.Add(this.telePhoneTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.telePhoneLabel);
            this.additionalChargesGroupBox.Controls.Add(this.miniBarLabel);
            this.additionalChargesGroupBox.Location = new System.Drawing.Point(35, 389);
            this.additionalChargesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.additionalChargesGroupBox.Name = "additionalChargesGroupBox";
            this.additionalChargesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.additionalChargesGroupBox.Size = new System.Drawing.Size(433, 132);
            this.additionalChargesGroupBox.TabIndex = 5;
            this.additionalChargesGroupBox.TabStop = false;
            this.additionalChargesGroupBox.Text = "Additional Charges";
            // 
            // miniBarTextBox
            // 
            this.miniBarTextBox.Location = new System.Drawing.Point(227, 19);
            this.miniBarTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.miniBarTextBox.Name = "miniBarTextBox";
            this.miniBarTextBox.Size = new System.Drawing.Size(85, 22);
            this.miniBarTextBox.TabIndex = 1;
            this.miniBarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // miscellaneousTextBox
            // 
            this.miscellaneousTextBox.Location = new System.Drawing.Point(227, 91);
            this.miscellaneousTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.miscellaneousTextBox.Name = "miscellaneousTextBox";
            this.miscellaneousTextBox.Size = new System.Drawing.Size(85, 22);
            this.miscellaneousTextBox.TabIndex = 5;
            this.miscellaneousTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // miscellaneousLabel
            // 
            this.miscellaneousLabel.Location = new System.Drawing.Point(56, 94);
            this.miscellaneousLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.miscellaneousLabel.Name = "miscellaneousLabel";
            this.miscellaneousLabel.Size = new System.Drawing.Size(158, 17);
            this.miscellaneousLabel.TabIndex = 4;
            this.miscellaneousLabel.Text = "Miscellaneous Charges:";
            this.miscellaneousLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // telePhoneTextBox
            // 
            this.telePhoneTextBox.Location = new System.Drawing.Point(227, 54);
            this.telePhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telePhoneTextBox.Name = "telePhoneTextBox";
            this.telePhoneTextBox.Size = new System.Drawing.Size(85, 22);
            this.telePhoneTextBox.TabIndex = 3;
            this.telePhoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // telePhoneLabel
            // 
            this.telePhoneLabel.Location = new System.Drawing.Point(71, 57);
            this.telePhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telePhoneLabel.Name = "telePhoneLabel";
            this.telePhoneLabel.Size = new System.Drawing.Size(143, 17);
            this.telePhoneLabel.TabIndex = 2;
            this.telePhoneLabel.Text = "Telephone Charges:";
            this.telePhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // miniBarLabel
            // 
            this.miniBarLabel.Location = new System.Drawing.Point(95, 22);
            this.miniBarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.miniBarLabel.Name = "miniBarLabel";
            this.miniBarLabel.Size = new System.Drawing.Size(119, 17);
            this.miniBarLabel.TabIndex = 0;
            this.miniBarLabel.Text = "Minibar Charges:";
            this.miniBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // billSummaryGroupBox
            // 
            this.billSummaryGroupBox.Controls.Add(this.totalChargesOutputLabel);
            this.billSummaryGroupBox.Controls.Add(this.totalChargesLabel);
            this.billSummaryGroupBox.Controls.Add(this.dividerGroupBox);
            this.billSummaryGroupBox.Controls.Add(this.taxAmountOutputLabel);
            this.billSummaryGroupBox.Controls.Add(this.subTotalOutputLabel);
            this.billSummaryGroupBox.Controls.Add(this.totalAdditionalChargesOutputLabel);
            this.billSummaryGroupBox.Controls.Add(this.roomChargesOutputLabel);
            this.billSummaryGroupBox.Controls.Add(this.taxAmountLabel);
            this.billSummaryGroupBox.Controls.Add(this.subTotalLabel);
            this.billSummaryGroupBox.Controls.Add(this.totalAdditionalChargesLabel);
            this.billSummaryGroupBox.Controls.Add(this.roomChargesLabel);
            this.billSummaryGroupBox.Location = new System.Drawing.Point(35, 528);
            this.billSummaryGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.billSummaryGroupBox.Name = "billSummaryGroupBox";
            this.billSummaryGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.billSummaryGroupBox.Size = new System.Drawing.Size(433, 201);
            this.billSummaryGroupBox.TabIndex = 6;
            this.billSummaryGroupBox.TabStop = false;
            this.billSummaryGroupBox.Text = "Billing Summary";
            // 
            // totalChargesOutputLabel
            // 
            this.totalChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargesOutputLabel.Location = new System.Drawing.Point(226, 169);
            this.totalChargesOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalChargesOutputLabel.Name = "totalChargesOutputLabel";
            this.totalChargesOutputLabel.Size = new System.Drawing.Size(85, 22);
            this.totalChargesOutputLabel.TabIndex = 10;
            this.totalChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.Location = new System.Drawing.Point(87, 172);
            this.totalChargesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(130, 17);
            this.totalChargesLabel.TabIndex = 9;
            this.totalChargesLabel.Text = "TOTAL CHARGES:";
            this.totalChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dividerGroupBox
            // 
            this.dividerGroupBox.Location = new System.Drawing.Point(227, 153);
            this.dividerGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.dividerGroupBox.Name = "dividerGroupBox";
            this.dividerGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.dividerGroupBox.Size = new System.Drawing.Size(84, 4);
            this.dividerGroupBox.TabIndex = 8;
            this.dividerGroupBox.TabStop = false;
            // 
            // taxAmountOutputLabel
            // 
            this.taxAmountOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmountOutputLabel.Location = new System.Drawing.Point(227, 117);
            this.taxAmountOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxAmountOutputLabel.Name = "taxAmountOutputLabel";
            this.taxAmountOutputLabel.Size = new System.Drawing.Size(85, 22);
            this.taxAmountOutputLabel.TabIndex = 7;
            this.taxAmountOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotalOutputLabel
            // 
            this.subTotalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalOutputLabel.Location = new System.Drawing.Point(227, 84);
            this.subTotalOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalOutputLabel.Name = "subTotalOutputLabel";
            this.subTotalOutputLabel.Size = new System.Drawing.Size(85, 22);
            this.subTotalOutputLabel.TabIndex = 5;
            this.subTotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalAdditionalChargesOutputLabel
            // 
            this.totalAdditionalChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAdditionalChargesOutputLabel.Location = new System.Drawing.Point(227, 50);
            this.totalAdditionalChargesOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalAdditionalChargesOutputLabel.Name = "totalAdditionalChargesOutputLabel";
            this.totalAdditionalChargesOutputLabel.Size = new System.Drawing.Size(85, 22);
            this.totalAdditionalChargesOutputLabel.TabIndex = 3;
            this.totalAdditionalChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roomChargesOutputLabel
            // 
            this.roomChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomChargesOutputLabel.Location = new System.Drawing.Point(227, 17);
            this.roomChargesOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomChargesOutputLabel.Name = "roomChargesOutputLabel";
            this.roomChargesOutputLabel.Size = new System.Drawing.Size(85, 22);
            this.roomChargesOutputLabel.TabIndex = 1;
            this.roomChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.Location = new System.Drawing.Point(59, 119);
            this.taxAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(158, 17);
            this.taxAmountLabel.TabIndex = 6;
            this.taxAmountLabel.Text = "Tax (7%) on Subtotal:";
            this.taxAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Location = new System.Drawing.Point(151, 86);
            this.subTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(67, 17);
            this.subTotalLabel.TabIndex = 4;
            this.subTotalLabel.Text = "Subtotal:";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalAdditionalChargesLabel
            // 
            this.totalAdditionalChargesLabel.Location = new System.Drawing.Point(43, 53);
            this.totalAdditionalChargesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalAdditionalChargesLabel.Name = "totalAdditionalChargesLabel";
            this.totalAdditionalChargesLabel.Size = new System.Drawing.Size(175, 17);
            this.totalAdditionalChargesLabel.TabIndex = 2;
            this.totalAdditionalChargesLabel.Text = "Total Additional Charges:";
            this.totalAdditionalChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roomChargesLabel
            // 
            this.roomChargesLabel.Location = new System.Drawing.Point(103, 20);
            this.roomChargesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomChargesLabel.Name = "roomChargesLabel";
            this.roomChargesLabel.Size = new System.Drawing.Size(115, 17);
            this.roomChargesLabel.TabIndex = 0;
            this.roomChargesLabel.Text = "Room Charges:";
            this.roomChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalButton
            // 
            this.totalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalButton.Location = new System.Drawing.Point(45, 742);
            this.totalButton.Margin = new System.Windows.Forms.Padding(4);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(80, 28);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Tot&al";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Location = new System.Drawing.Point(156, 742);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 28);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Location = new System.Drawing.Point(267, 742);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(80, 28);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "&Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Location = new System.Drawing.Point(377, 742);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 28);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // motorwayMotelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 785);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.billSummaryGroupBox);
            this.Controls.Add(this.additionalChargesGroupBox);
            this.Controls.Add(this.roomGroupBox);
            this.Controls.Add(this.guestGroupBox);
            this.Controls.Add(this.checkOutMaskedTextBox);
            this.Controls.Add(this.checkOutLabel);
            this.Controls.Add(this.motorWayTitleLabel);
            this.Controls.Add(this.motelPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "motorwayMotelFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-Out Billing ";
            ((System.ComponentModel.ISupportInitialize)(this.motelPictureBox)).EndInit();
            this.guestGroupBox.ResumeLayout(false);
            this.guestGroupBox.PerformLayout();
            this.roomGroupBox.ResumeLayout(false);
            this.roomGroupBox.PerformLayout();
            this.additionalChargesGroupBox.ResumeLayout(false);
            this.additionalChargesGroupBox.PerformLayout();
            this.billSummaryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox motelPictureBox;
        private System.Windows.Forms.Label motorWayTitleLabel;
        private System.Windows.Forms.Label checkOutLabel;
        private System.Windows.Forms.MaskedTextBox checkOutMaskedTextBox;
        private System.Windows.Forms.GroupBox guestGroupBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox roomGroupBox;
        private System.Windows.Forms.MaskedTextBox roomNumberMaskedTextBox;
        private System.Windows.Forms.TextBox stayedNightsTextBox;
        private System.Windows.Forms.Label stayedNightsLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox nightlyRateTextBox;
        private System.Windows.Forms.Label nightlyRateLabel;
        private System.Windows.Forms.GroupBox additionalChargesGroupBox;
        private System.Windows.Forms.TextBox miniBarTextBox;
        private System.Windows.Forms.TextBox miscellaneousTextBox;
        private System.Windows.Forms.Label miscellaneousLabel;
        private System.Windows.Forms.TextBox telePhoneTextBox;
        private System.Windows.Forms.Label telePhoneLabel;
        private System.Windows.Forms.Label miniBarLabel;
        private System.Windows.Forms.GroupBox billSummaryGroupBox;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalAdditionalChargesLabel;
        private System.Windows.Forms.Label roomChargesLabel;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label taxAmountOutputLabel;
        private System.Windows.Forms.Label subTotalOutputLabel;
        private System.Windows.Forms.Label totalAdditionalChargesOutputLabel;
        private System.Windows.Forms.Label roomChargesOutputLabel;
        private System.Windows.Forms.GroupBox dividerGroupBox;
        private System.Windows.Forms.Label totalChargesOutputLabel;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
    }
}

