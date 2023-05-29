using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Publicjoe.Windows;
using Publicjoe.Windows.Cards;

namespace HiLow
{
  public partial class Form1 : Form
  {
    private Card cardDrawing;
    private �pil TheDeck;
    private int currentCard = 0;
    private bool winLose = true;

    public Form1()
    {
      InitializeComponent();

      cardDrawing = new Card();
      cardDrawing.Begin(this.CreateGraphics());

      TheDeck = new �pil();
      TheDeck.Izmje�aj();

    }


        private void pravilaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ra�unar iz �pila od 52 karte nasumi�no izvla�i �etiri karte. Inicijalno, igra�u je prikazana samo prva karta dok su ostale tri pokrivene.. " +
                          "Igra�, zatim, bira jednu od ponu�enih opcija.");

            MessageBox.Show("Za drugu kartu, tj Ve�a, Manja ili Ista u odnosu na prvu kartu. " +
                 "Ukoliko, igra� uspije�no pogodi vrijednost druge karte u odnosu na prvu kartu, druga karta se prikazuje, a igra� ponovo ima izbor vrijednosti tre�e karte u odnosu na drugu." +
                 " Igra se zavr�ava pobjedom igra�a, sa odgovaraju�om porukom, ukoliko se sve �etiri karte uspije�no otkriju. ");
        }
    

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    

    protected override void OnPaint(PaintEventArgs e)
    { 
      for (int i = 0; i <= currentCard; i++)
      {
        cardDrawing.DrawCard(new Point((10 + (i * 80)), 34), TheDeck.DajKartu(i));
      }

      for (int i = currentCard + 1; i < 5; i++)
      {
        cardDrawing.DrawCardBack(new Point((10 + (i * 80)), 34));
      }

      if (winLose == false)
      {
        buttonPlay.Visible = true;
      }
      else if (currentCard == 4)
      {
        buttonPlay.Visible = true;
        
 
        }  
       
      base.OnPaint(e);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void dugme_Ve�a(object sender, EventArgs e)
    {
      if (winLose == true)
      {
        int prev = TheDeck.DajKartu(currentCard);

        currentCard++;
        int cur = TheDeck.DajKartu(currentCard);

        int curRank = (int)cardDrawing.RankFromCardIndex(cur);
        int prevRank = (int)cardDrawing.RankFromCardIndex(prev);

        if (curRank < prevRank)
        {
          winLose = false;
          MessageBox.Show("Izgubio si!");
        }

        if (currentCard == 4)
        {
          MessageBox.Show("Pobjeda je tvoja!");
        }

        Invalidate();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void dugme_Manja(object sender, EventArgs e)
        {
            if (winLose == true)
      {
        int prev = TheDeck.DajKartu(currentCard);
        currentCard++;
        int cur = TheDeck.DajKartu(currentCard);

        int curRank = (int)cardDrawing.RankFromCardIndex(cur);
        int prevRank = (int)cardDrawing.RankFromCardIndex(prev);

        if (curRank > prevRank)
        {
          winLose = false;
          MessageBox.Show("Izgubio si!");
        }

        if (currentCard == 4)
        {
          MessageBox.Show("Pobjeda je tvoja!");
        }

        Invalidate();
      }
    }

    private void dugme_Nova_Igra(object sender, EventArgs e)
    {
      
      
      currentCard = 0;
      winLose = true;

      TheDeck.Izmje�aj();
      buttonPlay.Visible = true;

    
    }

        private void dugme_Ista(object sender, EventArgs e)
        {
            if (winLose == true)
            {
                int prev = TheDeck.DajKartu(currentCard);

                currentCard++;
                int cur = TheDeck.DajKartu(currentCard);

                int curRank = (int)cardDrawing.RankFromCardIndex(cur);
                int prevRank = (int)cardDrawing.RankFromCardIndex(prev);

                if (curRank != prevRank)
                {
                    winLose = true;
                    MessageBox.Show("Izgubio si");
                }

                if (currentCard == 4)
                {
                    MessageBox.Show("Pobjeda je tvoja");
                }

                Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Za sva pitanja obratite se na moj mail @musazahirovic11@gmail.com");
        }

        private void radioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikaciju pravio Mustafa Zahirovi�");
        }

        private void oMeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }
