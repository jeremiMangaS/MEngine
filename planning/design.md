# DESIGN





## Concept Ikemen/Mugen
Bagaimana cara membaca karakter ?? 

Setiap karakter memiliki struktur file yang sama <br>
- .def : Berisi daftar dan pemetaan file file lain untuk bisa digunakan oleh engine, sebagai pintu masuk
- .cns & .st : Mengatur state karakter saat ini dan apa yang harus dieksekusi/dilakukan setelah suatu state dijalankan
- .air : Mengatur tiap frame yang harus di render untuk suatu state, yang diambil dari file .sff
- .sff : File yang berisi sprite sheet yang di kompress, dibaca dengan menggunakan indeks untuk tiap frame 
- .act : File yang mengatur palet warna
- .snd : File yang mengatur suara/sebagai arsip suara

*Urutan eksekusi* :<br>
-> Input diterima, diatur oleh file .cmd <br>
-> Engine mengola state yang harus di load, sumber diambil dari file .cns <br>
-> Engine meminta animasi dari state yang akan di load, sumber diambil dari file .air <br>
-> Animasi di load, menggunakan sprite, sumber dari file .sff <br>
-> Animasi di render ( END ) <br>





## Target Concept
- Setiap karakter untuk ME baik yang bersumber dari Mugen maupun Ikemen-Go untuk berbagai versi, akan di ektrak menjadi file binary yang ber-ekstensi mebf (ME Binary File)
- file .mebf adalah sebuah folder yang berisikan berbagai file json untuk mengatur atribut karakter baik hp, damage semua skill/attack, dan kontroller untuk tiap movement. Untuk file assets seperti .sff, .act, .snd akan di ekstrak untuk menjadi standar utama me engine
- Dapat mengatasi perbedaan standar penulisan data untuk versi Mugen dan Ikemen-Go yang mana menggunakan mekanisme zss yang lebih kompleks karena mengikuti konsep pemograman






## ME Engine






## ME to Char

- Engine harus bisa mengambil data karakter dari berbagai jenis baik Mugen maupun Ikemen Go dan dari berbagai versi masing masing, data harus dibuat dengan struktur konsisten dan dapat mengatasi berbagai bentuk data kustom yang memungkinkan ada di beberapa jenis karakter, seperti state perubahan untuk Goku, Naruto, dll atau Kratos yang memungkinkan ia dapat hidup kembali dengan beberapa syarat tertentu.
- Data akan dimasukkan dan dikelompokkan ke dalam 1 folder karakter yang berisi aset serta data yang sudah diambil dan disimpan dalam file json
- Memecah struktur kontrol dan interaksi karakter ke beberapa file, diantaranya : 
    - char_data.json <br>
        Berisi data data utama karakter seperti HP, attack, power, defence, dan sejenisnya dari file .cns label [Data], dan label [Size] untuk mengurus penggambaran, serta data dari file .def untuk label [Info] dan [Arcade]
    - char_interact.json
        Mengurus bagaimana karakter bergerak dan kecepatannya, bersumber dari file .cns label [Velocity] dan [Movement]
    - char_move.json
        Berisi daftar teknik/serangan dari karakter beserta 1/2 command yang sudah di set, file akan mengurus kontrol kombo/command untuk mengaktifkan serangan tersebut
    - .cns & .st file (utuh dan lengkap), sebagai kamus untuk menjalankan karakter

**Mekanisme**








## PERKEMBANGAN ME ENGINE
### ME v.P.1.1
**ME Engine**
- Sistem arena sederhana untuk pijakan tiap karakter
- Fokus pada mekanisme game dasar yang sederhana dengan interaksi utama dari 2 karakter

**ME to Char**
- Fokus untuk mengambil data dari karakter karakter versi MUGEN, mengabaikan mekanisme data dari versi zss milik Ikemen-Go
- Fokus mengambil data utama per karakter : 
    - HP
    - Kecepatan berjalan, berlari, melompat, terbang atau yang lainnya/sejenisnya
    - Pengatur palette karakter
    - Kontrol attack dasar dan berbagai kombo karakter
    - Damage attack dasar dan berbagai kombo karakter 
- Mengabaikan file asset yaitu : .act, .sff, .snd, .air
- Mengonversi file asset sprite .sff ke standar ME
- Mengonversi file asset suara .snd ke standar ME
- Mengonversi file asset frame .air ke standar ME 
- Mengatur interaksi karakter melalui file utama seperti .cns, .st, atau file lain yang tidak di ekstrak melainkan langsung diambil  untuk langsung digunakan, namun menggunakan damage atau kontrol yang sudah di tetapkan oleh file json ME
-Mengonversi folder karakter yang siap dijalankan menjadi file binary berekstensi .mebf