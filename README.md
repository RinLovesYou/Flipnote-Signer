# Flipnote-Encoder

A Flipnote encoder written in C#

uses binaries from [ffmpeg](https://ffmpeg.org) for video manipulation.

[![ForTheBadge built-with-swag](http://ForTheBadge.com/images/badges/built-with-swag.svg)](https://github.com/RinLovesYou) 

[![Support Server](https://img.shields.io/discord/815244291366453259.svg?label=Support_Server&logo=Discord&colorB=7289da&style=for-the-badge)](https://discord.gg/MBM9ZeAjna)

# Quickstart
* download and unzip the latest [release](https://github.com/RinLovesYou/Flipnote-Encoder/releases) 
* place the video called `input.mp4` in the `frames` folder, make sure no other files exist there
* Replace the Dummy Flipnote with one of your own. This will embed your User Information
* (Optional) place the Flipnote Studio Private Key (good luck getting that one) called `fnkey.pem` in the same folder as the exe

[![forthebadge](https://forthebadge.com/images/badges/powered-by-energy-drinks.svg)](https://forthebadge.com)

# config.json
Located inside the Root folder is a config.json. Should it not exist, a new one will be created by the program.
Here you can see all the config Items with a description of how to use them:
```Java
{
  // One of 14 possible Dithering algorithms. Most of these don't require imagemagick to be installed, except for the last one.
  // 0 = None, 1-3 = Bayer8x8/4x4/1x1, 4 = Floyd Steinberg, 5 = Atkinson, 6 = Burkes, 7 = Jarvis, 8 = StevensonArce, 9 = Sierra2, 10 = Sierra3 
  // 11 = SierraLite, 12 = Stucki, 13 = Ordered3x3, 14 = imagemagick (needs to be installed)
  // Different Algorithms will look better on different videos.
  "DitheringMode": 1,
  // Wether or not to turn the Video into 30FPS to fix sound sync issues. Is on by default to avoid these issues. Can save a bit on filesize for <30FPS videos.
  "Accurate": true,
  // Adds the option for contrast bump, helps with visual clarity in some cases
  "Contrast": 0,
  // Not working, once implemented will split the video into parts that are all playable on a dsi/3ds
  "Split": false,
  // Self Explanatory
  "DeleteOnFinish": true
}
```

Expect bugs and report them in the [issues](https://github.com/RinLovesYou/Flipnote-Encoder/issues) section please.

it won't sign a flipnote if no `fnkey.pem` exists, you can still play it back with most online players like [rakujira](https://flipnote.rakujira.jp) though.

![screenshot](https://media.discordapp.net/attachments/738116823035150356/812439551930007582/unknown.png)

# FAQ
* Q: why won't it play on my dsi? A: You don't have the flipnote private key
* Q: Can you give it to me? A: no good luck googling for it
* Q: Can you add x? A: Yes! Maybe! suggest in [issues](https://github.com/RinLovesYou/Flipnote-Signer/issues)

[discord:](https://discord.gg/MBM9ZeAjna) `Rin#6969`

[twitter:](https://twitter.com/does_rin) `@does_rin`

## Special Thanks
* [khang06](https://github.com/khang06) For his awesome encoder, being the inspiration, and his help in understanding audio.
* [NotImplementedLife](https://github.com/NotImplementedLife) For their FlipnoteDesktop program, which helped a lot in understanding the structure of a Flipnote.
* guys from [DSiBrew](https://dsibrew.org/wiki/Main_Page) and [Flipnote Collective](https://github.com/Flipnote-Collective) for their awesome documentation on .PPM file format.

# Note
Flipnote Studio is a trademark of Nintendo. This project is not linked to them in any way. It is intended for educational purposes only.

This is a program, not responsible for any use that does not follow Sudomemo's TOS, I do not take responsibility for misuse of the tool. Reminder of Section 4.1.1 from Sudomemo Terms of Use: The following activities are prohibited when using Sudomemo: Exploits or content that wasn’t created in the original Flipnote Studio software on a Nintendo DSi or Nintendo 3DS. Plus, animating on a DS is much more fun :) . That's all

[![forthebadge](https://forthebadge.com/images/badges/mom-made-pizza-rolls.svg)](https://forthebadge.com)

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/K3K61YCS7)
