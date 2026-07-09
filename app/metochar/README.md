# README FOR MECr

Menggunakan arsitektur .NET dengan bahasa pemograman C#



## Proses kerja MECr
MECr bekerja dengan beberapa langkah, diantaranya : 
- M


## Data yang diperlukan untuk v.P.1.1
**Dari file .cns :**  <br>
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

**Dari file .def :** <br>
- [Info] ( 10 data utama )
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