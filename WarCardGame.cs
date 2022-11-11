using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace War_Card_Game
{
    public partial class WarCardGame : Form
    {

        BL_Stack discardPilePlayer,    
            discardPileComp,
            warPilePlayer,
            warPileComp,
            wonPilePlayer,
            wonPileComp;

       

        public WarCardGame()
        {
            InitializeComponent();
        }

        private void WarCardGame_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This routine will display the passed stack in the passed listbox
        /// </summary>
        /// <param name="theStack"></param>
        /// <param name="theListBox"></param>
        private void DisplayStack(BL_Stack theStack, ListBox theListBox)
        {
            // clear the listbox 
            theListBox.Items.Clear();

            //Display all the cards on the stack in the listbox 
            foreach (BL_PlayingCard oneCard in theStack)
            {
                theListBox.Items.Add(oneCard.ToString());
            }

            // display the count of cards in the stack 
            theListBox.Items.Add(String.Empty);
            theListBox.Items.Add(String.Format("Count = {0}", theStack.Count));

        }

        public void DisplayAllStacks()
        {
            DisplayStack(discardPilePlayer, listBoxPlayerDiscard);
            DisplayStack(discardPileComp, listBoxCompDiscard);
            DisplayStack(warPilePlayer, listBoxPlayerWar);
            DisplayStack(warPileComp, listBoxCompWar);
            DisplayStack(wonPilePlayer, listBoxPlayerWon);
            DisplayStack(wonPileComp, listBoxCompWon);
        }

       

        private void buttonNewGame_Click(object sender, EventArgs e)
        { 
            int splitDeck = 26;
            // the hand that contains all the cards
            discardPilePlayer = BL_PlayingCard.InitializeDeckUser();
            discardPilePlayer = BL_Stack.Shuffle(discardPilePlayer);
            //discardPileComp = BL_PlayingCard.InitializeDeckComp();
            //discardPileComp = BL_Stack.Shuffle(discardPileComp);
           
            // all the other stacks are empty 
            warPilePlayer = new BL_Stack();
            warPileComp = new BL_Stack();
            wonPilePlayer = new BL_Stack();
            wonPileComp = new BL_Stack(); 
            discardPileComp = new BL_Stack(); 

            while (discardPileComp.Count < splitDeck)
            {
                discardPileComp.Push(discardPilePlayer.Pop());
            }


                // Display all the stacks 
                DisplayStack(discardPilePlayer, listBoxPlayerDiscard);
                DisplayStack(discardPileComp, listBoxCompDiscard);
                DisplayStack(warPilePlayer, listBoxPlayerWar);
                DisplayStack(warPileComp, listBoxCompWar);
                DisplayStack(wonPilePlayer, listBoxPlayerWon);
                DisplayStack(wonPileComp, listBoxCompWon);

        }
        private void buttonPlayTurn_Click(object sender, EventArgs e)
        {
            //int desiredCount = 0;
           


            
            
          
            
            warPilePlayer.Push(discardPilePlayer.Pop());
            warPileComp.Push(discardPileComp.Pop());
            DisplayAllStacks(); 
                
            if (discardPilePlayer != null && discardPileComp != null)
            {
                // tie
                if (warPilePlayer.Peep().Rank == warPileComp.Peep().Rank)
                {
                    DisplayAllStacks();
                    MessageBox.Show("You tied this round");

                    warPilePlayer.Push(discardPilePlayer.Pop());
                    warPilePlayer.Push(discardPilePlayer.Pop());
                    warPilePlayer.Push(discardPilePlayer.Pop());

                    warPileComp.Push(discardPileComp.Pop());
                    warPileComp.Push(discardPileComp.Pop());
                    warPileComp.Push(discardPileComp.Pop());

                }
                // player win
                else if (warPilePlayer.Peep().Rank > warPileComp.Peep().Rank)
                {
                    DisplayAllStacks();
                    MessageBox.Show("You won this round");
                    if (warPileComp.Count > 0)
                    { 
                        while (warPileComp.Count > 0)
                        {
                            warPilePlayer.Push(warPileComp.Pop());
                        }
                            
                    }


                    if (warPilePlayer.Count > 0)
                    { 
                        while (warPilePlayer.Count > 0)
                        {
                            wonPilePlayer.Push(warPilePlayer.Pop());
                        }
                            
                    }


                    DisplayAllStacks();


                }
                // Comp won 
                else if (warPilePlayer.Peep().Rank < warPileComp.Peep().Rank)
                {
                    DisplayAllStacks();
                    MessageBox.Show("Comp won this round");
                    if (warPilePlayer.Count > 0)
                    { 
                        while (warPilePlayer.Count > 0)
                        {
                            warPileComp.Push(warPilePlayer.Pop());
                        }
                            
                    }



                    if (warPileComp.Count > 0)
                    { 
                        while (warPileComp.Count > 0)
                        {
                            wonPileComp.Push(warPileComp.Pop());
                        }
                            
                    }

                    DisplayAllStacks();


                }
            }

            // nobody won and shuffle then put back in
            if (discardPilePlayer.Count == 0)
            {
                while (wonPilePlayer.Count > 0)
                {
                    wonPilePlayer = BL_Stack.Shuffle(wonPilePlayer);
                    discardPilePlayer.Push(wonPilePlayer.Pop());
                }
                if (discardPileComp.Count == 0)
                {
                    while (wonPileComp.Count > 0)
                    {
                        wonPileComp = BL_Stack.Shuffle(wonPileComp);
                        discardPileComp.Push(wonPileComp.Pop());
                    }
                }
                //player won
                if (wonPilePlayer.Count == 0 && discardPilePlayer.Count == 0)
                {
                    MessageBox.Show("You won");
                }
                // comp won
                else if (wonPilePlayer.Count == 0 && discardPileComp.Count == 0)
                {
                    MessageBox.Show("You lost");
                }
            }
            
            






            

            












        }
    }
}
