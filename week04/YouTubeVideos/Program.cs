using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make ice", "tim", 600);

        Comment comment11 = new Comment("jj", "cool now i can have cooled drinks");
        video1.AddComment(comment11);

        Comment comment12 = new Comment("aa", "Ice is cool");
        video1.AddComment(comment12);

        Comment comment13 = new Comment("bb", "Ice is too cold");
        video1.AddComment(comment13);

        video1.CommentCount();
        video1.DisplayVideo();
        video1.DisplayComment();
        Console.WriteLine("");



        Video video2 =new Video("How to freeze water", "bobby", 900);

        Comment comment21 =new Comment("aaaa", "wow I learned something new");
        video2.AddComment(comment21);

        Comment comment22 = new Comment("qqqqq", "wow I didnt know you could freexe water");
        video2.AddComment(comment22);

        Comment comment23 = new Comment("a dude", "why does one freeze water");
        video2.AddComment(comment23);

        video2.CommentCount();
        video2.DisplayVideo();
        video2.DisplayComment();
        Console.WriteLine("");




        Video video3 = new Video("How to menlt ice", "jimmy", 1000);

        Comment comment31 = new  Comment("e", "wow we can make water");
        video3.AddComment(comment31);

        Comment comment32 = new Comment("EE", "neat!");
        video3.AddComment(comment32);

        Comment comment33 = new Comment("eEe", "whoa");
        video3.AddComment(comment33);

        video3.CommentCount();
        video3.DisplayVideo();
        video3.DisplayComment();
    }
}