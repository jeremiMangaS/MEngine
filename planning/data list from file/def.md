# DATA  UNTUK FILE .DEF

[Info] : Metadata karakter, `perlu diambil`

[Files] : Daftar alamat file file yang diperlukan, ini tidak perlu diadopsi secara langsung, karena ME Engine akan memiliki struktur yaang sedikit berbeda dalam mengatur komunikasi antar filenya

[Arcade] Opsional : Berisi story board untuk mode arcade, namun tidak semua karakter memiliki ini dan memang tidak wajib, `perlu diambil`

**Yang perlu diambil**
- [Info]
    - name            = string
    - displayname     = string
    - lifebarname     = string
    - versiondate     = string
    - mugenversion    = string
    - ikemenversion   = string
    - author          = string
    - Pal.Defaults    = int[]
    - portraitscale   = float
    - localcoord      = x, y (Default : 320, 240)

- [Arcade]
    - intro.storyboard    = string (filepath)
    - ending.storyboard   = string (filepath)