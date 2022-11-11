/* *********************************************************************** 
 * Project:     War Card Game
 * File:        BL_PlayingCard
 * Language:    C# 
 * 
 * Description: This program will play the game war   
 *             
 * College: Husson Unvirsity 
 * Course: IT 325 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.1   BL  11-6-22      Inital writing 
 *                        
 * 
 * ***********************************************************************/
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace War_Card_Game
{
    internal class BL_PlayingCard
    {
        #region enum  
        public enum SuitName : int
        {
            Diamond,
            Heart,
            Club,
            Spade,

        }

        public enum FaceName : int
        { 
            // ace being higher now
                      
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace,

        } 
        

        #endregion enum  

        #region data 
        #endregion data 

        #region properties  
        public FaceName Face { get; private set; } // the face of the card 
        public SuitName Suit { get; private set; } // the suit of the card  
        public int Rank { get; private set; } // the rank of the card 
        public BL_PlayingCard Next { get; set; } // pointer to the next card on the stack
        #endregion properties  

        #region constructor  
        private BL_PlayingCard(FaceName face, SuitName suit, int rank)
        {
            Face = face;
            Suit = suit;
            Rank = rank;





        }
        #endregion constructor

        #region methods  
        public static BL_Stack PopulateFullDeck()
        {
            BL_Stack fullDeck = new BL_Stack();
            BL_Stack userHand = new BL_Stack();
            BL_Stack cpuHand = new BL_Stack();
            
             
            //Loop through the suits 
            for (SuitName suit = SuitName.Diamond; suit <= SuitName.Spade; suit++)
            {
                        // loop thourgh the face values 
               for (FaceName face = FaceName.Two; face <= FaceName.Ace; face++)
               {
                     //userHand.Push(new BL_PlayingCard(face, suit, (int)face));
                     //cpuHand.Push(new BL_PlayingCard(face, suit, (int)face));
                     // push a new card with face, suit, and rack on the stack
                     //MessageBox.Show(new BL_PlayingCard(face, suit, (int)face).ToString()); 
                     fullDeck.Push(new BL_PlayingCard(face, suit, (int)face));


               }
            } 
            return fullDeck;

        }
        public static BL_Stack InitializeDeckUser()
        {

            BL_Stack fullHandUser = new BL_Stack();
            
            //Loop through the suits 
            for (SuitName suit = SuitName.Diamond; suit <= SuitName.Spade; suit++)
            {
                // loop thourgh the face values 
                for (FaceName face = FaceName.Two; face <= FaceName.Ace; face++)
                {
                    // push a new card with face, suit, and rack on the stack
                    //MessageBox.Show(new BL_PlayingCard(face, suit, (int)face).ToString()); 
                    fullHandUser.Push(new BL_PlayingCard(face, suit, (int)face));


                }
            }
            
            return fullHandUser;
              
        }
        public static BL_Stack InitializeDeckComp()
        {
            BL_Stack fullHandComp = new BL_Stack();

            for (SuitName suit = SuitName.Diamond; suit <= SuitName.Spade; suit++)
            {
                // loop thourgh the face values 
                for (FaceName face = FaceName.Two; face <= FaceName.Ace; face++)
                {
                    // push a new card with face, suit, and rack on the stack
                    //MessageBox.Show(new BL_PlayingCard(face, suit, (int)face).ToString()); 
                    fullHandComp.Push(new BL_PlayingCard(face, suit, (int)face));


                }
            }
            return fullHandComp;
        }

        /// <summary>
        /// Return the playing card in the format "<face> of <Suit>"
        /// ex:  Seven of Diamonds 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return String.Format("{0} of {1}", this.Face, this.Suit);
        }


        #endregion methods
    }
}
