/* *********************************************************************** 
 * Project:     War Card Game 
 * File:        BL_Stack
 * Language:    C# 
 * 
 * Description: This program will play war  
 *             
 * College: Husson Unvirsity 
 * Course: IT 325 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.1   BL   11-6-22     Inital writing 
 *                         
 * 
 * ***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Card_Game
{
    internal class BL_Stack : IEnumerable<BL_PlayingCard>
    {
        #region data 
        #endregion data 

        #region properties  
        public int Count { get; private set; } // number of cards in the current stacks 
        private BL_PlayingCard Top { get; set; }   // top of the stack 

        #endregion properties  

        #region constructor  
        /// <summary>
        /// This constructor creats an empty stack of cards
        /// </summary>
        public BL_Stack()
        {
            Top = null;
            Count = 0;

        }

        /// <summary>
        /// Take a array of playing cards and place them in a stack
        /// </summary>
        /// <param name="oringalPile"></param>
        public BL_Stack(BL_PlayingCard[]  oringalPile)
        {  

            Top = null;
            Count = 0;

            for (int index = 0; index < oringalPile.GetLength(0); index++)
            {
                oringalPile[index].Next = null;
                Push(oringalPile[index]);
            }
        }
        #endregion constructor

        #region methods  
        /// <summary>
        /// this method will clear the stack of all playing cards 
        /// </summary>
        public void Clear()
        {
            Top = null;
            Count = 0;
        }
        /// <summary>
        /// This method returns true if the stack is empty 
        /// </summary>
        /// <returns> True is stack is empty 
        /// False if the stack has at least 1 card</returns>
        public bool IsEmpty()
        {
            return (Count == 0);
        }

        /// <summary>
        /// This routine returns the top card in the stack without removing it.
        /// </summary>
        /// <returns>Top card on the stack if it exists otherwise returns null</returns>
        public BL_PlayingCard Peep()
        {
            if (IsEmpty())
            {
                return null;
            }
            else
            {
                return Top;
            }


        }

        /// <summary>
        /// This will remove the top playing card from stack and retunr it
        /// </summary>
        /// <returns>Top playing card if it exists otherwise returns null</returns>
        public BL_PlayingCard Pop()
        {
            BL_PlayingCard oneCard = null;

            if (!IsEmpty())
            {
                // remove the card 
                oneCard = Top;
                Top = Top.Next;
                // breaks all links to the top card 
                oneCard.Next = null;
                // decrment the count 
                Count--;

            }

            return oneCard;
        }

        /// <summary>
        /// This routine will place the new card at the top of the stack 
        /// </summary>
        /// <param name="oneCard"></param>
        public void Push(BL_PlayingCard oneCard)
        {
            // push the playing card onto the top of the stack 
            if (IsEmpty())
            {
                // stack is empty 
                Top = oneCard;
                oneCard.Next = null;

            }
            else
            {
                // place on top 
                oneCard.Next = Top;
                Top = oneCard;
            }
            // increment the count of cards 
            Count++;
        }
        /// <summary>
        /// This routine will shuffle a stack of cards
        /// </summary>
        /// <param name="oringalStack"></param>
        /// <returns></returns> 
        public static BL_Stack Shuffle(BL_Stack oringalStack)
        {
            // create a random number generator  
            Random rng = new Random();

            // convert the stack to an array 
            // assign a temp random number to each index in the array 
            // sort by that random number
            // use constructor to turn array back into a stack 
            BL_PlayingCard[] pile = oringalStack.OrderBy(randomizer => rng.Next()).ToArray();

            BL_Stack finalStack = new BL_Stack(pile);
            return finalStack;
        } 

        #endregion methods 

        #region enumerable  
        /// <summary>
        /// This method will walk down the link list one at a time 
        /// returning each item to the calling routine 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<BL_PlayingCard> GetEnumerator()
        {
            // Create a node to walk down the list 
            BL_PlayingCard current = Top;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion enumerable
    }
}
