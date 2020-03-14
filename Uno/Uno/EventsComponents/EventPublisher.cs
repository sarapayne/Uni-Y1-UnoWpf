﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Uno.EventsComponents;

namespace Uno
{
    static class EventPublisher
    {
        public static event EventHandler <EventArgsGameButtonClick> RaiseGameButtonClick; 
        public static event EventHandler <EventArgsColourPick> RaiseColourPick;
        public static event EventHandler <EventArgsPlayCard> RaisePlayCard;
        public static event EventHandler <EventArgsGuiUpdate> RaiseGuiUpdate;
        public static event EventHandler <EventArgsFinalScore> RaiseFinalScore;
        public static event EventHandler <EventArgsAddToTournament> RaiseAddToTournament;
        public static event EventHandler<EventArgsLoadSave> RaiseLoadTournament;
        public static event EventHandler<EventArgsLoadSave> RaiseSaveTournament;
        public static event EventHandler<EventArgsLoadSave> RaiseLoadGame;
        public static event EventHandler<EventArgsLoadSave> RaiseSaveGame;
        public static event EventHandler RaiseNextPlayerButtonClick;
        public static event EventHandler RaisePlus4Challenge;
        public static event EventHandler RaiseDrawTwoCards;
        public static event EventHandler RaiseSkipGo;
        public static event EventHandler RaiseReverseDirection;
        public static event EventHandler RaiseAcceptDraw4;
        public static event EventHandler RaiseDrawCard;
        public static event EventHandler RaiseMainMenu;
        public static event EventHandler RaiseReturnToGame;
        public static event EventHandler RaiseUnsubscribeEvents;
        public static event EventHandler <EventArgsGame> RaiseNewGame;
        public static event EventHandler RaiseCheckForActiveGame;
        public static event EventHandler RaiseNewTournament;
        public static event EventHandler RaiseUnsubscribeTournamentEvents;
        public static event EventHandler RaiseShutDownRoutine;
        public static event EventHandler RaiseCloseWindow;

        public static void CloseWindow()
        {
            if (RaiseCloseWindow != null)
            {
                EventPublisher.RaiseCloseWindow(null, null);
            }
        }

        public static void ShutDownRoutine()
        {
            if (RaiseShutDownRoutine != null)
            {
                EventPublisher.RaiseShutDownRoutine(null, null);
            }
        }

        public static void UnsubscribeTournamentEvents()
        {
            if (RaiseUnsubscribeTournamentEvents != null)
            {
                EventPublisher.RaiseUnsubscribeTournamentEvents(null, null);
            }
        }

        public static void NewTournament()
        {
            if (RaiseNewTournament != null)
            {
                EventPublisher.RaiseNewTournament(null, null);
            }
        }

        public static void SaveTournament(string pName, string pExtraInfo)
        {
            if (RaiseSaveTournament != null)
            {
                EventPublisher.RaiseSaveTournament(null, new EventArgsLoadSave(pName, pExtraInfo));
            }
        }

        public static void LoadTournament(string pName, string pExtraInfo)
        {
            if (RaiseLoadTournament != null)
            {
                EventPublisher.RaiseLoadTournament(null, new EventArgsLoadSave(pName, pExtraInfo));
            }
        }
            
        
        public static void CheckForActiveGame()
        {
            if (RaiseCheckForActiveGame != null)
            {
                EventPublisher.RaiseCheckForActiveGame(null, null);
            }
        }

        public static void SaveGame(string pName, string pExtraInfo)
        {
            if(RaiseSaveGame != null)
            {
                EventPublisher.RaiseSaveGame(null, new EventArgsLoadSave(pName, pExtraInfo));
            }
        }

        public static void LoadGame(string pName, string pExtraInfo)
        {
            if (RaiseLoadGame != null)
            {
                EventPublisher.RaiseLoadGame(null, new EventArgsLoadSave(pName, pExtraInfo));
            }
        }

        public static void NewGame(List<string> pPlayers, int pDealer, RulesType pRulesType)
        {
            if (RaiseNewGame != null)
            {
                EventPublisher.RaiseNewGame(null, new EventArgsGame(pPlayers, pDealer, pRulesType));
            }
        }

        public static void UnsubscribeEvents()
        {
            if (RaiseUnsubscribeEvents != null)
            {
                EventPublisher.RaiseUnsubscribeEvents(null, null);
            }
        }

        public static void AddToTournament(Player pPlayer)
        {
            if (RaiseAddToTournament != null)
            {
                EventPublisher.RaiseAddToTournament(null, new EventArgsAddToTournament(pPlayer));
            }
        }


        public static void ReturnToGame()
        {
            if (RaiseReturnToGame != null)
            {
                EventPublisher.RaiseReturnToGame(null, null);
            }
        }

        public static void MainMenu()
        {
            if (RaiseMainMenu != null)
            {
                EventPublisher.RaiseMainMenu(null, null);
            }
        }

        public static void FinalScore(Player pPlayer)
        {
            if (RaiseFinalScore != null)
            {
                EventPublisher.RaiseFinalScore(null, new EventArgsFinalScore(pPlayer));
            }
        }

        public static void DrawCard()
        {
            if (RaiseDrawCard != null)
            {
                EventPublisher.RaiseDrawCard(null, null);
            }
        }

        public static void AcceptDraw4()
        {
            if (RaiseAcceptDraw4 != null )
            {
                EventPublisher.RaiseAcceptDraw4(null, null);
            }
        }

        public static void GuiUpdate(Player pPlayer, Deck pDeck, string pExtras)
        {
            if (RaiseGuiUpdate != null)
            {
                EventPublisher.RaiseGuiUpdate(null, new EventArgsGuiUpdate(pPlayer, pDeck, pExtras));
            }
        }

        public static void PlayCard(Card pcard)
        {
            if (RaisePlayCard != null)
            {
                EventPublisher.RaisePlayCard(null, new EventArgsPlayCard(pcard));
            }
        }

        public static void GameButtonClick(Card pCard)
        {
            if (RaiseGameButtonClick != null)
            {
                EventPublisher.RaiseGameButtonClick(null, new EventArgsGameButtonClick(pCard));
            }
        }

        public static void ReverseDirection()
        {
            if (RaiseReverseDirection != null)
            {
                EventPublisher.RaiseReverseDirection(null, null);
            }
        }

        public static void SkipGo()
        {
            if (RaiseSkipGo != null)
            {
                EventPublisher.RaiseSkipGo(null, null);
            }
        }

        public static void DrawTwoCards()
        {
            if (RaiseDrawTwoCards != null)
            {
                EventPublisher.RaiseDrawTwoCards(null, null);
            }
        }

        public static void Plus4Challenge()
        {
            if (RaisePlus4Challenge != null)
            {
                EventPublisher.RaisePlus4Challenge(null, null);
            }
        }

        public static void ColourPick(Suit pSuit)
        {
            if (RaiseColourPick != null)
            {
                EventPublisher.RaiseColourPick(null, new EventArgsColourPick(pSuit));
            }
        }      

        public static void NextPlayerButtonClick()
        {
            if (RaiseNextPlayerButtonClick != null)
            {
                EventPublisher.RaiseNextPlayerButtonClick(null, null);
            }
                
        }
    }
}
