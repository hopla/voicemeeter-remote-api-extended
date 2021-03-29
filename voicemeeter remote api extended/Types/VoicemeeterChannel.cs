﻿namespace AtgDev.Voicemeeter.Types
{
    /// <summary>
    ///     Strip (Hardware Inputs) and Out (Hardware Outputs) constants' names are universal.
    ///     <para>Index numbers of names:</para>
    ///     L - 0<br/>
    ///     R - 1<br/>
    ///     C - 2<br/>
    ///     LFE - 3<br/>
    ///     SL - 4<br/>
    ///     SR - 5<br/>
    ///     BL - 6<br/>
    ///     BR - 7<br/>
    /// </summary>
    enum VoicemeeterChannel
    {
        // Voicemeeter
        Strip1L = 0,
        Strip1R,

        Strip2L,
        Strip2R,
        // VIRTUAL INPUTS
        StandardVirtInL,
        StandardVirtInR,
        StandardVirtInC,
        StandardVirtInLFE,
        StandardVirtInSL,
        StandardVirtInSR,
        StandardVirtInBL,
        StandardVirtInBR,
        StandardVirtInFirst = StandardVirtInL,
        StandardVirtInLast = StandardVirtInBR,
        // HARDWARE OUTPUTS
        OutA1L = 0,
        OutA1R,
        OutA1C,
        OutA1LFE,
        OutA1SL,
        OutA1SR,
        OutA1BL,
        OutA1BR,
        OutA1First = OutA1L,
        OutA1Last = OutA1BR,
        // VIRTUAL OUTPUTS
        StandardVirtOutL,
        StandardVirtOutR,
        StandardVirtOutC,
        StandardVirtOutLFE,
        StandardVirtOutSL,
        StandardVirtOutSR,
        StandardVirtOutBL,
        StandardVirtOutBR,
        StandardVirtOutFirst = StandardVirtOutL,
        StandardVirtOutLast = StandardVirtOutBR,

        // Banana
        Strip3L = 4,
        Strip3R,
        // VIRTUAL INPUTS
        BananaVirt1InL,
        BananaVirt1InR,
        BananaVirt1InC,
        BananaVirt1InLFE,
        BananaVirt1InSL,
        BananaVirt1InSR,
        BananaVirt1InBL,
        BananaVirt1InBR,
        BananaVirt1InFirst = BananaVirt1InL,
        BananaVirt1InLast = BananaVirt1InBR,

        BananaVirt2InL,
        BananaVirt2InR,
        BananaVirt2InC,
        BananaVirt2InLFE,
        BananaVirt2InSL,
        BananaVirt2InSR,
        BananaVirt2InBL,
        BananaVirt2InBR,
        BananaVirt2InFirst = BananaVirt2InL,
        BananaVirt2InLast = BananaVirt2InBR,
        // HARDWARE OUTPUTS
        OutA2L = 8,
        OutA2R,
        OutA2C,
        OutA2LFE,
        OutA2SL,
        OutA2SR,
        OutA2BL,
        OutA2BR,
        OutA2First = OutA2L,
        OutA2Last = OutA2BR,

        OutA3L,
        OutA3R,
        OutA3C,
        OutA3LFE,
        OutA3SL,
        OutA3SR,
        OutA3BL,
        OutA3BR,
        OutA3First = OutA3L,
        OutA3Last = OutA3BR,
        // VIRTUAL OUTPUTS
        BananaVirtOutB1L,
        BananaVirtOutB1R,
        BananaVirtOutB1C,
        BananaVirtOutB1LFE,
        BananaVirtOutB1SL,
        BananaVirtOutB1SR,
        BananaVirtOutB1BL,
        BananaVirtOutB1BR,
        BananaVirtOutB1First = BananaVirtOutB1L,
        BananaVirtOutB1Last = BananaVirtOutB1BR,

        BananaVirtOutB2L,
        BananaVirtOutB2R,
        BananaVirtOutB2C,
        BananaVirtOutB2LFE,
        BananaVirtOutB2SL,
        BananaVirtOutB2SR,
        BananaVirtOutB2BL,
        BananaVirtOutB2BR,
        BananaVirtOutB2First = BananaVirtOutB2L,
        BananaVirtOutB2Last = BananaVirtOutB2BR,
        // Potato
        Strip4L = 6,
        Strip4R,

        Strip5L,
        Strip5R,
        // VIRTUAL INPUTS
        PotatoVirt1InL,
        PotatoVirt1InR,
        PotatoVirt1InC,
        PotatoVirt1InLFE,
        PotatoVirt1InSL,
        PotatoVirt1InSR,
        PotatoVirt1InBL,
        PotatoVirt1InBR,
        PotatoVirt1InFirst = PotatoVirt1InL,
        PotatoVirt1InLast = PotatoVirt1InBR,

        PotatoVirt2InL,
        PotatoVirt2InR,
        PotatoVirt2InC,
        PotatoVirt2InLFE,
        PotatoVirt2InSL,
        PotatoVirt2InSR,
        PotatoVirt2InBL,
        PotatoVirt2InBR,
        PotatoVirt2InFirst = PotatoVirt2InL,
        PotatoVirt2InLast = PotatoVirt2InBR,

        PotatoVirt3InL,
        PotatoVirt3InR,
        PotatoVirt3InC,
        PotatoVirt3InLFE,
        PotatoVirt3InSL,
        PotatoVirt3InSR,
        PotatoVirt3InBL,
        PotatoVirt3InBR,
        PotatoVirt3InFirst = PotatoVirt3InL,
        PotatoVirt3InLast = PotatoVirt3InBR,
        // HARDWARE OUTPUTS
        OutA4L = 24,
        OutA4R,
        OutA4C,
        OutA4LFE,
        OutA4SL,
        OutA4SR,
        OutA4BL,
        OutA4BR,
        OutA4First = OutA4L,
        OutA4Last = OutA4BR,

        OutA5L,
        OutA5R,
        OutA5C,
        OutA5LFE,
        OutA5SL,
        OutA5SR,
        OutA5BL,
        OutA5BR,
        OutA5First = OutA5L,
        OutA5Last = OutA5BR,
        // VIRTUAL OUTPUTS
        PotatoVirtOutB1L,
        PotatoVirtOutB1R,
        PotatoVirtOutB1C,
        PotatoVirtOutB1LFE,
        PotatoVirtOutB1SL,
        PotatoVirtOutB1SR,
        PotatoVirtOutB1BL,
        PotatoVirtOutB1BR,
        PotatoVirtOutB1First = PotatoVirtOutB1L,
        PotatoVirtOutB1Last = PotatoVirtOutB1BR,

        PotatoVirtOutB2L,
        PotatoVirtOutB2R,
        PotatoVirtOutB2C,
        PotatoVirtOutB2LFE,
        PotatoVirtOutB2SL,
        PotatoVirtOutB2SR,
        PotatoVirtOutB2BL,
        PotatoVirtOutB2BR,
        PotatoVirtOutB2First = PotatoVirtOutB2L,
        PotatoVirtOutB2Last = PotatoVirtOutB2BR,

        PotatoVirtOutB3L,
        PotatoVirtOutB3R,
        PotatoVirtOutB3C,
        PotatoVirtOutB3LFE,
        PotatoVirtOutB3SL,
        PotatoVirtOutB3SR,
        PotatoVirtOutB3BL,
        PotatoVirtOutB3BR,
        PotatoVirtOutB3First = PotatoVirtOutB3L,
        PotatoVirtOutB3Last = PotatoVirtOutB3BR
    }
}