namespace GallerySQL
{
    partial class Search
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
            this.components = new System.ComponentModel.Container();
            this.dataviewgrid = new System.Windows.Forms.DataGridView();
            this.galleryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galleryDataSet = new GallerySQL.galleryDataSet();
            this.searchstockbutton = new System.Windows.Forms.Button();
            this.searchstockbrandlabel = new System.Windows.Forms.Label();
            this.searchstockpricelabel = new System.Windows.Forms.Label();
            this.searchstockcaryearlabel = new System.Windows.Forms.Label();
            this.searchstockmodellabel = new System.Windows.Forms.Label();
            this.searchstockserialcodelabel = new System.Windows.Forms.Label();
            this.searchstockarrivaldatelabel = new System.Windows.Forms.Label();
            this.searchstockserialcodetext = new System.Windows.Forms.MaskedTextBox();
            this.searchstockbrandtext = new System.Windows.Forms.TextBox();
            this.searchstockmodeltext = new System.Windows.Forms.TextBox();
            this.searchstockcaryeartext = new System.Windows.Forms.MaskedTextBox();
            this.searchstockpricetext = new System.Windows.Forms.MaskedTextBox();
            this.searchstockarrivaldatetext = new System.Windows.Forms.MaskedTextBox();
            this.searchstockpanel = new System.Windows.Forms.Panel();
            this.searchcostbutton = new System.Windows.Forms.Button();
            this.searchcostpanel = new System.Windows.Forms.Panel();
            this.searchcostannualcosttext = new System.Windows.Forms.TextBox();
            this.searchcostcostlabel = new System.Windows.Forms.Label();
            this.searchcostannualcostlabel = new System.Windows.Forms.Label();
            this.searchcostcosttext = new System.Windows.Forms.TextBox();
            this.searchcostserialcodelabel = new System.Windows.Forms.Label();
            this.searchcostserialcodetext = new System.Windows.Forms.MaskedTextBox();
            this.costBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costTableAdapter = new GallerySQL.galleryDataSetTableAdapters.costTableAdapter();
            this.searchcustomersbutton = new System.Windows.Forms.Button();
            this.searchcustomerpanel = new System.Windows.Forms.Panel();
            this.searchcustomercontacttext = new System.Windows.Forms.TextBox();
            this.searchcustomercustomernamelabel = new System.Windows.Forms.Label();
            this.searchcustomeremailtext = new System.Windows.Forms.MaskedTextBox();
            this.searchcustomeremaillabel = new System.Windows.Forms.Label();
            this.searchcustomercontactlabel = new System.Windows.Forms.Label();
            this.searchcustomernametext = new System.Windows.Forms.TextBox();
            this.searchcustomercustomeridlabel = new System.Windows.Forms.Label();
            this.searchcustomercustomeridtext = new System.Windows.Forms.MaskedTextBox();
            this.searchorderbutton = new System.Windows.Forms.Button();
            this.searchorderpanel = new System.Windows.Forms.Panel();
            this.searchorderreceiptcodelabel = new System.Windows.Forms.Label();
            this.searchorderserialcodelabel = new System.Windows.Forms.Label();
            this.searchorderorderidlabel = new System.Windows.Forms.Label();
            this.searchorderorderidtext = new System.Windows.Forms.MaskedTextBox();
            this.searchordercustomeridlabel = new System.Windows.Forms.Label();
            this.searchorderserialcodetext = new System.Windows.Forms.MaskedTextBox();
            this.searchorderreceiptcodetext = new System.Windows.Forms.MaskedTextBox();
            this.searchordercustomeridtext = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet)).BeginInit();
            this.searchstockpanel.SuspendLayout();
            this.searchcostpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).BeginInit();
            this.searchcustomerpanel.SuspendLayout();
            this.searchorderpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataviewgrid
            // 
            this.dataviewgrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataviewgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewgrid.Location = new System.Drawing.Point(12, 211);
            this.dataviewgrid.Name = "dataviewgrid";
            this.dataviewgrid.Size = new System.Drawing.Size(625, 342);
            this.dataviewgrid.TabIndex = 0;
            // 
            // galleryDataSetBindingSource
            // 
            this.galleryDataSetBindingSource.DataSource = this.galleryDataSet;
            this.galleryDataSetBindingSource.Position = 0;
            // 
            // galleryDataSet
            // 
            this.galleryDataSet.DataSetName = "galleryDataSet";
            this.galleryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchstockbutton
            // 
            this.searchstockbutton.BackColor = System.Drawing.Color.PaleGreen;
            this.searchstockbutton.Location = new System.Drawing.Point(12, 13);
            this.searchstockbutton.Name = "searchstockbutton";
            this.searchstockbutton.Size = new System.Drawing.Size(83, 23);
            this.searchstockbutton.TabIndex = 1;
            this.searchstockbutton.Text = "Search Stock";
            this.searchstockbutton.UseVisualStyleBackColor = false;
            this.searchstockbutton.Click += new System.EventHandler(this.searchstockbutton_Click);
            // 
            // searchstockbrandlabel
            // 
            this.searchstockbrandlabel.AutoSize = true;
            this.searchstockbrandlabel.BackColor = System.Drawing.Color.Peru;
            this.searchstockbrandlabel.Location = new System.Drawing.Point(8, 28);
            this.searchstockbrandlabel.Name = "searchstockbrandlabel";
            this.searchstockbrandlabel.Size = new System.Drawing.Size(35, 13);
            this.searchstockbrandlabel.TabIndex = 2;
            this.searchstockbrandlabel.Text = "Brand";
            // 
            // searchstockpricelabel
            // 
            this.searchstockpricelabel.AutoSize = true;
            this.searchstockpricelabel.BackColor = System.Drawing.Color.Peru;
            this.searchstockpricelabel.Location = new System.Drawing.Point(8, 107);
            this.searchstockpricelabel.Name = "searchstockpricelabel";
            this.searchstockpricelabel.Size = new System.Drawing.Size(31, 13);
            this.searchstockpricelabel.TabIndex = 3;
            this.searchstockpricelabel.Text = "Price";
            // 
            // searchstockcaryearlabel
            // 
            this.searchstockcaryearlabel.AutoSize = true;
            this.searchstockcaryearlabel.BackColor = System.Drawing.Color.Peru;
            this.searchstockcaryearlabel.Location = new System.Drawing.Point(8, 80);
            this.searchstockcaryearlabel.Name = "searchstockcaryearlabel";
            this.searchstockcaryearlabel.Size = new System.Drawing.Size(48, 13);
            this.searchstockcaryearlabel.TabIndex = 4;
            this.searchstockcaryearlabel.Text = "Car Year";
            // 
            // searchstockmodellabel
            // 
            this.searchstockmodellabel.AutoSize = true;
            this.searchstockmodellabel.BackColor = System.Drawing.Color.Peru;
            this.searchstockmodellabel.Location = new System.Drawing.Point(8, 53);
            this.searchstockmodellabel.Name = "searchstockmodellabel";
            this.searchstockmodellabel.Size = new System.Drawing.Size(36, 13);
            this.searchstockmodellabel.TabIndex = 5;
            this.searchstockmodellabel.Text = "Model";
            // 
            // searchstockserialcodelabel
            // 
            this.searchstockserialcodelabel.AutoSize = true;
            this.searchstockserialcodelabel.BackColor = System.Drawing.Color.Peru;
            this.searchstockserialcodelabel.Location = new System.Drawing.Point(8, 6);
            this.searchstockserialcodelabel.Name = "searchstockserialcodelabel";
            this.searchstockserialcodelabel.Size = new System.Drawing.Size(61, 13);
            this.searchstockserialcodelabel.TabIndex = 6;
            this.searchstockserialcodelabel.Text = "Serial Code";
            // 
            // searchstockarrivaldatelabel
            // 
            this.searchstockarrivaldatelabel.AutoSize = true;
            this.searchstockarrivaldatelabel.BackColor = System.Drawing.Color.Peru;
            this.searchstockarrivaldatelabel.Location = new System.Drawing.Point(8, 131);
            this.searchstockarrivaldatelabel.Name = "searchstockarrivaldatelabel";
            this.searchstockarrivaldatelabel.Size = new System.Drawing.Size(62, 13);
            this.searchstockarrivaldatelabel.TabIndex = 7;
            this.searchstockarrivaldatelabel.Text = "Arrival Date";
            // 
            // searchstockserialcodetext
            // 
            this.searchstockserialcodetext.Location = new System.Drawing.Point(75, 3);
            this.searchstockserialcodetext.Mask = "S000";
            this.searchstockserialcodetext.Name = "searchstockserialcodetext";
            this.searchstockserialcodetext.Size = new System.Drawing.Size(100, 20);
            this.searchstockserialcodetext.TabIndex = 8;
            this.searchstockserialcodetext.TextChanged += new System.EventHandler(this.searchstockserialcodetext_TextChanged);
            // 
            // searchstockbrandtext
            // 
            this.searchstockbrandtext.Location = new System.Drawing.Point(75, 28);
            this.searchstockbrandtext.Name = "searchstockbrandtext";
            this.searchstockbrandtext.Size = new System.Drawing.Size(100, 20);
            this.searchstockbrandtext.TabIndex = 9;
            this.searchstockbrandtext.TextChanged += new System.EventHandler(this.searchstockbrandtext_TextChanged);
            // 
            // searchstockmodeltext
            // 
            this.searchstockmodeltext.Location = new System.Drawing.Point(75, 54);
            this.searchstockmodeltext.Name = "searchstockmodeltext";
            this.searchstockmodeltext.Size = new System.Drawing.Size(100, 20);
            this.searchstockmodeltext.TabIndex = 10;
            this.searchstockmodeltext.TextChanged += new System.EventHandler(this.searchstockmodeltext_TextChanged);
            // 
            // searchstockcaryeartext
            // 
            this.searchstockcaryeartext.Location = new System.Drawing.Point(75, 80);
            this.searchstockcaryeartext.Mask = "0000";
            this.searchstockcaryeartext.Name = "searchstockcaryeartext";
            this.searchstockcaryeartext.Size = new System.Drawing.Size(100, 20);
            this.searchstockcaryeartext.TabIndex = 11;
            this.searchstockcaryeartext.TextChanged += new System.EventHandler(this.searchstockcaryeartext_TextChanged);
            // 
            // searchstockpricetext
            // 
            this.searchstockpricetext.Location = new System.Drawing.Point(74, 107);
            this.searchstockpricetext.Mask = "000000";
            this.searchstockpricetext.Name = "searchstockpricetext";
            this.searchstockpricetext.Size = new System.Drawing.Size(100, 20);
            this.searchstockpricetext.TabIndex = 12;
            this.searchstockpricetext.TextChanged += new System.EventHandler(this.searchstockpricetext_TextChanged);
            // 
            // searchstockarrivaldatetext
            // 
            this.searchstockarrivaldatetext.Location = new System.Drawing.Point(75, 131);
            this.searchstockarrivaldatetext.Mask = "0000/00/00";
            this.searchstockarrivaldatetext.Name = "searchstockarrivaldatetext";
            this.searchstockarrivaldatetext.Size = new System.Drawing.Size(100, 20);
            this.searchstockarrivaldatetext.TabIndex = 13;
            this.searchstockarrivaldatetext.ValidatingType = typeof(System.DateTime);
            this.searchstockarrivaldatetext.TextChanged += new System.EventHandler(this.searchstockarrivaldatetext_TextChanged);
            // 
            // searchstockpanel
            // 
            this.searchstockpanel.Controls.Add(this.searchstockmodeltext);
            this.searchstockpanel.Controls.Add(this.searchstockarrivaldatetext);
            this.searchstockpanel.Controls.Add(this.searchstockbrandlabel);
            this.searchstockpanel.Controls.Add(this.searchstockpricetext);
            this.searchstockpanel.Controls.Add(this.searchstockpricelabel);
            this.searchstockpanel.Controls.Add(this.searchstockcaryeartext);
            this.searchstockpanel.Controls.Add(this.searchstockcaryearlabel);
            this.searchstockpanel.Controls.Add(this.searchstockmodellabel);
            this.searchstockpanel.Controls.Add(this.searchstockbrandtext);
            this.searchstockpanel.Controls.Add(this.searchstockserialcodelabel);
            this.searchstockpanel.Controls.Add(this.searchstockserialcodetext);
            this.searchstockpanel.Controls.Add(this.searchstockarrivaldatelabel);
            this.searchstockpanel.Location = new System.Drawing.Point(12, 42);
            this.searchstockpanel.Name = "searchstockpanel";
            this.searchstockpanel.Size = new System.Drawing.Size(179, 152);
            this.searchstockpanel.TabIndex = 14;
            this.searchstockpanel.Visible = false;
            // 
            // searchcostbutton
            // 
            this.searchcostbutton.BackColor = System.Drawing.Color.PaleGreen;
            this.searchcostbutton.Location = new System.Drawing.Point(194, 13);
            this.searchcostbutton.Name = "searchcostbutton";
            this.searchcostbutton.Size = new System.Drawing.Size(83, 23);
            this.searchcostbutton.TabIndex = 15;
            this.searchcostbutton.Text = "Search Cost";
            this.searchcostbutton.UseVisualStyleBackColor = false;
            this.searchcostbutton.Click += new System.EventHandler(this.searchcostbutton_Click);
            // 
            // searchcostpanel
            // 
            this.searchcostpanel.Controls.Add(this.searchcostannualcosttext);
            this.searchcostpanel.Controls.Add(this.searchcostcostlabel);
            this.searchcostpanel.Controls.Add(this.searchcostannualcostlabel);
            this.searchcostpanel.Controls.Add(this.searchcostcosttext);
            this.searchcostpanel.Controls.Add(this.searchcostserialcodelabel);
            this.searchcostpanel.Controls.Add(this.searchcostserialcodetext);
            this.searchcostpanel.Location = new System.Drawing.Point(192, 42);
            this.searchcostpanel.Name = "searchcostpanel";
            this.searchcostpanel.Size = new System.Drawing.Size(157, 152);
            this.searchcostpanel.TabIndex = 16;
            this.searchcostpanel.Visible = false;
            // 
            // searchcostannualcosttext
            // 
            this.searchcostannualcosttext.Location = new System.Drawing.Point(75, 54);
            this.searchcostannualcosttext.Name = "searchcostannualcosttext";
            this.searchcostannualcosttext.Size = new System.Drawing.Size(76, 20);
            this.searchcostannualcosttext.TabIndex = 10;
            this.searchcostannualcosttext.TextChanged += new System.EventHandler(this.searchcostannualcosttext_TextChanged);
            // 
            // searchcostcostlabel
            // 
            this.searchcostcostlabel.AutoSize = true;
            this.searchcostcostlabel.BackColor = System.Drawing.Color.Peru;
            this.searchcostcostlabel.Location = new System.Drawing.Point(8, 28);
            this.searchcostcostlabel.Name = "searchcostcostlabel";
            this.searchcostcostlabel.Size = new System.Drawing.Size(28, 13);
            this.searchcostcostlabel.TabIndex = 2;
            this.searchcostcostlabel.Text = "Cost";
            // 
            // searchcostannualcostlabel
            // 
            this.searchcostannualcostlabel.AutoSize = true;
            this.searchcostannualcostlabel.BackColor = System.Drawing.Color.Peru;
            this.searchcostannualcostlabel.Location = new System.Drawing.Point(8, 53);
            this.searchcostannualcostlabel.Name = "searchcostannualcostlabel";
            this.searchcostannualcostlabel.Size = new System.Drawing.Size(61, 13);
            this.searchcostannualcostlabel.TabIndex = 5;
            this.searchcostannualcostlabel.Text = "AnnualCost";
            // 
            // searchcostcosttext
            // 
            this.searchcostcosttext.Location = new System.Drawing.Point(75, 28);
            this.searchcostcosttext.Name = "searchcostcosttext";
            this.searchcostcosttext.Size = new System.Drawing.Size(76, 20);
            this.searchcostcosttext.TabIndex = 9;
            this.searchcostcosttext.TextChanged += new System.EventHandler(this.searchcostcosttext_TextChanged);
            // 
            // searchcostserialcodelabel
            // 
            this.searchcostserialcodelabel.AutoSize = true;
            this.searchcostserialcodelabel.BackColor = System.Drawing.Color.Peru;
            this.searchcostserialcodelabel.Location = new System.Drawing.Point(8, 6);
            this.searchcostserialcodelabel.Name = "searchcostserialcodelabel";
            this.searchcostserialcodelabel.Size = new System.Drawing.Size(61, 13);
            this.searchcostserialcodelabel.TabIndex = 6;
            this.searchcostserialcodelabel.Text = "Serial Code";
            // 
            // searchcostserialcodetext
            // 
            this.searchcostserialcodetext.Location = new System.Drawing.Point(75, 3);
            this.searchcostserialcodetext.Mask = "S000";
            this.searchcostserialcodetext.Name = "searchcostserialcodetext";
            this.searchcostserialcodetext.Size = new System.Drawing.Size(76, 20);
            this.searchcostserialcodetext.TabIndex = 8;
            this.searchcostserialcodetext.TextChanged += new System.EventHandler(this.searchcostserialcodetext_TextChanged);
            // 
            // costBindingSource
            // 
            this.costBindingSource.DataMember = "cost";
            this.costBindingSource.DataSource = this.galleryDataSetBindingSource;
            // 
            // costTableAdapter
            // 
            this.costTableAdapter.ClearBeforeFill = true;
            // 
            // searchcustomersbutton
            // 
            this.searchcustomersbutton.BackColor = System.Drawing.Color.PaleGreen;
            this.searchcustomersbutton.Location = new System.Drawing.Point(349, 13);
            this.searchcustomersbutton.Name = "searchcustomersbutton";
            this.searchcustomersbutton.Size = new System.Drawing.Size(97, 23);
            this.searchcustomersbutton.TabIndex = 17;
            this.searchcustomersbutton.Text = "Search Customer";
            this.searchcustomersbutton.UseVisualStyleBackColor = false;
            this.searchcustomersbutton.Click += new System.EventHandler(this.searchcustomersbutton_Click);
            // 
            // searchcustomerpanel
            // 
            this.searchcustomerpanel.Controls.Add(this.searchcustomercontacttext);
            this.searchcustomerpanel.Controls.Add(this.searchcustomercustomernamelabel);
            this.searchcustomerpanel.Controls.Add(this.searchcustomeremailtext);
            this.searchcustomerpanel.Controls.Add(this.searchcustomeremaillabel);
            this.searchcustomerpanel.Controls.Add(this.searchcustomercontactlabel);
            this.searchcustomerpanel.Controls.Add(this.searchcustomernametext);
            this.searchcustomerpanel.Controls.Add(this.searchcustomercustomeridlabel);
            this.searchcustomerpanel.Controls.Add(this.searchcustomercustomeridtext);
            this.searchcustomerpanel.Location = new System.Drawing.Point(349, 41);
            this.searchcustomerpanel.Name = "searchcustomerpanel";
            this.searchcustomerpanel.Size = new System.Drawing.Size(154, 152);
            this.searchcustomerpanel.TabIndex = 18;
            this.searchcustomerpanel.Visible = false;
            // 
            // searchcustomercontacttext
            // 
            this.searchcustomercontacttext.Location = new System.Drawing.Point(82, 54);
            this.searchcustomercontacttext.Name = "searchcustomercontacttext";
            this.searchcustomercontacttext.Size = new System.Drawing.Size(69, 20);
            this.searchcustomercontacttext.TabIndex = 10;
            this.searchcustomercontacttext.TextChanged += new System.EventHandler(this.searchcustomercontacttext_TextChanged);
            // 
            // searchcustomercustomernamelabel
            // 
            this.searchcustomercustomernamelabel.AutoSize = true;
            this.searchcustomercustomernamelabel.BackColor = System.Drawing.Color.Peru;
            this.searchcustomercustomernamelabel.Location = new System.Drawing.Point(8, 29);
            this.searchcustomercustomernamelabel.Name = "searchcustomercustomernamelabel";
            this.searchcustomercustomernamelabel.Size = new System.Drawing.Size(35, 13);
            this.searchcustomercustomernamelabel.TabIndex = 2;
            this.searchcustomercustomernamelabel.Text = "Name";
            // 
            // searchcustomeremailtext
            // 
            this.searchcustomeremailtext.Location = new System.Drawing.Point(81, 81);
            this.searchcustomeremailtext.Name = "searchcustomeremailtext";
            this.searchcustomeremailtext.Size = new System.Drawing.Size(69, 20);
            this.searchcustomeremailtext.TabIndex = 11;
            this.searchcustomeremailtext.TextChanged += new System.EventHandler(this.searchcustomeremailtext_TextChanged);
            // 
            // searchcustomeremaillabel
            // 
            this.searchcustomeremaillabel.AutoSize = true;
            this.searchcustomeremaillabel.BackColor = System.Drawing.Color.Peru;
            this.searchcustomeremaillabel.Location = new System.Drawing.Point(8, 80);
            this.searchcustomeremaillabel.Name = "searchcustomeremaillabel";
            this.searchcustomeremaillabel.Size = new System.Drawing.Size(32, 13);
            this.searchcustomeremaillabel.TabIndex = 4;
            this.searchcustomeremaillabel.Text = "Email";
            // 
            // searchcustomercontactlabel
            // 
            this.searchcustomercontactlabel.AutoSize = true;
            this.searchcustomercontactlabel.BackColor = System.Drawing.Color.Peru;
            this.searchcustomercontactlabel.Location = new System.Drawing.Point(8, 53);
            this.searchcustomercontactlabel.Name = "searchcustomercontactlabel";
            this.searchcustomercontactlabel.Size = new System.Drawing.Size(44, 13);
            this.searchcustomercontactlabel.TabIndex = 5;
            this.searchcustomercontactlabel.Text = "Contact";
            // 
            // searchcustomernametext
            // 
            this.searchcustomernametext.Location = new System.Drawing.Point(82, 26);
            this.searchcustomernametext.Name = "searchcustomernametext";
            this.searchcustomernametext.Size = new System.Drawing.Size(69, 20);
            this.searchcustomernametext.TabIndex = 9;
            this.searchcustomernametext.TextChanged += new System.EventHandler(this.searchcustomernametext_TextChanged);
            // 
            // searchcustomercustomeridlabel
            // 
            this.searchcustomercustomeridlabel.AutoSize = true;
            this.searchcustomercustomeridlabel.BackColor = System.Drawing.Color.Peru;
            this.searchcustomercustomeridlabel.Location = new System.Drawing.Point(8, 6);
            this.searchcustomercustomeridlabel.Name = "searchcustomercustomeridlabel";
            this.searchcustomercustomeridlabel.Size = new System.Drawing.Size(65, 13);
            this.searchcustomercustomeridlabel.TabIndex = 6;
            this.searchcustomercustomeridlabel.Text = "Customer ID";
            // 
            // searchcustomercustomeridtext
            // 
            this.searchcustomercustomeridtext.Location = new System.Drawing.Point(82, 3);
            this.searchcustomercustomeridtext.Mask = "0000";
            this.searchcustomercustomeridtext.Name = "searchcustomercustomeridtext";
            this.searchcustomercustomeridtext.Size = new System.Drawing.Size(68, 20);
            this.searchcustomercustomeridtext.TabIndex = 8;
            this.searchcustomercustomeridtext.TextChanged += new System.EventHandler(this.searchcustomercustomeridtext_TextChanged);
            // 
            // searchorderbutton
            // 
            this.searchorderbutton.BackColor = System.Drawing.Color.PaleGreen;
            this.searchorderbutton.Location = new System.Drawing.Point(498, 13);
            this.searchorderbutton.Name = "searchorderbutton";
            this.searchorderbutton.Size = new System.Drawing.Size(97, 23);
            this.searchorderbutton.TabIndex = 19;
            this.searchorderbutton.Text = "Search Order";
            this.searchorderbutton.UseVisualStyleBackColor = false;
            this.searchorderbutton.Click += new System.EventHandler(this.searchorderbutton_Click);
            // 
            // searchorderpanel
            // 
            this.searchorderpanel.Controls.Add(this.searchordercustomeridtext);
            this.searchorderpanel.Controls.Add(this.searchorderreceiptcodetext);
            this.searchorderpanel.Controls.Add(this.searchorderserialcodetext);
            this.searchorderpanel.Controls.Add(this.searchordercustomeridlabel);
            this.searchorderpanel.Controls.Add(this.searchorderreceiptcodelabel);
            this.searchorderpanel.Controls.Add(this.searchorderserialcodelabel);
            this.searchorderpanel.Controls.Add(this.searchorderorderidlabel);
            this.searchorderpanel.Controls.Add(this.searchorderorderidtext);
            this.searchorderpanel.Location = new System.Drawing.Point(498, 41);
            this.searchorderpanel.Name = "searchorderpanel";
            this.searchorderpanel.Size = new System.Drawing.Size(151, 152);
            this.searchorderpanel.TabIndex = 20;
            this.searchorderpanel.Visible = false;
            // 
            // searchorderreceiptcodelabel
            // 
            this.searchorderreceiptcodelabel.AutoSize = true;
            this.searchorderreceiptcodelabel.BackColor = System.Drawing.Color.Peru;
            this.searchorderreceiptcodelabel.Location = new System.Drawing.Point(8, 84);
            this.searchorderreceiptcodelabel.Name = "searchorderreceiptcodelabel";
            this.searchorderreceiptcodelabel.Size = new System.Drawing.Size(72, 13);
            this.searchorderreceiptcodelabel.TabIndex = 4;
            this.searchorderreceiptcodelabel.Text = "Receipt Code";
            // 
            // searchorderserialcodelabel
            // 
            this.searchorderserialcodelabel.AutoSize = true;
            this.searchorderserialcodelabel.BackColor = System.Drawing.Color.Peru;
            this.searchorderserialcodelabel.Location = new System.Drawing.Point(8, 53);
            this.searchorderserialcodelabel.Name = "searchorderserialcodelabel";
            this.searchorderserialcodelabel.Size = new System.Drawing.Size(61, 13);
            this.searchorderserialcodelabel.TabIndex = 5;
            this.searchorderserialcodelabel.Text = "Serial Code";
            // 
            // searchorderorderidlabel
            // 
            this.searchorderorderidlabel.AutoSize = true;
            this.searchorderorderidlabel.BackColor = System.Drawing.Color.Peru;
            this.searchorderorderidlabel.Location = new System.Drawing.Point(8, 6);
            this.searchorderorderidlabel.Name = "searchorderorderidlabel";
            this.searchorderorderidlabel.Size = new System.Drawing.Size(47, 13);
            this.searchorderorderidlabel.TabIndex = 6;
            this.searchorderorderidlabel.Text = "Order ID";
            // 
            // searchorderorderidtext
            // 
            this.searchorderorderidtext.Location = new System.Drawing.Point(79, 1);
            this.searchorderorderidtext.Mask = "0000";
            this.searchorderorderidtext.Name = "searchorderorderidtext";
            this.searchorderorderidtext.Size = new System.Drawing.Size(68, 20);
            this.searchorderorderidtext.TabIndex = 8;
            this.searchorderorderidtext.TextChanged += new System.EventHandler(this.searchorderorderidtext_TextChanged);
            // 
            // searchordercustomeridlabel
            // 
            this.searchordercustomeridlabel.AutoSize = true;
            this.searchordercustomeridlabel.BackColor = System.Drawing.Color.Peru;
            this.searchordercustomeridlabel.Location = new System.Drawing.Point(8, 29);
            this.searchordercustomeridlabel.Name = "searchordercustomeridlabel";
            this.searchordercustomeridlabel.Size = new System.Drawing.Size(65, 13);
            this.searchordercustomeridlabel.TabIndex = 2;
            this.searchordercustomeridlabel.Text = "Customer ID";
            // 
            // searchorderserialcodetext
            // 
            this.searchorderserialcodetext.Location = new System.Drawing.Point(79, 52);
            this.searchorderserialcodetext.Mask = "S000";
            this.searchorderserialcodetext.Name = "searchorderserialcodetext";
            this.searchorderserialcodetext.Size = new System.Drawing.Size(68, 20);
            this.searchorderserialcodetext.TabIndex = 9;
            this.searchorderserialcodetext.TextChanged += new System.EventHandler(this.searchorderserialcodetext_TextChanged);
            // 
            // searchorderreceiptcodetext
            // 
            this.searchorderreceiptcodetext.Location = new System.Drawing.Point(86, 81);
            this.searchorderreceiptcodetext.Mask = "R000";
            this.searchorderreceiptcodetext.Name = "searchorderreceiptcodetext";
            this.searchorderreceiptcodetext.Size = new System.Drawing.Size(60, 20);
            this.searchorderreceiptcodetext.TabIndex = 10;
            this.searchorderreceiptcodetext.TextChanged += new System.EventHandler(this.searchorderreceiptcodetext_TextChanged);
            // 
            // searchordercustomeridtext
            // 
            this.searchordercustomeridtext.Location = new System.Drawing.Point(79, 26);
            this.searchordercustomeridtext.Mask = "0000";
            this.searchordercustomeridtext.Name = "searchordercustomeridtext";
            this.searchordercustomeridtext.Size = new System.Drawing.Size(68, 20);
            this.searchordercustomeridtext.TabIndex = 11;
            this.searchordercustomeridtext.TextChanged += new System.EventHandler(this.searchordercustomeridtext_TextChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(649, 633);
            this.Controls.Add(this.searchorderpanel);
            this.Controls.Add(this.searchorderbutton);
            this.Controls.Add(this.searchcustomerpanel);
            this.Controls.Add(this.searchcustomersbutton);
            this.Controls.Add(this.searchcostpanel);
            this.Controls.Add(this.searchcostbutton);
            this.Controls.Add(this.searchstockpanel);
            this.Controls.Add(this.searchstockbutton);
            this.Controls.Add(this.dataviewgrid);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataviewgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet)).EndInit();
            this.searchstockpanel.ResumeLayout(false);
            this.searchstockpanel.PerformLayout();
            this.searchcostpanel.ResumeLayout(false);
            this.searchcostpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).EndInit();
            this.searchcustomerpanel.ResumeLayout(false);
            this.searchcustomerpanel.PerformLayout();
            this.searchorderpanel.ResumeLayout(false);
            this.searchorderpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataviewgrid;
        private System.Windows.Forms.BindingSource galleryDataSetBindingSource;
        private galleryDataSet galleryDataSet;
        private System.Windows.Forms.Button searchstockbutton;
        private System.Windows.Forms.Label searchstockbrandlabel;
        private System.Windows.Forms.Label searchstockpricelabel;
        private System.Windows.Forms.Label searchstockcaryearlabel;
        private System.Windows.Forms.Label searchstockmodellabel;
        private System.Windows.Forms.Label searchstockserialcodelabel;
        private System.Windows.Forms.Label searchstockarrivaldatelabel;
        private System.Windows.Forms.MaskedTextBox searchstockserialcodetext;
        private System.Windows.Forms.TextBox searchstockbrandtext;
        private System.Windows.Forms.TextBox searchstockmodeltext;
        private System.Windows.Forms.MaskedTextBox searchstockcaryeartext;
        private System.Windows.Forms.MaskedTextBox searchstockpricetext;
        private System.Windows.Forms.MaskedTextBox searchstockarrivaldatetext;
        private System.Windows.Forms.Panel searchstockpanel;
        private System.Windows.Forms.Button searchcostbutton;
        private System.Windows.Forms.Panel searchcostpanel;
        private System.Windows.Forms.TextBox searchcostannualcosttext;
        private System.Windows.Forms.Label searchcostcostlabel;
        private System.Windows.Forms.Label searchcostannualcostlabel;
        private System.Windows.Forms.TextBox searchcostcosttext;
        private System.Windows.Forms.Label searchcostserialcodelabel;
        private System.Windows.Forms.MaskedTextBox searchcostserialcodetext;
        private System.Windows.Forms.BindingSource costBindingSource;
        private galleryDataSetTableAdapters.costTableAdapter costTableAdapter;
        private System.Windows.Forms.Button searchcustomersbutton;
        private System.Windows.Forms.Panel searchcustomerpanel;
        private System.Windows.Forms.TextBox searchcustomercontacttext;
        private System.Windows.Forms.Label searchcustomercustomernamelabel;
        private System.Windows.Forms.MaskedTextBox searchcustomeremailtext;
        private System.Windows.Forms.Label searchcustomeremaillabel;
        private System.Windows.Forms.Label searchcustomercontactlabel;
        private System.Windows.Forms.TextBox searchcustomernametext;
        private System.Windows.Forms.Label searchcustomercustomeridlabel;
        private System.Windows.Forms.MaskedTextBox searchcustomercustomeridtext;
        private System.Windows.Forms.Button searchorderbutton;
        private System.Windows.Forms.Panel searchorderpanel;
        private System.Windows.Forms.MaskedTextBox searchordercustomeridtext;
        private System.Windows.Forms.MaskedTextBox searchorderreceiptcodetext;
        private System.Windows.Forms.MaskedTextBox searchorderserialcodetext;
        private System.Windows.Forms.Label searchordercustomeridlabel;
        private System.Windows.Forms.Label searchorderreceiptcodelabel;
        private System.Windows.Forms.Label searchorderserialcodelabel;
        private System.Windows.Forms.Label searchorderorderidlabel;
        private System.Windows.Forms.MaskedTextBox searchorderorderidtext;
    }
}