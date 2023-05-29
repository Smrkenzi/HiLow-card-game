using System;

namespace Publicjoe.Windows.Cards
{
  public class Špil
  {
    private int[] CardArray = new int[52];

    /// <summary>
    /// Inicijalizacija špila od 52 karte sa nizom integer vrijednosti.
    /// </summary>
    public Špil()
    {
      // U špilu imamo 52 karte, koje su kodirane vrijednostima od 0 do 51
      for( int i = 0; i < 52; i++ )
      {
        CardArray[i] = i;
      }
    }

    /// <summary>
    /// Funkcija Izmješaj, mješa špil karata
    /// </summary>
    public void Izmješaj()
    {
      int[] newArray = new int[52];
      bool[] used = new bool[52];

      for( int j = 0; j < 52; j++ )
      {
        used[j] = false;
      }
    
      Random rnd = new Random();
      int iCount = 0;
      int iNum;

      while( iCount < 52 )
      {
        iNum = rnd.Next( 0, 52 ); // uzimamo nasumiènu vrijednost izmeðu 0-51
                                  // 52 predstavlja gornju granicu i nije ukljuèena
        if( used[iNum] == false )
        {
          newArray[iCount] = iNum;
          used[iNum] = true;
          iCount++;
        }
      }

      // Uèitaj izmiješan špil
      CardArray = newArray;
    }    
   
    /// <summary>
    /// Funkcija DajKartu izvlaèi jednu kartu iz špila
    /// </summary>
    public int DajKartu( int arrayNum )
    {
      if (arrayNum >= 0 && arrayNum <= 51)
        return CardArray[arrayNum];
      else
        throw (new System.ArgumentOutOfRangeException("arrayNum", arrayNum,
          "Value must be between 0 and 51."));
    }
  }
}
