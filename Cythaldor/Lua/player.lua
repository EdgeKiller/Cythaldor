--[[ INFOS:
� Global Variable
	- this -> Player

� Functions
	- this:getPos() -> Return player position (Vector2)
	- this:setPos(x,y) -> Set player position (void)
	- this:isKeyDown(keyCode) -> Return if the key is down (bool)
--]]

--[[ KEY CODES:
� Keys.None               = 0
� Keys.LButton            = 1
� Keys.RButton            = 2
� Keys.Cancel             = 3
� Keys.MButton            = 4
� Keys.XButton1           = 5
� Keys.XButton2           = 6
� Keys.Back               = 8
� Keys.Tab                = 9
� Keys.LineFeed           = 10
� Keys.Clear              = 12
� Keys.Return             = 13
� Keys.ShiftKey           = 16
� Keys.ControlKey         = 17
� Keys.Menu               = 18
� Keys.Pause              = 19
� Keys.Capital            = 20
� Keys.KanaMode           = 21
� Keys.JunjaMode          = 23
� Keys.FinalMode          = 24
� Keys.HanjaMode          = 25
� Keys.Escape             = 27
� Keys.IMEConvert         = 28
� Keys.IMENonconvert      = 29
� Keys.IMEAceept          = 30
� Keys.IMEModeChange      = 31
� Keys.Space              = 32
� Keys.PageUp             = 33
� Keys.Next               = 34
� Keys.End                = 35
� Keys.Home               = 36
� Keys.Left               = 37
� Keys.Up                 = 38
� Keys.Right              = 39
� Keys.Down               = 40
� Keys.Select             = 41
� Keys.Print              = 42
� Keys.Execute            = 43
� Keys.PrintScreen        = 44
� Keys.Insert             = 45
� Keys.Delete             = 46
� Keys.Help               = 47
� Keys.D0                 = 48
� Keys.D1                 = 49
� Keys.D2                 = 50
� Keys.D3                 = 51
� Keys.D4                 = 52
� Keys.D5                 = 53
� Keys.D6                 = 54
� Keys.D7                 = 55
� Keys.D8                 = 56
� Keys.D9                 = 57
� Keys.A                  = 65
� Keys.B                  = 66
� Keys.C                  = 67
� Keys.D                  = 68
� Keys.E                  = 69
� Keys.F                  = 70
� Keys.G                  = 71
� Keys.H                  = 72
� Keys.I                  = 73
� Keys.J                  = 74
� Keys.K                  = 75
� Keys.L                  = 76
� Keys.M                  = 77
� Keys.N                  = 78
� Keys.O                  = 79
� Keys.P                  = 80
� Keys.Q                  = 81
� Keys.R                  = 82
� Keys.S                  = 83
� Keys.T                  = 84
� Keys.U                  = 85
� Keys.V                  = 86
� Keys.W                  = 87
� Keys.X                  = 88
� Keys.Y                  = 89
� Keys.Z                  = 90
� Keys.LWin               = 91
� Keys.RWin               = 92
� Keys.Apps               = 93
� Keys.Sleep              = 95
� Keys.NumPad0            = 96
� Keys.NumPad1            = 97
� Keys.NumPad2            = 98
� Keys.NumPad3            = 99
� Keys.NumPad4            = 100
� Keys.NumPad5            = 101
� Keys.NumPad6            = 102
� Keys.NumPad7            = 103
� Keys.NumPad8            = 104
� Keys.NumPad9            = 105
� Keys.Multiply           = 106
� Keys.Add                = 107
� Keys.Separator          = 108
� Keys.Subtract           = 109
� Keys.Decimal            = 110
� Keys.Divide             = 111
� Keys.F1                 = 112
� Keys.F2                 = 113
� Keys.F3                 = 114
� Keys.F4                 = 115
� Keys.F5                 = 116
� Keys.F6                 = 117
� Keys.F7                 = 118
� Keys.F8                 = 119
� Keys.F9                 = 120
� Keys.F10                = 121
� Keys.F11                = 122
� Keys.F12                = 123
� Keys.F13                = 124
� Keys.F14                = 125
� Keys.F15                = 126
� Keys.F16                = 127
� Keys.F17                = 128
� Keys.F18                = 129
� Keys.F19                = 130
� Keys.F20                = 131
� Keys.F21                = 132
� Keys.F22                = 133
� Keys.F23                = 134
� Keys.F24                = 135
� Keys.NumLock            = 144
� Keys.Scroll             = 145
� Keys.LShiftKey          = 160
� Keys.RShiftKey          = 161
� Keys.LControlKey        = 162
� Keys.RControlKey        = 163
� Keys.LMenu              = 164
� Keys.RMenu              = 165
� Keys.BrowserBack        = 166
� Keys.BrowserForward     = 167
� Keys.BrowserRefresh     = 168
� Keys.BrowserStop        = 169
� Keys.BrowserSearch      = 170
� Keys.BrowserFavorites   = 171
� Keys.BrowserHome        = 172
� Keys.VolumeMute         = 173
� Keys.VolumeDown         = 174
� Keys.VolumeUp           = 175
� Keys.MediaNextTrack     = 176
� Keys.MediaPreviousTrack = 177
� Keys.MediaStop          = 178
� Keys.MediaPlayPause     = 179
� Keys.LaunchMail         = 180
� Keys.SelectMedia        = 181
� Keys.LaunchApplication1 = 182
� Keys.LaunchApplication2 = 183
� Keys.Oem1               = 186
� Keys.Oemplus            = 187
� Keys.Oemcomma           = 188
� Keys.OemMinus           = 189
� Keys.OemPeriod          = 190
� Keys.OemQuestion        = 191
� Keys.Oemtilde           = 192
� Keys.OemOpenBrackets    = 219
� Keys.Oem5               = 220
� Keys.Oem6               = 221
� Keys.Oem7               = 222
� Keys.Oem8               = 223
� Keys.OemBackslash       = 226
� Keys.ProcessKey         = 229
� Keys.Packet             = 231
� Keys.Attn               = 246
� Keys.Crsel              = 247
� Keys.Exsel              = 248
� Keys.EraseEof           = 249
� Keys.Play               = 250
� Keys.Zoom               = 251
� Keys.NoName             = 252
� Keys.Pa1                = 253
� Keys.OemClear           = 254
� Keys.KeyCode            = 65535
� Keys.Shift              = 65536
� Keys.Control            = 131072
� Keys.Alt                = 262144
� Keys.Modifiers          = -65536
--]]

local PLAYER_SPEED = 2
local PLAYER_KEY_UP = 90
local PLAYER_KEY_DOWN = 83
local PLAYER_KEY_LEFT = 81
local PLAYER_KEY_RIGHT = 68


local PLAYER_POS = nil
local PLAYER_TEX = nil

function update()
	PLAYER_POS = this:getPos()
	PLAYER_TEX = this:getTexture()

	if(this:isKeyDown(PLAYER_KEY_UP) == true) then
		this:setPos(PLAYER_POS.X, PLAYER_POS.Y - PLAYER_SPEED)
	elseif(this:isKeyDown(PLAYER_KEY_DOWN) == true) then
		this:setPos(PLAYER_POS.X, PLAYER_POS.Y + PLAYER_SPEED)
	elseif(this:isKeyDown(PLAYER_KEY_LEFT) == true) then
		this:setPos(PLAYER_POS.X - PLAYER_SPEED, PLAYER_POS.Y)
	elseif(this:isKeyDown(PLAYER_KEY_RIGHT) == true) then
		this:setPos(PLAYER_POS.X + PLAYER_SPEED, PLAYER_POS.Y)
	end

end

function draw(sb)

	sb:Draw(PLAYER_TEX,PLAYER_POS,colorWhite)

end
