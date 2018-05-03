using Assets.Scripts.Data.Entities.Party;
using Assets.Scripts.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Loaders.Players;

namespace Loaders.Party
{
    public class PartyLoader : MonoBehaviour
    {
        private static Party party;

        /**
         * Load the players current party into the game
         */
        public static Party LoadParty()
        {
            List<PartyReference> reference = PartyRepository.LoadParty();
            try
            {
                if (party != null)
                {
                    return party;
                }
                else
                {
                    party = new Party();

                    List<PartyReference> pr = PartyRepository.LoadParty();
                    pr.ForEach(partyReference =>
                    {
                        Player player = PlayerLoader.LoadPlayer(partyReference.Code);
                        player.isCurrentPlayer = partyReference.IsCurrentPlayer;
                        player.startX = partyReference.X;
                        player.startY = partyReference.Y;
                        party.CharacterConfiguration[partyReference.Position] = player;
                        if (partyReference.IsCurrentPlayer)
                        {
                            party.CurrentPlayer = player;
                        }
                    });
                }
            }
            catch (MissingReferenceException e)
            {
                party = null;
                LoadParty();
                //TEMP
                print(e.Message);
            }
            return party;
        }
    }
}
