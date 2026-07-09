# DATA UNTUK FILE .CNS

[Data]

[Size]

[Velocity]

[Movement]

Data kalimat kemenangan/victory, dapat berupa 1 - seterusnya

**Yang perlu diambil**
- [Data]
    - life                = int
    - power               = int
    - attack              = int
    - defence             = int
    - dizzypoints         = int (Untuk sistem stun)
    - guardpoints         = int (Untuk sistem stun)
    - fall.defence_up     = int (Untuk perhitungan kombo saat jatuh)
    - liedown.time        = int
    - airjuggle           = int
    - sparkno             = int (Untuk efek visual)
    - guard.sparkno       = int (Untuk efek visual)
    - hitsound.channel    = int (Untuk efek audio)
    - guardsound.channel  = int (Untuk efek audio)
    - KO.echo             = int (Untuk efek audio saat kalah)
    - volume              = int
    - IntPersistIndex     = int (Untuk data yang dipertahankan sampai ronde selanjutnya di permainan)
    - FloatPersistIndex   = float (Untuk data yang dipertahankan sampai ronde selanjutnya di permainan)

- [Size]
    - xscale              = float
    - yscale              = float
    - ground.back         = int
    - ground.front        = int
    - air.back            = int
    - air.front           = int
    - height              = int (Untuk posisi Y dalam pixel)
    - height.crouch       = int
    - height.air (x, y)   = float
    - height.down         = int
    - attack.dist         = int (Untuk AI)
    - proj.attack.dist    = int (Untuk AI)
    - proj.doscale        = int (Untuk mengatur skala proyektil)
    - head.pos (x, y)     = float
    - mid.pos (x, y)      = float
    - shadowoffset        = int (Untuk posisi bayangan dibawah karakter)
    - draw.offset (x, y)  = float

- [Velocity]
    - walk.fwd                            = float
    - walk.back                           = float
    - run.fwd                             = float
    - run.back (x, y)                     = float
    - jump.neu (x, y)                     = float
    - jump.back                           = float
    - jump.fwd                            = float
    - runjump.back (x, y)                 = float
    - runjump.fwd (x, y)                  = float
    - runjump.neu (x, y)                  = float
    - air.gethit.groundrecover (x, y)     = float
    - air.gethit.airrecover.mul (x, y)    = float
    - air.gethit.airrecover.add           = float
    - air.gethit.airrecover.back          = float
    - air.gethit.airrecover.fwd           = float
    - air.gethit.airrecover.up            = float
    - air.gethit.airrecover.down          = float

- [Movement]
    - airjump.num                                 = int
    - airjump.height                              = float
    - yaccel                                      = float
    - stand.friction                              = float
    - crouch.friction                             = float
    - air.gethit.groundlevel                      = float
    - air.gethit.groundrecover.ground.threshold   = float (Untuk data spesifik dari aksi jatuh)
    - air.gethit.groundrecover.groundlevel        = float (Untuk data spesifik dari aksi jatuh)
    - air.gethit.airrecover.threshold             = float (Untuk data spesifik dari aksi jatuh)
    - air.gethit.airrecover.yaccel                = float (Untuk data spesifik dari aksi jatuh)
    - air.gethit.trip.groundlevel                 = float (Untuk data spesifik dari aksi jatuh)
    - down.bounce.yaccel                          = float
    - down.bounce.offset                          = float
    - down.bounce.groundlevel                     = float
    - down.friction.threshold                     = float
    - animtagenteringscreen                       = float (Untuk animasi karakter masuk arena)
    - animtagleavingscreen                        = float (Untuk animasi karakter keluar arena)


## Data untuk v.P.1.1
Hanya berisi data data dasar yang dapat membuat interaksi karakter tetap maksimal, dan membuang data data pendukung lainnya utuk versi selanjutnya. Versi ini hanya memfokuskan pada gameplay maksimal terlebih dahulu

Data data tersebut diantaranya : <br>
- [Data] ( 7 data utama )
    - life                = int
    - power               = int
    - attack              = int
    - defence             = int
    - liedown.time        = int
    - airjuggle           = int
    - volume              = int

- [Size] ( 13 data utama )
    - xscale              = float
    - yscale              = float
    - ground.back         = int
    - ground.front        = int
    - air.back            = int
    - air.front           = int
    - height              = int
    - height.crouch       = int
    - height.air (x, y)   = float
    - height.down         = int
    - head.pos (x, y)     = float
    - mid.pos (x, y)      = float
    - draw.offset (x, y)  = float

- [Velocity] ( 17 data utama )
    - walk.fwd                            = float
    - walk.back                           = float
    - run.fwd                             = float
    - run.back (x, y)                     = float
    - jump.neu (x, y)                     = float
    - jump.back                           = float
    - jump.fwd                            = float
    - runjump.back (x, y)                 = float
    - runjump.fwd (x, y)                  = float
    - runjump.neu (x, y)                  = float
    - air.gethit.groundrecover (x, y)     = float
    - air.gethit.airrecover.mul (x, y)    = float
    - air.gethit.airrecover.add           = float
    - air.gethit.airrecover.back          = float
    - air.gethit.airrecover.fwd           = float
    - air.gethit.airrecover.up            = float
    - air.gethit.airrecover.down          = float

- [Movement] ( 10 data utama )
    - airjump.num                                 = int
    - airjump.height                              = float
    - yaccel                                      = float
    - stand.friction                              = float
    - crouch.friction                             = float
    - air.gethit.groundlevel                      = float
    - down.bounce.yaccel                          = float
    - down.bounce.offset                          = float
    - down.bounce.groundlevel                     = float
    - down.friction.threshold                     = float
