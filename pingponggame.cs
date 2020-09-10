public Boolean Collision_Left(PictureBox obj)
{
    if (obj.Location.X <= 0)
    {
        return true;
    }
    return false;
}

public Boolean Collision_Right(PictureBox obj)
{
    if (obj.Location.X + obj.Width >= WorldFrame.Width)
    {
        return true;
    }
    return false;
}
private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)      
            {
                case Keys.W:
                case Keys.Up:
                    Player_Down = false;
                    Player_Up = true;
                    break;
                case Keys.S:
                case Keys.Down:
                    Player_Up = false;
                    Player_Down = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    Player_Up = false;
                    break;
                case Keys.S:
                case Keys.Down:
                    Player_Down = false;
                    break;
            }
        }
        if (Player_Up && !Collision_Up(pb_Player))
                {               
                    pb_Player.Top -= Speed_Player;    
                }
if (Player_Down && !Collision_Down(pb_Player))
                {               
                    pb_Player.Top += Speed_Player;
                }
                public Boolean Collision_Player(PictureBox tar)
{
    if (!tar.Bounds.IntersectsWith(pb_Player.Bounds))
    {
        return;                PictureBox temp1 = new PictureBox();
    temp1.Bounds = pb_Player.Bounds;
    temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y, 1, 10);
    if (tar.Bounds.IntersectsWith(temp1.Bounds))
    {
        BallForce = 3;
        return true;
    }
    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 5, 1, 10);
    if (tar.Bounds.IntersectsWith(temp1.Bounds))
    {
        BallForce = 2;
        return true;
    }
    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
    if (tar.Bounds.IntersectsWith(temp1.Bounds))
    {
        BallForce = 1;
        return true;
    }
    ...
if (BallForce > 0)
 {
     pb_Ball.Top -= BallForce;
 }
 if (BallForce < 0)
 {
     pb_Ball.Top -= BallForce;
 }
 if (pb_Ball.Location.Y <= 1)
{
    BallForce = ReverseInt(BallForce, true, true);
}
if (pb_Ball.Location.Y + pb_Ball.Height >= WorldFrame.Height - 1)
{
    BallForce = ReverseInt(BallForce, true, false);
}
public int ReverseInt(int x, Boolean Force = false, Boolean Negative = false)
        {
            if (Force) 
            {
                if (Negative)  
                {
                    if (x > 0) 
                    {
                        x = ~x + 1;
                    }         
                }
                else
                {  
                    x = x - (x * 2);
                }
            }
            else
            {
                if (x > 0)
                {
                    x = x - (x * 2);
                }
                else
                {          
                    x = ~x + 1;
                }
            }
            return x;
        }
        if (pb_Enemy.Location.Y + 28 < pb_Ball.Location.Y)
                {   //Which is around 28 pixels below its Y coordinate
                    pb_Enemy.Top += Speed_Enemy;
                }
                else
                {
                    pb_Enemy.Top -= Speed_Enemy;
                }
                public void AddScore(PictureBox[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].BackColor == ScoreColor)
        {   //And then changes it to black
            Arr[i].BackColor = Color.Black;
            break;
        }
    }

    if (Arr[4].BackColor == Color.Black)
    {
        GameOn = false;
        label_Start.Visible = true;
        RestoreScore();
        pb_Ball.Location = new Point(208, rng.Next(10, 190));
        pb_Player.Location = new Point(3, 67);
        pb_Enemy.Location = new Point(409, 67);
        Round = 0;
        label_Time.Visible = false;
    }
}

