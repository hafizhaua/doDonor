namespace doDonor
{
    partial class FormCari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbBloodType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvDonorReq = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorReq)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(227, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Kebutuhan Donor";
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "Semua",
            "Aceh Barat",
            "Aceh Barat Daya",
            "Aceh Besar",
            "Aceh Jaya",
            "Aceh Selatan",
            "Aceh Singkil",
            "Aceh Tamiang",
            "Aceh Tengah",
            "Aceh Tenggara",
            "Aceh Timur",
            "Aceh Utara",
            "Agam",
            "Alor",
            "Ambon",
            "Asahan",
            "Asmat",
            "B A T A M",
            "Badung",
            "Balangan",
            "Balikpapan",
            "Banda Aceh",
            "Bandar Lampung",
            "Bandung",
            "Bandung",
            "Bandung Barat",
            "Banggai",
            "Banggai Kepulauan",
            "Banggai Laut",
            "Bangka",
            "Bangka Barat",
            "Bangka Selatan",
            "Bangka Tengah",
            "Bangkalan",
            "Bangli",
            "Banjar",
            "Banjar",
            "Banjar Baru",
            "Banjarmasin",
            "Banjarnegara",
            "Bantaeng",
            "Bantul",
            "Banyu Asin",
            "Banyumas",
            "Banyuwangi",
            "Barito Kuala",
            "Barito Selatan",
            "Barito Timur",
            "Barito Utara",
            "Barru",
            "Baru",
            "Batang",
            "Batang Hari",
            "Batu",
            "Batu Bara",
            "Baubau",
            "Bekasi",
            "Bekasi",
            "Belitung",
            "Belitung Timur",
            "Belu",
            "Bener Meriah",
            "Bengkalis",
            "Bengkayang",
            "Bengkulu",
            "Bengkulu Selatan",
            "Bengkulu Tengah",
            "Bengkulu Utara",
            "Berau",
            "Biak Numfor",
            "Bima",
            "Bima",
            "Binjai",
            "Bintan",
            "Bireuen",
            "Bitung",
            "Blitar",
            "Blitar",
            "Blora",
            "Boalemo",
            "Bogor",
            "Bogor",
            "Bojonegoro",
            "Bolaang Mongondow",
            "Bolaang Mongondow Selatan",
            "Bolaang Mongondow Timur",
            "Bolaang Mongondow Utara",
            "Bombana",
            "Bondowoso",
            "Bone",
            "Bone Bolango",
            "Bontang",
            "Boven Digoel",
            "Boyolali",
            "Brebes",
            "Bukittinggi",
            "Buleleng",
            "Bulukumba",
            "Bulungan",
            "Bungo",
            "Buol",
            "Buru",
            "Buru Selatan",
            "Buton",
            "Buton Selatan",
            "Buton Tengah",
            "Buton Utara",
            "Ciamis",
            "Cianjur",
            "Cilacap",
            "Cilegon",
            "Cimahi",
            "Cirebon",
            "Cirebon",
            "D U M A I",
            "Dairi",
            "Deiyai",
            "Deli Serdang",
            "Demak",
            "Denpasar",
            "Depok",
            "Dharmasraya",
            "Dogiyai",
            "Dompu",
            "Donggala",
            "Empat Lawang",
            "Ende",
            "Enrekang",
            "Fakfak",
            "Flores Timur",
            "Garut",
            "Gayo Lues",
            "Gianyar",
            "Gorontalo",
            "Gorontalo",
            "Gorontalo Utara",
            "Gowa",
            "Gresik",
            "Grobogan",
            "Gunung Kidul",
            "Gunung Mas",
            "Gunungsitoli",
            "Halmahera Barat",
            "Halmahera Selatan",
            "Halmahera Tengah",
            "Halmahera Timur",
            "Halmahera Utara",
            "Hulu Sungai Selatan",
            "Hulu Sungai Tengah",
            "Hulu Sungai Utara",
            "Humbang Hasundutan",
            "Indragiri Hilir",
            "Indragiri Hulu",
            "Indramayu",
            "Intan Jaya",
            "Jakarta Barat",
            "Jakarta Pusat",
            "Jakarta Selatan",
            "Jakarta Timur",
            "Jakarta Utara",
            "Jambi",
            "Jayapura",
            "Jayapura",
            "Jayawijaya",
            "Jember",
            "Jembrana",
            "Jeneponto",
            "Jepara",
            "Jombang",
            "Kaimana",
            "Kampar",
            "Kapuas",
            "Kapuas Hulu",
            "Karang Asem",
            "Karanganyar",
            "Karawang",
            "Karimun",
            "Karo",
            "Katingan",
            "Kaur",
            "Kayong Utara",
            "Kebumen",
            "Kediri",
            "Kediri",
            "Keerom",
            "Kendal",
            "Kendari",
            "Kepahiang",
            "Kepulauan Anambas",
            "Kepulauan Aru",
            "Kepulauan Mentawai",
            "Kepulauan Meranti",
            "Kepulauan Sangihe",
            "Kepulauan Selayar",
            "Kepulauan Seribu",
            "Kepulauan Sula",
            "Kepulauan Talaud",
            "Kepulauan Yapen",
            "Kerinci",
            "Ketapang",
            "Klaten",
            "Klungkung",
            "Kolaka",
            "Kolaka Timur",
            "Kolaka Utara",
            "Konawe",
            "Konawe Kepulauan",
            "Konawe Selatan",
            "Konawe Utara",
            "Kotamobagu",
            "Kotawaringin Barat",
            "Kotawaringin Timur",
            "Kuantan Singingi",
            "Kubu Raya",
            "Kudus",
            "Kulon Progo",
            "Kuningan",
            "Kupang",
            "Kupang",
            "Kutai Barat",
            "Kutai Kartanegara",
            "Kutai Timur",
            "Labuhan Batu",
            "Labuhan Batu Selatan",
            "Labuhan Batu Utara",
            "Lahat",
            "Lamandau",
            "Lamongan",
            "Lampung Barat",
            "Lampung Selatan",
            "Lampung Tengah",
            "Lampung Timur",
            "Lampung Utara",
            "Landak",
            "Langkat",
            "Langsa",
            "Lanny Jaya",
            "Lebak",
            "Lebong",
            "Lembata",
            "Lhokseumawe",
            "Lima Puluh Kota",
            "Lingga",
            "Lombok Barat",
            "Lombok Tengah",
            "Lombok Timur",
            "Lombok Utara",
            "Lubuklinggau",
            "Lumajang",
            "Luwu",
            "Luwu Timur",
            "Luwu Utara",
            "Madiun",
            "Madiun",
            "Magelang",
            "Magelang",
            "Magetan",
            "Mahakam Hulu",
            "Majalengka",
            "Majene",
            "Makassar",
            "Malaka",
            "Malang",
            "Malang",
            "Malinau",
            "Maluku Barat Daya",
            "Maluku Tengah",
            "Maluku Tenggara",
            "Maluku Tenggara Barat",
            "Mamasa",
            "Mamberamo Raya",
            "Mamberamo Tengah",
            "Mamuju",
            "Mamuju Tengah",
            "Mamuju Utara",
            "Manado",
            "Mandailing Natal",
            "Manggarai",
            "Manggarai Barat",
            "Manggarai Timur",
            "Manokwari",
            "Manokwari Selatan",
            "Mappi",
            "Maros",
            "Mataram",
            "Maybrat",
            "Medan",
            "Melawi",
            "Mempawah",
            "Merangin",
            "Merauke",
            "Mesuji",
            "Metro",
            "Mimika",
            "Minahasa",
            "Minahasa Selatan",
            "Minahasa Tenggara",
            "Minahasa Utara",
            "Mojokerto",
            "Mojokerto",
            "Morowali",
            "Morowali Utara",
            "Muara Enim",
            "Muaro Jambi",
            "Mukomuko",
            "Muna",
            "Muna Barat",
            "Murung Raya",
            "Musi Banyuasin",
            "Musi Rawas",
            "Musi Rawas Utara",
            "Nabire",
            "Nagan Raya",
            "Nagekeo",
            "Natuna",
            "Nduga",
            "Ngada",
            "Nganjuk",
            "Ngawi",
            "Nias",
            "Nias Barat",
            "Nias Selatan",
            "Nias Utara",
            "Nunukan",
            "Ogan Ilir",
            "Ogan Komering Ilir",
            "Ogan Komering Ulu",
            "Ogan Komering Ulu Selatan",
            "Ogan Komering Ulu Timur",
            "Pacitan",
            "Padang",
            "Padang Lawas",
            "Padang Lawas Utara",
            "Padang Panjang",
            "Padang Pariaman",
            "Padangsidimpuan",
            "Pagar Alam",
            "Pakpak Bharat",
            "Palangka Raya",
            "Palembang",
            "Palopo",
            "Palu",
            "Pamekasan",
            "Pandeglang",
            "Pangandaran",
            "Pangkajene Dan Kepulauan",
            "Pangkal Pinang",
            "Paniai",
            "Parepare",
            "Pariaman",
            "Parigi Moutong",
            "Pasaman",
            "Pasaman Barat",
            "Paser",
            "Pasuruan",
            "Pasuruan",
            "Pati",
            "Payakumbuh",
            "Pegunungan Arfak",
            "Pegunungan Bintang",
            "Pekalongan",
            "Pekalongan",
            "Pekanbaru",
            "Pelalawan",
            "Pemalang",
            "Pematang Siantar",
            "Penajam Paser Utara",
            "Penukal Abab Lematang Ilir",
            "Pesawaran",
            "Pesisir Barat",
            "Pesisir Selatan",
            "Pidie",
            "Pidie Jaya",
            "Pinrang",
            "Pohuwato",
            "Polewali Mandar",
            "Ponorogo",
            "Pontianak",
            "Poso",
            "Prabumulih",
            "Pringsewu",
            "Probolinggo",
            "Probolinggo",
            "Pulang Pisau",
            "Pulau Morotai",
            "Pulau Taliabu",
            "Puncak",
            "Puncak Jaya",
            "Purbalingga",
            "Purwakarta",
            "Purworejo",
            "Raja Ampat",
            "Rejang Lebong",
            "Rembang",
            "Rokan Hilir",
            "Rokan Hulu",
            "Rote Ndao",
            "S I A K",
            "Sabang",
            "Sabu Raijua",
            "Salatiga",
            "Samarinda",
            "Sambas",
            "Samosir",
            "Sampang",
            "Sanggau",
            "Sarmi",
            "Sarolangun",
            "Sawah Lunto",
            "Sekadau",
            "Seluma",
            "Semarang",
            "Semarang",
            "Seram Bagian Barat",
            "Seram Bagian Timur",
            "Serang",
            "Serang",
            "Serdang Bedagai",
            "Seruyan",
            "Siau Tagulandang Biaro",
            "Sibolga",
            "Sidenreng Rappang",
            "Sidoarjo",
            "Sigi",
            "Sijunjung",
            "Sikka",
            "Simalungun",
            "Simeulue",
            "Singkawang",
            "Sinjai",
            "Sintang",
            "Situbondo",
            "Sleman",
            "Solok",
            "Solok",
            "Solok Selatan",
            "Soppeng",
            "Sorong",
            "Sorong",
            "Sorong Selatan",
            "Sragen",
            "Subang",
            "Subulussalam",
            "Sukabumi",
            "Sukabumi",
            "Sukamara",
            "Sukoharjo",
            "Sumba Barat",
            "Sumba Barat Daya",
            "Sumba Tengah",
            "Sumba Timur",
            "Sumbawa",
            "Sumbawa Barat",
            "Sumedang",
            "Sumenep",
            "Sungai Penuh",
            "Supiori",
            "Surabaya",
            "Surakarta",
            "Tabalong",
            "Tabanan",
            "Takalar",
            "Tambrauw",
            "Tana Tidung",
            "Tana Toraja",
            "Tanah Bumbu",
            "Tanah Datar",
            "Tanah Laut",
            "Tangerang",
            "Tangerang",
            "Tangerang Selatan",
            "Tanggamus",
            "Tanjung Balai",
            "Tanjung Jabung Barat",
            "Tanjung Jabung Timur",
            "Tanjung Pinang",
            "Tapanuli Selatan",
            "Tapanuli Tengah",
            "Tapanuli Utara",
            "Tapin",
            "Tarakan",
            "Tasikmalaya",
            "Tasikmalaya",
            "Tebing Tinggi",
            "Tebo",
            "Tegal",
            "Tegal",
            "Teluk Bintuni",
            "Teluk Wondama",
            "Temanggung",
            "Ternate",
            "Tidore Kepulauan",
            "Timor Tengah Selatan",
            "Timor Tengah Utara",
            "Toba Samosir",
            "Tojo Una-Una",
            "Tolikara",
            "Toli-Toli",
            "Tomohon",
            "Toraja Utara",
            "Trenggalek",
            "Tual",
            "Tuban",
            "Tulang Bawang Barat",
            "Tulangbawang",
            "Tulungagung",
            "Wajo",
            "Wakatobi",
            "Waropen",
            "Way Kanan",
            "Wonogiri",
            "Wonosobo",
            "Yahukimo",
            "Yalimo",
            "Yogyakarta"});
            this.cbRegion.Location = new System.Drawing.Point(456, 117);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(184, 28);
            this.cbRegion.TabIndex = 3;
            this.cbRegion.Text = "Semua";
            // 
            // cbBloodType
            // 
            this.cbBloodType.FormattingEnabled = true;
            this.cbBloodType.Items.AddRange(new object[] {
            "Semua",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbBloodType.Location = new System.Drawing.Point(456, 76);
            this.cbBloodType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBloodType.Name = "cbBloodType";
            this.cbBloodType.Size = new System.Drawing.Size(184, 28);
            this.cbBloodType.TabIndex = 1;
            this.cbBloodType.Text = "Semua";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(205, 175);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(253, 51);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvDonorReq
            // 
            this.dgvDonorReq.AllowUserToAddRows = false;
            this.dgvDonorReq.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDonorReq.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDonorReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonorReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDonorReq.ColumnHeadersHeight = 50;
            this.dgvDonorReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonorReq.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDonorReq.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonorReq.Location = new System.Drawing.Point(32, 251);
            this.dgvDonorReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDonorReq.Name = "dgvDonorReq";
            this.dgvDonorReq.RowHeadersVisible = false;
            this.dgvDonorReq.RowHeadersWidth = 51;
            this.dgvDonorReq.RowTemplate.Height = 25;
            this.dgvDonorReq.Size = new System.Drawing.Size(609, 262);
            this.dgvDonorReq.TabIndex = 25;
            this.dgvDonorReq.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonorReq.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDonorReq.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDonorReq.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDonorReq.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDonorReq.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonorReq.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonorReq.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDonorReq.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonorReq.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvDonorReq.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonorReq.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDonorReq.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvDonorReq.ThemeStyle.ReadOnly = false;
            this.dgvDonorReq.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonorReq.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonorReq.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvDonorReq.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonorReq.ThemeStyle.RowsStyle.Height = 25;
            this.dgvDonorReq.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonorReq.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonorReq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.dgvDonorReq;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.cbBloodType;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.cbRegion;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(313, 76);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(112, 22);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Golongan Darah";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(313, 123);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(112, 22);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "Kota/Kabupaten";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(46, 89);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(111, 22);
            this.guna2HtmlLabel3.TabIndex = 28;
            this.guna2HtmlLabel3.Text = "Nama Pendonor";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(46, 117);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(209, 27);
            this.tbName.TabIndex = 31;
            // 
            // FormCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(676, 548);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvDonorReq);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbBloodType);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCari";
            this.Text = "FormCari";
            this.Load += new System.EventHandler(this.FormCari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbRegion;
        private ComboBox cbBloodType;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonorReq;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private TextBox tbName;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
    }
}