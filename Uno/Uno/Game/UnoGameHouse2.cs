﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Uno.EventsComponents;

namespace Uno.Game
{
    [Serializable]
    class UnoGameHouse2: UnoGame
    {
        public UnoGameHouse2(List<string> pPlayerNames, int pdealer) : base(pPlayerNames, pdealer)
        {

        }

        protected override void UnoGame_RaiseUnsubscribeEvents(object sender, EventArgs eventArgs)
        {
            base.UnsubscribeFromEvents();
        }

        public override void SubscribeToEvents()
        {
            base.SubscribeToEvents();
        }

        protected override void UnsubscribeFromEvents()
        {
            base.UnsubscribeFromEvents();
        }

        protected override void CalculateFinalScores()
        {
            base.CalculateFinalScores();
        }

        protected override void UnoGame_RaiseGameButtonClick(object sender, EventArgs eventArgs)
        {
            EventArgsGameButtonClick ev = eventArgs as EventArgsGameButtonClick;
            Card card = ev.mPlayingCard;
            bool cardPlayable = CheckIfCardCanBePlayed(card);
            if (mPlayerHasPicked)
            {
                cardPlayable = CheckIfDrawnCard(card);
            }
            if (!cardPlayable) MessageBox.Show("Sorry but this card can not be played", "Card not playable");
            else
            {
                EventPublisher.PlayCard(card);
            }
        }

        protected override bool CheckIfDrawnCard(Card pCard)
        {
            return base.CheckIfDrawnCard(pCard);
        }

        protected override void UnoGame_RaisePlayCard(object sender, EventArgsPlayCard eventArgs)
        {
            base.UnoGame_RaisePlayCard(sender, eventArgs);
        }

        protected override void UnoGame_RaiseNextPlayerButtonClick(object sender, EventArgs eventArgs)
        {
            if (mPlayerHasDiscarded)
            {
                int nextPlayerWithoutSips = NextPlayerWithoutSkips();
                if (mforwards)
                {
                    nextPlayerWithoutSips += mNextPlayersToSkipTotal;
                }
                else
                {
                    nextPlayerWithoutSips -= mNextPlayersToSkipTotal;
                }
                mCurrentPlayer = FixOutOfBounds(nextPlayerWithoutSips);
                for (int cardsToDraw = 0; cardsToDraw < mNextPlayerPickupTotal; cardsToDraw++)
                {
                    DrawCard(mCurrentPlayer);
                }
                mNextPlayerPickupTotal = 0;
                mNextPlayersToSkipTotal = 0;
                mPlayerHasPicked = false;
                mPlayerHasDiscarded = false;
                mCardsDrawnThisTurn.Clear();
                mPlayers[mCurrentPlayer].SortPlayerCards();
                EventPublisher.GuiUpdate(mPlayers[mCurrentPlayer], mDeck, null);
            }
        }

        protected override void UnoGame_RaiseSkipGo(object sender, EventArgs eventArgs)
        {
            base.UnoGame_RaiseSkipGo(sender, eventArgs);
        }

        protected override void UnoGame_RaiseReverseDirection(object sender, EventArgs eventArgs)
        {
            base.UnoGame_RaiseReverseDirection(sender, eventArgs);
        }

        protected override void UnoGame_RaiseDrawTwoCards(object sender, EventArgs eventArgs)
        {
            base.UnoGame_RaiseDrawTwoCards(sender, eventArgs);
        }

        protected override void UnoGame_RaiseColourPick(object sender, EventArgsColourPick argsColourPick)
        {
            if (mDeck.DiscardPile[mDeck.DiscardPile.Count - 1] is CardWild)
            {
                CardWild cardWild = mDeck.DiscardPile[mDeck.DiscardPile.Count - 1] as CardWild;
                cardWild.NextSuit = argsColourPick.NextSuit;
                FinishPlaceCard();
                if (cardWild.CardsToDraw > 0)
                {
                    for (int numToDraw = 0; numToDraw < 4; numToDraw++)
                    {
                        DrawCard(NextPlayerWithoutSkips());
                    }
                }

            }
        }

        protected override void DealCards()
        {
            base.DealCards();
        }

        protected override void FinishPlaceCard()
        {
            base.FinishPlaceCard();
        }

        protected override int NextPlayerWithoutSkips()
        {
            return base.NextPlayerWithoutSkips();
        }

        protected override int FixOutOfBounds(int pIndex)
        {
            return base.FixOutOfBounds(pIndex);
        }

        protected override void UnoGame_DrawCard(object sender, EventArgs eventArgs)
        {
            base.UnoGame_DrawCard(sender, eventArgs);
        }

        protected override void DrawCard(int pPlayer)
        {
            base.DrawCard(pPlayer);
        }

        protected override void MoveCardFromDiscardToPlayer(int pPlayer)
        {
            base.MoveCardFromDiscardToPlayer(pPlayer);
        }

        protected override void MoveCardFromDrawToPlayer(int pPlayer)
        {
            base.MoveCardFromDrawToPlayer(pPlayer);
        }

        protected override void UnoMain_RaiseReturnToGame(object sender, EventArgs eventArgs)
        {
            base.UnoMain_RaiseReturnToGame(sender, eventArgs);
        }

        protected override List<Player> GenerateNewPlayers(List<string> pPlayerNames)
        {
            return base.GenerateNewPlayers(pPlayerNames);
        }

        protected override bool CheckIfCardCanBePlayed(Card pCard)
        {
            return base.CheckIfCardCanBePlayed(pCard);
        }
    }
}
