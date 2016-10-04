using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //TODO: add an instance variable for the board object called board
    private Board board = new Board();

    //TODO: assumes that each square is an ImageButton with id of Image# (1 - 9)
    //if you use a label or a textbox you'll have to change the datatype here
    private ImageButton GetSquare(int row, int column)
    {
        int number = row * 3 + column + 1;
        return (ImageButton)this.FindControl("Image" + number.ToString());
    }

    //TODO: assumes that each square is an ImageButton with id of Image# (1 - 9)
    //if you use a label or a textbox you'll have to change the datatype here
    private void GetRowAndColumn(ImageButton i, out int row, out int column)
    {
        int position = int.Parse(i.ID.Substring(5));
        row = (position - 1) / 3;
        column = (position - 1) % 3;
    }

    private void HighlightColumn(int col)
    {
        for (int row = 0; row < 3; row++)
        {
            //TODO: change this
            ImageButton square = GetSquare(row, col);
            square.ImageUrl = "Images/Red" + board.GetSquare(row, col) + ".jpg";
        }
    }

    private void HighlightDiagonal1()
    {
        for (int row = 0; row < 3; row++)
        {
            //TODO: change this
            ImageButton square = GetSquare(row, row);
            square.ImageUrl = "Images/Red" + board.GetSquare(row, row) + ".jpg";
        }
    }

    private void HighlightDiagonal2()
    {
        for (int row = 0, col = 2; row < 3; row++, col--)
        {
            //TODO: change this
            ImageButton square = GetSquare(row, col);
            square.ImageUrl = "Images/Red" + board.GetSquare(row, col) + ".jpg";
        }
    }

    private void HighlightRow(int row)
    {
        for (int col = 0; col < 3; col++)
        {
            //TODO: change this
            ImageButton square = GetSquare(row, col);
            square.ImageUrl = "Images/Red" + board.GetSquare(row, col) + ".jpg";
        }
    }

    private void UpdateForm()
    {

        // it's not a winner
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                //TODO: change this
                ImageButton square = GetSquare(r, c);
                if (board.GetSquare(r, c) == Board.empty)
                    square.ImageUrl = "Images/blank.jpg";
                else if (board.GetSquare(r, c) == Board.computerSymbol)
                {
                    square.ImageUrl = "Images/" + Board.computerSymbol + ".jpg";
                }
                else
                    square.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
                    //square.ImageUrl = "Images/" + board.GetSquare(r, c) + ".jpg";

                //if (board.GetSquare(r, c) == Board.empty)
                //    square.Enabled = true;
                //else
                //    square.Enabled = false;
            }
        }
    }

    private void DisableForm()
    {
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                //TODO: change this
                ImageButton square = GetSquare(r, c);
                square.Enabled = false;
            }
        }
    }

    private bool HighlightWinner(string player)
    {
        // rows
        for (int row = 0; row < 3; row++)
        {
            //TODO: change this
            if (board.IsRowWinner(row))
            {
                HighlightRow(row);
                DisableForm();
                results.Text = (player + " wins!");
                return true;
            }
        }
        // columns
        for (int column = 0; column < 3; column++)
        {
            if (board.IsColumnWinner(column))
            {
                HighlightColumn(column);
                DisableForm();
                results.Text = (player + " wins!");
                return true;
            }
        }
        // diagonals
        for (int row = 0; row < 3; row++)
        {
            if (board.IsDiagonal1Winner())
            {
                HighlightDiagonal1();
                DisableForm();
                results.Text = (player + " wins!");
                return true;
            }
        }
        for (int row = 0, col = 2; row < 3; row++, col--)
        {
            if (board.IsDiagonal2Winner())
            {
                HighlightDiagonal2();
                DisableForm();
                results.Text = (player + " wins!");
                return true;
            }
        }
        // full

        //TODO: change this
        return false;

    }
    protected void Image1_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);

        board.SetSquare(row, column, Board.userSymbol);

        if (board.IsWinner() != true || board.IsFull() != true || board.IsTie() != true)
            UpdateForm();
        
    }
    protected void Image2_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);

        board.SetSquare(row, column, Board.userSymbol);
        UpdateForm();

    }
    protected void Image3_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);

        board.SetSquare(row, column, Board.userSymbol);
        UpdateForm();

    }
    protected void Image4_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);

        board.SetSquare(row, column, Board.userSymbol);
        UpdateForm();

    }
    protected void Image5_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);

        board.SetSquare(row, column, Board.userSymbol);
        UpdateForm();

    }
    protected void Image6_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);

        board.SetSquare(row, column, Board.userSymbol);
        UpdateForm();

    }
    protected void Image7_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);

        board.SetSquare(row, column, Board.userSymbol);
        UpdateForm();

    }
    protected void Image8_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);

        board.SetSquare(row, column, Board.userSymbol);
        UpdateForm();

    }
    protected void Image9_Click(object sender, ImageClickEventArgs e)
    {
        int row;
        int column;
        ImageButton square = (ImageButton)sender;

        GetRowAndColumn(square, out row, out column);        

        board.SetSquare(row, column, Board.userSymbol);
        UpdateForm();

    }  

    /*protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            board.MakeComputerMove();

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (board.GetSquare(row, col) == Board.computerSymbol)
                {
                    ImageButton img = GetSquare(row, col);
                    img.ImageUrl = "Images/" + Board.computerSymbol + ".jpg";
                }
                else if (board.GetSquare(row, col) == Board.userSymbol)
                {
                    ImageButton img = GetSquare(row, col);
                    img.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
                }
                else
                {
                    ImageButton img = GetSquare(row, col);
                    img.ImageUrl = "Images/blank.jpg";
                }                   
            }
        }
       
        if (board.IsAnyRowWinner() == true || board.IsAnyColumnWinner() == true || board.IsAnyDiagonalWinner() == true)
        {
            if (board.IsDiagonal1Winner())
            {
                HighlightDiagonal1();
            }
            else if (board.IsDiagonal2Winner())
            {
                HighlightDiagonal2();
            }
            else
            {
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (board.IsRowWinner(r) == true)
                            HighlightRow(r);
                        else if (board.IsColumnWinner(c) == true)
                            HighlightColumn(c);
                    }
                }
            }
        }
    }
    


    protected void Image1_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);                      
    }

    protected void Image2_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);
        if (board.GetSquare(row, column) == Board.userSymbol && board.GetSquare(row, column) != Board.computerSymbol)
        {
            my_imgbtn.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
        }
       
    }
    protected void Image3_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);
        if (board.GetSquare(row, column) == "X" || board.GetSquare(row, column) == "")
        {
            my_imgbtn.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
        }
       
    }
    protected void Image4_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);
        if (board.GetSquare(row, column) == "X" || board.GetSquare(row, column) == "")
        {
            my_imgbtn.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
        }
       
    }
    protected void Image5_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);
        if (board.GetSquare(row, column) == "X" || board.GetSquare(row, column) == "")
        {
            my_imgbtn.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
        }
       
    }
    protected void Image6_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);
        if (board.GetSquare(row, column) == "X" || board.GetSquare(row, column) == "")
        {
            my_imgbtn.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
        }
       
    }
    protected void Image7_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);
        if (board.GetSquare(row, column) == "X" || board.GetSquare(row, column) == "")
        {
            my_imgbtn.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
        }
        
    }
    protected void Image8_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);
        if (board.GetSquare(row, column) == "X" || board.GetSquare(row, column) == "")
        {
            my_imgbtn.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
        }
        
    }
    protected void Image9_Click(object sender, ImageClickEventArgs e)
    {
        int row, column;
        ImageButton my_imgbtn = (ImageButton)sender;
        GetRowAndColumn(my_imgbtn, out row, out column);
        board.SetSquare(row, column, Board.userSymbol);
        if (board.GetSquare(row, column) == "X" || board.GetSquare(row, column) == "")
        {
            my_imgbtn.ImageUrl = "Images/" + Board.userSymbol + ".jpg";
        }
       
    }*/
}