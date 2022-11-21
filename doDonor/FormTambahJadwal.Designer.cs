namespace doDonor
{
    partial class FormTambahJadwal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPickDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(189, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kota/Kabupaten UTD PMI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(189, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tanggal";
            // 
            // tbLocation
            // 
            this.tbLocation.BackColor = System.Drawing.SystemColors.Window;
            this.tbLocation.Location = new System.Drawing.Point(189, 262);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(275, 27);
            this.tbLocation.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(189, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nama Lokasi";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbAddress.Location = new System.Drawing.Point(189, 338);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(275, 27);
            this.tbAddress.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(189, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Alamat Lokasi";
            // 
            // dtPickDate
            // 
            this.dtPickDate.Checked = true;
            this.dtPickDate.FillColor = System.Drawing.Color.White;
            this.dtPickDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPickDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPickDate.Location = new System.Drawing.Point(189, 194);
            this.dtPickDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickDate.Name = "dtPickDate";
            this.dtPickDate.Size = new System.Drawing.Size(275, 28);
            this.dtPickDate.TabIndex = 79;
            this.dtPickDate.Value = new System.DateTime(2022, 11, 20, 21, 31, 28, 476);
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
            this.cbRegion.Location = new System.Drawing.Point(189, 123);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(275, 28);
            this.cbRegion.TabIndex = 80;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 15;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(230, 392);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(199, 51);
            this.btnSubmit.TabIndex = 81;
            this.btnSubmit.Text = "Kirim";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormTambahJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(676, 548);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.dtPickDate);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTambahJadwal";
            this.Text = "FormTambahJadwal";
            this.Load += new System.EventHandler(this.FormTambahJadwal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox tbLocation;
        private Label label3;
        private TextBox tbAddress;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPickDate;
        private ComboBox cbRegion;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubmit;
    }
}