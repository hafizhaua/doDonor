namespace doDonor
{
    partial class FormUpdateDonorReq
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
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbBagQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbRhesus = new System.Windows.Forms.ComboBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbDonorType = new System.Windows.Forms.ComboBox();
            this.cbBloodType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCpPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbCpName = new System.Windows.Forms.TextBox();
            this.tbHospitalName = new System.Windows.Forms.TextBox();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbBagQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(202, 498);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(253, 51);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Perbarui";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(202, 27);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(274, 30);
            this.guna2HtmlLabel1.TabIndex = 27;
            this.guna2HtmlLabel1.Text = "Perbarui Permohonan Donor";
            // 
            // tbBagQuantity
            // 
            this.tbBagQuantity.BackColor = System.Drawing.Color.Transparent;
            this.tbBagQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBagQuantity.Location = new System.Drawing.Point(22, 347);
            this.tbBagQuantity.Name = "tbBagQuantity";
            this.tbBagQuantity.Size = new System.Drawing.Size(275, 28);
            this.tbBagQuantity.TabIndex = 46;
            this.tbBagQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbRhesus
            // 
            this.cbRhesus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRhesus.FormattingEnabled = true;
            this.cbRhesus.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbRhesus.Location = new System.Drawing.Point(22, 253);
            this.cbRhesus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRhesus.Name = "cbRhesus";
            this.cbRhesus.Size = new System.Drawing.Size(275, 28);
            this.cbRhesus.TabIndex = 43;
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
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
            this.cbRegion.Location = new System.Drawing.Point(358, 136);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(275, 28);
            this.cbRegion.TabIndex = 42;
            // 
            // cbDonorType
            // 
            this.cbDonorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDonorType.FormattingEnabled = true;
            this.cbDonorType.Items.AddRange(new object[] {
            "WB",
            "TC",
            "PRC"});
            this.cbDonorType.Location = new System.Drawing.Point(22, 437);
            this.cbDonorType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDonorType.Name = "cbDonorType";
            this.cbDonorType.Size = new System.Drawing.Size(275, 28);
            this.cbDonorType.TabIndex = 41;
            // 
            // cbBloodType
            // 
            this.cbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBloodType.FormattingEnabled = true;
            this.cbBloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cbBloodType.Location = new System.Drawing.Point(22, 223);
            this.cbBloodType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBloodType.Name = "cbBloodType";
            this.cbBloodType.Size = new System.Drawing.Size(275, 28);
            this.cbBloodType.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(360, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Kontak Pendamping";
            // 
            // tbCpPhoneNumber
            // 
            this.tbCpPhoneNumber.Location = new System.Drawing.Point(360, 400);
            this.tbCpPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCpPhoneNumber.Name = "tbCpPhoneNumber";
            this.tbCpPhoneNumber.Size = new System.Drawing.Size(275, 27);
            this.tbCpPhoneNumber.TabIndex = 38;
            // 
            // tbCpName
            // 
            this.tbCpName.Location = new System.Drawing.Point(360, 311);
            this.tbCpName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCpName.Name = "tbCpName";
            this.tbCpName.Size = new System.Drawing.Size(275, 27);
            this.tbCpName.TabIndex = 37;
            // 
            // tbHospitalName
            // 
            this.tbHospitalName.Location = new System.Drawing.Point(358, 223);
            this.tbHospitalName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHospitalName.Name = "tbHospitalName";
            this.tbHospitalName.Size = new System.Drawing.Size(275, 27);
            this.tbHospitalName.TabIndex = 36;
            // 
            // tbPatientName
            // 
            this.tbPatientName.BackColor = System.Drawing.SystemColors.Window;
            this.tbPatientName.Location = new System.Drawing.Point(22, 136);
            this.tbPatientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(275, 27);
            this.tbPatientName.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(358, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nama Pendamping";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(358, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nama Rumah Sakit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(358, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Kota/Kabupaten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(22, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipe Donor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Jumlah Kantong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Golongan Darah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nama Pasien";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(315, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 22);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "ID";
            this.lblID.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Brown;
            this.btnDelete.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(268, 567);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 51);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Hapus Data";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormUpdateDonorReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(656, 661);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbBagQuantity);
            this.Controls.Add(this.cbRhesus);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbDonorType);
            this.Controls.Add(this.cbBloodType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCpPhoneNumber);
            this.Controls.Add(this.tbCpName);
            this.Controls.Add(this.tbHospitalName);
            this.Controls.Add(this.tbPatientName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "FormUpdateDonorReq";
            this.Text = "FormUpdateDonorReq";
            this.Load += new System.EventHandler(this.FormUpdateDonorReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBagQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown tbBagQuantity;
        private ComboBox cbRhesus;
        private ComboBox cbRegion;
        private ComboBox cbDonorType;
        private ComboBox cbBloodType;
        private Label label9;
        private TextBox tbCpPhoneNumber;
        private TextBox tbCpName;
        private TextBox tbHospitalName;
        private TextBox tbPatientName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
    }
}