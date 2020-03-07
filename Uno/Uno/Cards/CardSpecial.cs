﻿using System;
using Image = System.Windows.Controls.Image;

namespace Uno
{
    [Serializable()]
    enum SpecialType
    {
        Reverse, Skip, Draw
    }

    [Serializable()]
    class CardSpecial: CardSuit
    {
        private SpecialType mSpecialType;

        public CardSpecial(string pImageName, Suit pSuit, SpecialType pSecialType): base (pImageName, pSuit)
        {
            this.mSpecialType = pSecialType;
        }

        public SpecialType Type
        {
            get { return this.mSpecialType; }
        }
    }
}
