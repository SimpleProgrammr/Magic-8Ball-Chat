namespace Magic_8_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dialog.Text = ">Hello, ask me a question\n>I now everythink about you!";
        }
        
        private void ShakeTheBall(object sender, EventArgs e)
        {
            
            string QUESTION = "";
            QUESTION = InputText.Text;
            Random RANDOM = new Random();
            int group = RANDOM.Next(3);
            int text = RANDOM.Next(4);
            Dialog.Text += "\n>[" + DateTime.Now + "] " + QUESTION;
            string answer = "["+ DateTime.Now + "] *Magic 8-Ball* ";
            switch (group)
            {
                case 0://Very Positive
                    switch (text)
                    {
                        case 0:
                            answer += "It is certain";
                            break;
                        case 1:
                            answer += "It is decidedly so";
                            break;
                        case 2:
                            answer += "Without a doubt";
                            break;
                        case 3:
                            answer += "Yes definitely";
                            break;
                        case 4:
                            answer += "You may rely on it";
                            break;
                    }
                    break;
                case 1://Positive
                    switch (text)
                    {
                        case 0:
                            answer += "As I see it, yes";
                            break;
                        case 1:
                            answer += "Most likely";
                            break;
                        case 2:
                            answer += "Outlook good";
                            break;
                        case 3:
                            answer += "Yes";
                            break;
                        case 4:
                            answer += "Signs point to yes";
                            break;
                    }
                    break;
                case 2://Medium 
                    switch (text)
                    {
                        case 0:
                            answer += "Reply hazy, try again";
                            break;
                        case 1:
                            answer += "Ask again later";
                            break;
                        case 2:
                            answer += "Better not tell you now";
                            break;
                        case 3:
                            answer += "Cannot predict now";
                            break;
                        case 4:
                            answer += "Concentrate and ask again";
                            break;
                    }
                    break;
                case 3://Negative
                    switch (text)
                    {
                        case 0:
                            answer += "Don't count on it";
                            break;
                        case 1:
                            answer += "My reply is no";
                            break;
                        case 2:
                            answer += "My sources say no";
                            break;
                        case 3:
                            answer += "Outlook not so good";
                            break;
                        case 4:
                            answer += "Very doubtful";
                            break;
                    }
                    break;
            }
            Dialog.Text += "\n>" + answer;
            File.WriteAllText("Q&A.txt",$"> [{DateTime.Now.ToString()}] > + {QUESTION} -> {text}");
        }

    }
}