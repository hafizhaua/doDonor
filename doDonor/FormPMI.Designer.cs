namespace doDonor
{
    partial class FormPMI
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
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPMI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrcA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTcA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWbA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrcB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTcB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWbB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrcO = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTcO = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWbO = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrcAb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTcAb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWbAb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddStock = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            "Batam",
            "Badung",
            "Balangan",
            "Balikpapan",
            "Banda Aceh",
            "Bandar Lampung",
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
            "Binjai",
            "Bintan",
            "Bireuen",
            "Bitung",
            "Blitar",
            "Blora",
            "Boalemo",
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
            "Dumai",
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
            "Magelang",
            "Magetan",
            "Mahakam Hulu",
            "Majalengka",
            "Majene",
            "Makassar",
            "Malaka",
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
            "Pati",
            "Payakumbuh",
            "Pegunungan Arfak",
            "Pegunungan Bintang",
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
            "Siak",
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
            "Seram Bagian Barat",
            "Seram Bagian Timur",
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
            "Solok Selatan",
            "Soppeng",
            "Sorong",
            "Sorong Selatan",
            "Sragen",
            "Subang",
            "Subulussalam",
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
            "Tebing Tinggi",
            "Tebo",
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
            this.cbRegion.Location = new System.Drawing.Point(52, 99);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(270, 28);
            this.cbRegion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(270, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari Lokasi PMI";
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
            this.btnSearch.Location = new System.Drawing.Point(364, 99);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(253, 28);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.cbRegion;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(332, 232);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(31, 30);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "A+";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(406, 232);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(30, 30);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "B+";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(486, 232);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(44, 30);
            this.guna2HtmlLabel3.TabIndex = 28;
            this.guna2HtmlLabel3.Text = "AB+";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(585, 232);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(32, 30);
            this.guna2HtmlLabel4.TabIndex = 29;
            this.guna2HtmlLabel4.Text = "O+";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(54, 232);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(211, 30);
            this.guna2HtmlLabel5.TabIndex = 30;
            this.guna2HtmlLabel5.Text = "Jenis Transfusi/Donor";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(54, 281);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(36, 30);
            this.guna2HtmlLabel6.TabIndex = 31;
            this.guna2HtmlLabel6.Text = "WB";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(54, 339);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(27, 30);
            this.guna2HtmlLabel7.TabIndex = 32;
            this.guna2HtmlLabel7.Text = "TC";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(54, 393);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(40, 30);
            this.guna2HtmlLabel8.TabIndex = 33;
            this.guna2HtmlLabel8.Text = "PRC";
            this.guna2HtmlLabel8.Click += new System.EventHandler(this.guna2HtmlLabel8_Click);
            // 
            // lblPMI
            // 
            this.lblPMI.AutoSize = true;
            this.lblPMI.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPMI.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPMI.Location = new System.Drawing.Point(252, 151);
            this.lblPMI.Name = "lblPMI";
            this.lblPMI.Size = new System.Drawing.Size(198, 28);
            this.lblPMI.TabIndex = 34;
            this.lblPMI.Text = "Stok Darah UTD PMI";
            this.lblPMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(54, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Jumlah stok darah dapat berubah sewaktu-waktu.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(54, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Silakan kontak UTD PMI terkait untuk informasi terbaru.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(52, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Diperbarui tanggal";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.Snow;
            this.lblDate.Location = new System.Drawing.Point(168, 202);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(13, 17);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "-";
            // 
            // lblPrcA
            // 
            this.lblPrcA.BackColor = System.Drawing.Color.Transparent;
            this.lblPrcA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrcA.ForeColor = System.Drawing.Color.Gold;
            this.lblPrcA.Location = new System.Drawing.Point(332, 393);
            this.lblPrcA.Name = "lblPrcA";
            this.lblPrcA.Size = new System.Drawing.Size(15, 30);
            this.lblPrcA.TabIndex = 41;
            this.lblPrcA.Text = "0";
            // 
            // lblTcA
            // 
            this.lblTcA.BackColor = System.Drawing.Color.Transparent;
            this.lblTcA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTcA.ForeColor = System.Drawing.Color.Gold;
            this.lblTcA.Location = new System.Drawing.Point(332, 339);
            this.lblTcA.Name = "lblTcA";
            this.lblTcA.Size = new System.Drawing.Size(15, 30);
            this.lblTcA.TabIndex = 40;
            this.lblTcA.Text = "0";
            // 
            // lblWbA
            // 
            this.lblWbA.BackColor = System.Drawing.Color.Transparent;
            this.lblWbA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWbA.ForeColor = System.Drawing.Color.Gold;
            this.lblWbA.Location = new System.Drawing.Point(332, 281);
            this.lblWbA.Name = "lblWbA";
            this.lblWbA.Size = new System.Drawing.Size(15, 30);
            this.lblWbA.TabIndex = 39;
            this.lblWbA.Text = "0";
            // 
            // lblPrcB
            // 
            this.lblPrcB.BackColor = System.Drawing.Color.Transparent;
            this.lblPrcB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrcB.ForeColor = System.Drawing.Color.Gold;
            this.lblPrcB.Location = new System.Drawing.Point(406, 393);
            this.lblPrcB.Name = "lblPrcB";
            this.lblPrcB.Size = new System.Drawing.Size(15, 30);
            this.lblPrcB.TabIndex = 44;
            this.lblPrcB.Text = "0";
            // 
            // lblTcB
            // 
            this.lblTcB.BackColor = System.Drawing.Color.Transparent;
            this.lblTcB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTcB.ForeColor = System.Drawing.Color.Gold;
            this.lblTcB.Location = new System.Drawing.Point(406, 339);
            this.lblTcB.Name = "lblTcB";
            this.lblTcB.Size = new System.Drawing.Size(15, 30);
            this.lblTcB.TabIndex = 43;
            this.lblTcB.Text = "0";
            // 
            // lblWbB
            // 
            this.lblWbB.BackColor = System.Drawing.Color.Transparent;
            this.lblWbB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWbB.ForeColor = System.Drawing.Color.Gold;
            this.lblWbB.Location = new System.Drawing.Point(406, 281);
            this.lblWbB.Name = "lblWbB";
            this.lblWbB.Size = new System.Drawing.Size(15, 30);
            this.lblWbB.TabIndex = 42;
            this.lblWbB.Text = "0";
            // 
            // lblPrcO
            // 
            this.lblPrcO.BackColor = System.Drawing.Color.Transparent;
            this.lblPrcO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrcO.ForeColor = System.Drawing.Color.Gold;
            this.lblPrcO.Location = new System.Drawing.Point(585, 393);
            this.lblPrcO.Name = "lblPrcO";
            this.lblPrcO.Size = new System.Drawing.Size(15, 30);
            this.lblPrcO.TabIndex = 50;
            this.lblPrcO.Text = "0";
            // 
            // lblTcO
            // 
            this.lblTcO.BackColor = System.Drawing.Color.Transparent;
            this.lblTcO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTcO.ForeColor = System.Drawing.Color.Gold;
            this.lblTcO.Location = new System.Drawing.Point(585, 339);
            this.lblTcO.Name = "lblTcO";
            this.lblTcO.Size = new System.Drawing.Size(15, 30);
            this.lblTcO.TabIndex = 49;
            this.lblTcO.Text = "0";
            // 
            // lblWbO
            // 
            this.lblWbO.BackColor = System.Drawing.Color.Transparent;
            this.lblWbO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWbO.ForeColor = System.Drawing.Color.Gold;
            this.lblWbO.Location = new System.Drawing.Point(585, 281);
            this.lblWbO.Name = "lblWbO";
            this.lblWbO.Size = new System.Drawing.Size(15, 30);
            this.lblWbO.TabIndex = 48;
            this.lblWbO.Text = "0";
            // 
            // lblPrcAb
            // 
            this.lblPrcAb.BackColor = System.Drawing.Color.Transparent;
            this.lblPrcAb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrcAb.ForeColor = System.Drawing.Color.Gold;
            this.lblPrcAb.Location = new System.Drawing.Point(486, 393);
            this.lblPrcAb.Name = "lblPrcAb";
            this.lblPrcAb.Size = new System.Drawing.Size(15, 30);
            this.lblPrcAb.TabIndex = 47;
            this.lblPrcAb.Text = "0";
            // 
            // lblTcAb
            // 
            this.lblTcAb.BackColor = System.Drawing.Color.Transparent;
            this.lblTcAb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTcAb.ForeColor = System.Drawing.Color.Gold;
            this.lblTcAb.Location = new System.Drawing.Point(486, 339);
            this.lblTcAb.Name = "lblTcAb";
            this.lblTcAb.Size = new System.Drawing.Size(15, 30);
            this.lblTcAb.TabIndex = 46;
            this.lblTcAb.Text = "0";
            // 
            // lblWbAb
            // 
            this.lblWbAb.BackColor = System.Drawing.Color.Transparent;
            this.lblWbAb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWbAb.ForeColor = System.Drawing.Color.Gold;
            this.lblWbAb.Location = new System.Drawing.Point(486, 281);
            this.lblWbAb.Name = "lblWbAb";
            this.lblWbAb.Size = new System.Drawing.Size(15, 30);
            this.lblWbAb.TabIndex = 45;
            this.lblWbAb.Text = "0";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BorderRadius = 15;
            this.btnAddStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStock.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStock.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(461, 456);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(156, 48);
            this.btnAddStock.TabIndex = 51;
            this.btnAddStock.Text = "Perbarui Data";
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(52, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Kota/Kabupaten";
            // 
            // FormPMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(685, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.lblPrcO);
            this.Controls.Add(this.lblTcO);
            this.Controls.Add(this.lblWbO);
            this.Controls.Add(this.lblPrcAb);
            this.Controls.Add(this.lblTcAb);
            this.Controls.Add(this.lblWbAb);
            this.Controls.Add(this.lblPrcB);
            this.Controls.Add(this.lblTcB);
            this.Controls.Add(this.lblWbB);
            this.Controls.Add(this.lblPrcA);
            this.Controls.Add(this.lblTcA);
            this.Controls.Add(this.lblWbA);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPMI);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPMI";
            this.Text = "FormPMI";
            this.Load += new System.EventHandler(this.FormPMI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbRegion;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Label lblPMI;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrcA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTcA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWbA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrcB;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTcB;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWbB;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrcO;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTcO;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWbO;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrcAb;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTcAb;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWbAb;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddStock;
        private Label label2;
    }
}