using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;
using System.Diagnostics;

namespace GitForGaelige
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textboxtranslate = TextBoxTranslate.Text;

            if (textboxtranslate.Length <= 1)
            {
                switch (textboxtranslate)
                {
                    case "1":
                        Interpreter_text.Text = ("a haon");
                        Phonetics.Text = ("/Ah-Hain/");
                        break;
                    case "2":
                        Interpreter_text.Text = ("a dó");
                        Phonetics.Text = ("/Ah-Dough/");
                        break;
                    case "3":
                        Interpreter_text.Text = ("a trí");
                        Phonetics.Text = ("/Ah-tree/");
                        break;
                    case "4":
                        Interpreter_text.Text = ("a ceathair");
                        Phonetics.Text = ("/Ah-cah-her/");
                        break;
                    case "5":
                        Interpreter_text.Text = ("a cúig");
                        Phonetics.Text = ("/Ah-coo-ig/");
                        break;
                    case "6":

                        Interpreter_text.Text = ("a sé");
                        Phonetics.Text = ("/Ah-shay/");
                        break;
                    case "7":
                        Interpreter_text.Text = ("a seacht");
                        Phonetics.Text = ("/Ah-shocked/");
                        break;
                    case "8":
                        Interpreter_text.Text = ("a hocht");
                        Phonetics.Text = ("/Ah-huck-t/");
                        break;
                    case "9":
                        Interpreter_text.Text = ("a naoi");
                        Phonetics.Text = ("/Ah-nay/");
                        break;
                    case "I":
                        Interpreter_text.Text = ("mé");
                        break;
                    case "i":
                        Interpreter_text.Text = ("mé");
                        break;

                }


            }
            if (textboxtranslate.Length <= 2)
            {
                switch (textboxtranslate)
                {
                    case "10":
                        Interpreter_text.Text = ("a deich");
                        Phonetics.Text = ("/Ah-deh/");
                        break;
                    case "20":
                        Interpreter_text.Text = ("fiche");
                        break;
                    case "30":
                        Interpreter_text.Text = ("triocha");
                        break;
                    case "40":
                        Interpreter_text.Text = ("daichead");
                        break;
                    case "50":
                        Interpreter_text.Text = ("caoga");
                        break;
                    case "60":
                        Interpreter_text.Text = ("seasca");
                        break;
                    case "70":
                        Interpreter_text.Text = ("seachtó");
                        break;
                    case "80":
                        Interpreter_text.Text = ("ochtó");
                        break;
                    case "90":
                        Interpreter_text.Text = ("nócha");
                        break;
                    case "he":
                        Interpreter_text.Text = ("sé");
                        break;
                    case "He":
                        Interpreter_text.Text = ("Sé");
                        break;



                }

            }
            if (textboxtranslate.Length <= 3)
            {
                switch (textboxtranslate)
                {

                    case "she":
                        Interpreter_text.Text = ("sí");
                        break;
                    case "git":
                        Interpreter_text.Text = ("liúdramán(Masculine) leibide(Feminine)");
                        Phonetics.Text = ("/lou-dra-mun/ /leh-beh-de");

                        break;
                    case "why":
                        Interpreter_text.Text = ("cén fáth");
                        Phonetics.Text = ("/kay-Faw/");
                        break;



                }
            }
            if(textboxtranslate == "January" || textboxtranslate == "january") 
            {
                Interpreter_text.Text = ("Eanáir");
                Phonetics.Text = ("/AN-nar/");
            }
            if (textboxtranslate == "February" || textboxtranslate == "february")
            {
                Interpreter_text.Text = ("Feabhra");
                Phonetics.Text = ("/FEY-AIR/ /RAH/");
            }
            if (textboxtranslate == "March" || textboxtranslate == "march")
            {
                Interpreter_text.Text = ("Márta");
                Phonetics.Text = ("/MAR-Tuh/");
            }
            if (textboxtranslate == "April" || textboxtranslate == "april")
            {
                Interpreter_text.Text = ("Aibreán");
                Phonetics.Text = ("/AH-BRAWN/");
            }
          
            if (textboxtranslate == "May" || textboxtranslate == "may")
            {
                Interpreter_text.Text = ("Bealtaine");
                Phonetics.Text = ("/BE-AIL-TAN-UH/");
            }
            if (textboxtranslate == "June" || textboxtranslate == "june")
            {
                Interpreter_text.Text = ("Meitheamh");
                Phonetics.Text = ("/MEH-HUV");
            }
            if (textboxtranslate == "July" || textboxtranslate == "july")
            {
                Interpreter_text.Text = ("Iúil");
                Phonetics.Text = ("/YOOL/");
            }
            if (textboxtranslate == "August" || textboxtranslate == "august")
            {
                Interpreter_text.Text = ("Lúnasa");
                Phonetics.Text = ("/LUN-NUH-SA/");
            }
            if (textboxtranslate == "September" || textboxtranslate == "september")
            {
                Interpreter_text.Text = ("Meán Fómhair");
                Phonetics.Text = ("/MAN-FOUR/");
            }
            if (textboxtranslate == "October" || textboxtranslate == "october")
            {
                Interpreter_text.Text = ("Deireadh Fómhair");
                Phonetics.Text = ("/AIR-RUH-FOUR/");
            }
            if (textboxtranslate == "November" || textboxtranslate == "november")
            {
                Interpreter_text.Text = ("Samhna");
                Phonetics.Text = ("/SEOW-WYN/");
            }
            if (textboxtranslate == "December" || textboxtranslate == "december")
            {
                Interpreter_text.Text = ("Nollaig");
                Phonetics.Text = ("/NULL-LEAG-Guh");
            }





            if (textboxtranslate == "Hello")
            {

                Interpreter_text.Text = ("Dia duit");
                Phonetics.Text = ("/Jee-ah ghwitch /");
            }
            if (textboxtranslate == "hi")
            {

                Interpreter_text.Text = ("Dia duit");
                Phonetics.Text = ("/Jee-ah ghwitch /");
            }
            if (textboxtranslate == "Hi")
            {

                Interpreter_text.Text = ("Dia duit");
                Phonetics.Text = ("/Jee-ah ghwitch /");
            }
            if (textboxtranslate == "Hello")
            {

                Interpreter_text.Text = ("Dia duit");
                Phonetics.Text = ("/Jee-ah ghwitch /");
            }
            if (textboxtranslate == "very good")
            {

                Interpreter_text.Text = ("An-mhaith");
                Phonetics.Text = ("/On Meh/");
            }
            if (textboxtranslate == "Very good")
            {

                Interpreter_text.Text = ("An-mhaith");
                Phonetics.Text = ("/On Meh/");
            }
            if (textboxtranslate == "good")
            {

                Interpreter_text.Text = ("An-mhaith");
                Phonetics.Text = ("/On Meh/");
            }
            if (textboxtranslate == "Good")
            {

                Interpreter_text.Text = ("An-mhaith");
                Phonetics.Text = ("/On Meh");
            }
            if (textboxtranslate == "How are you")
            {

                Interpreter_text.Text = ("Conas atá tú?");
                Phonetics.Text = ("/Con-ass at-taw Too/");
            }
            if (textboxtranslate == "How are you?")
            {
                Interpreter_text.Text = ("Conas atá tú?");
                Phonetics.Text = ("/Con-ass at-taw Too/");
            }
            if (textboxtranslate == "how are you?")
            {
                Interpreter_text.Text = ("Conas atá tú?");
                Phonetics.Text = ("/Con-ass at-taw Too/");
            }
            if (textboxtranslate == "how are you")
            {
                Interpreter_text.Text = ("Conas atá tú?");
                Phonetics.Text = ("/Con-ass at-taw Too/");
            }
            if (textboxtranslate == "I love you")
            {
                Interpreter_text.Text = ("Tá mé i ngrá leat.");
                Phonetics.Text = ("/TAW may ih ngraw lyat/");
            }
            if (textboxtranslate == " love you")
            {
                Interpreter_text.Text = ("Tá mé i ngrá leat.");
                Phonetics.Text = ("/TAW may ih ngraw lyat/");
            }
            if (textboxtranslate == " i love you")
            {
                Interpreter_text.Text = ("Tá mé i ngrá leat.");
                Phonetics.Text = ("/TAW may ih ngraw lyat/");
            }
            if (textboxtranslate == "I'm hungry")
            {
                Interpreter_text.Text = ("Tá ocras orm");
                Phonetics.Text = ("/TAW-Uk-rass ur-um/");

            }
            if (textboxtranslate == "you")
            {
                Interpreter_text.Text = ("Tú");
            }
            if (textboxtranslate == "you?")
            {
                Interpreter_text.Text = ("Tú?");
            }
            if (textboxtranslate == "you all")
            {
                Interpreter_text.Text = ("sibh");
            }
            if (textboxtranslate == "Are you hungry")
            {
                Interpreter_text.Text = ("An bhfuil ocras ort?");
                Phonetics.Text = ("/On will uk-rass urt/");

            }
            if (textboxtranslate == "Are you hungry?")
            {
                Interpreter_text.Text = ("An bhfuil ocras ort?");

            }
            if (textboxtranslate == "hungry?")
            {
                Interpreter_text.Text = ("An bhfuil ocras ort?");

            }
            if (textboxtranslate == "you hungry?")
            {
                Interpreter_text.Text = ("An bhfuil ocras ort?");

            }
            if ((textboxtranslate == "I have to go"))
            {
                Interpreter_text.Text = ("Tá orm imeacht");

            }
            if (textboxtranslate == "thank you")
            {
                Interpreter_text.Text = ("Go raibh maith agat");
            }
            if (textboxtranslate == "thank")
            {
                Interpreter_text.Text = ("maith");
            }
            if (textboxtranslate == "thanks")
            {
                Interpreter_text.Text = ("maith");
            }
            if ((textboxtranslate == "brother"))
            {
                Interpreter_text.Text = ("dheartháir");
                Phonetics.Text = ("/ghrih-hawr/");
            }
            if ((textboxtranslate == " my brother"))
            {
                Interpreter_text.Text = ("Mo dheartháir");
                Phonetics.Text = ("/Muh-grih-foor/");
            }
            if ((textboxtranslate == " My brother"))
            {
                Interpreter_text.Text = ("Mo dheartháir");
                Phonetics.Text = ("/Muh-grih-foor/");

            }
            if ((textboxtranslate == " my sister"))
            {
                Interpreter_text.Text = ("Mo dheirfiúr");
                Phonetics.Text = ("Muh grih-foor");
            }
            if ((textboxtranslate == " My sister"))
            {
                Interpreter_text.Text = ("Mo dheirfiúr");
                Phonetics.Text = ("/Muh-grih-foor/");
            }
            if ((textboxtranslate == "sister"))
            {
                Interpreter_text.Text = ("dheirfiúr");
                Phonetics.Text = ("/grih-foor/");
            }
            if (textboxtranslate == "What?")
            {
                Interpreter_text.Text = ("céard?");
                Phonetics.Text = ("/kay-rd/");

            }
            if (textboxtranslate == "what?")
            {
                Interpreter_text.Text = ("céard?");
                Phonetics.Text = ("/kay-rd/");

            }
            if (textboxtranslate == "what")
            {
                Interpreter_text.Text = ("céard");
                Phonetics.Text = ("/kay-rd/");

            }
        }

        public void Interpreter_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            string interpreter = Interpreter_text.Text;

        }

        
        
       

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string Phonetics_text = Phonetics.Text;
        }





        public void PlaySound_Click_1(object sender, RoutedEventArgs e)
        {
            if(Interpreter_text.Text == "Eanáir") {JanPronounce();} 
            if(Interpreter_text.Text == "Feabhra") { FebPronounce(); }
            if(Interpreter_text.Text == "Márta") { MarPronounce(); }
            if (Interpreter_text.Text == "Aibreán"){ ApriPronounce(); }
            if(Interpreter_text.Text == "Bealtaine") { MayPronounce(); }
            if( Interpreter_text.Text == "Meitheamh") { junePronounce(); }
            if (Interpreter_text.Text == "Iúil") { julyPronounce(); }
            if (Interpreter_text.Text == "Lúnasa") { augPronounce(); }
            if (Interpreter_text.Text == "Meán Fómhair") { sepPronounce(); }
            if (Interpreter_text.Text == "Deireadh Fómhair") { octPronounce(); }
            if (Interpreter_text.Text == "Samhna") { novPronounce(); }
            if (Interpreter_text.Text == "Nollaig") { decPronounce(); }
            if (Interpreter_text.Text == "Tá ocras orm")
            {
                HungryPronounce();


            }
            if (Interpreter_text.Text == "Dia duit")
            {

                HelloPronounce();
            }
            if (Interpreter_text.Text == "An bhfuil ocras ort?")
            {

                AreHungry();

            }
            if (Interpreter_text.Text == "Conas atá tú?")
            {

                HowareYou();

            }
            if (Interpreter_text.Text == "An-mhaith")
            {

                GoodGae();
            }
            if (Interpreter_text.Text == "Tá mé i ngrá leat.")
            {

                ilyGae();
            }
            if (Interpreter_text.Text == "Mo dheartháir" || Interpreter_text.Text == "dheartháir")
            {
                Bro();

            }
            if (Interpreter_text.Text == "Mo dheirfiúr" || Interpreter_text.Text == "dheirfiúr")
            {
                Sister();
            }
            if (Interpreter_text.Text == "céard")
            {
                kayard();
            }
            if (Interpreter_text.Text == "a haon")
            {
                One();
            }
            if (Interpreter_text.Text == "a dó")
            {
                Two();

            }

            if (Interpreter_text.Text == "a trí")
            {
                Three();
            }
            if(Interpreter_text.Text == "a ceathair") 
            { 
                Four();
            }
            if (Interpreter_text.Text == "a cúig")
            {
                Five();
            }
            if (Interpreter_text.Text == "a sé")
            {
                Six();
            }
            if (Interpreter_text.Text == "a seacht")
            {
                Seven();
            }
            if (Interpreter_text.Text == "a hocht")
            {
                Eight();
            }
           
            if (Interpreter_text.Text == "a naoi")
            {
                Nine();
            }
            if (Interpreter_text.Text == "a deich")
            {
                Ten();
            }


        }
        public void JanPronounce() 
        { 
            SoundPlayer soundPlayer = new SoundPlayer("January.wav");
            soundPlayer.Play();

        }
        public void FebPronounce()
        {
            SoundPlayer soundPlayer = new SoundPlayer("february.wav");
            soundPlayer.Play();

        }
        public void MarPronounce()
        {
            SoundPlayer soundPlayer = new SoundPlayer("march.wav");
            soundPlayer.Play();

        }
        public void ApriPronounce()
        {
            SoundPlayer soundPlayer = new SoundPlayer("April.wav");
            soundPlayer.Play();

        }
        public void MayPronounce()
        {
            SoundPlayer soundPlayer = new SoundPlayer("May.wav");
            soundPlayer.Play();

        }
        public void junePronounce() 
        {
            SoundPlayer sound = new SoundPlayer("June.wav");
            sound.Play();
        }
        public void julyPronounce() 
        {
            SoundPlayer soundplayer = new SoundPlayer("July.wav");
            soundplayer.Play();
        }
        public void augPronounce() 
        {
            SoundPlayer player = new SoundPlayer("August.wav");
            player.Play();
        }
        public void sepPronounce() 
        {
            SoundPlayer play = new SoundPlayer("September.wav");
            play.Play();
        }
        public void octPronounce() 
        {
            SoundPlayer soundPlayer1 = new SoundPlayer("October.wav");
            soundPlayer1.Play();
        }
        public void novPronounce() 
        {
            SoundPlayer player1 = new SoundPlayer("Nov.wav");
            player1.Play();
        }
        public void decPronounce() 
        {
            SoundPlayer soundPlayer2 = new SoundPlayer("Dec.wav");
            soundPlayer2.Play();
        }
        public void HungryPronounce()

        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.Stream = GitForGaelige.Properties.Resources.Ta_Ocras;
            soundPlayer.Play();

        }

        public void HelloPronounce()

        {
            SoundPlayer helloPlayer = new SoundPlayer("Hello.wav");
            helloPlayer.Play();


        }
        public void AreHungry()
        {
            SoundPlayer arehungry = new SoundPlayer("IsHungry.wav");
            arehungry.Play();


        }
        public void HowareYou()
        {
            SoundPlayer Howareyou = new SoundPlayer("howareyou.wav");
            Howareyou.Play();


        }
        public void GoodGae()
        {
            SoundPlayer goodgae = new SoundPlayer("Good.wav");
            goodgae.Play();


        }
        public void ilyGae()
        {

            SoundPlayer ilygae = new SoundPlayer("ilygae.wav");
            ilygae.Play();


        }
        public void Bro()
        {
            SoundPlayer bro = new SoundPlayer("bro.wav");
            bro.Play();
        }
        public void Sister()
        {
            SoundPlayer stister = new SoundPlayer("sistergae.wav");
            stister.Play();
        }
        public void kayard()
        {
            SoundPlayer kayard = new SoundPlayer("whatgae.wav");
            kayard.Play();
        }
        public void One()
        {
            SoundPlayer one = new SoundPlayer("One.wav");
            one.Play();


        }
        public void Two()
        {
            SoundPlayer two = new SoundPlayer("Two.wav");
            two.Play();
        }
        public void Three()
        {
            SoundPlayer three = new SoundPlayer("Three.wav");
            three.Play();
        }
        public void Four() 
        {
            SoundPlayer four = new SoundPlayer("Four.wav");
            four.Play();
        
        }
        public void Five() 
        {
            SoundPlayer five = new SoundPlayer("Five.wav");
            five.Play();
        }
        public void Six() 
        {
            SoundPlayer six = new SoundPlayer("Six.wav");
            six.Play();
        }
        public void Seven() 
        {
            SoundPlayer seven = new SoundPlayer("Seven.wav");
            seven.Play();
        }
        public void Eight() 
        {
            SoundPlayer eight = new SoundPlayer("Eight.wav");
            eight.Play();
        }
        public void Nine() 
        {
            SoundPlayer nine = new SoundPlayer("Nine.wav");
            nine.Play();
        }
        public void Ten() 
        {
            SoundPlayer ten = new SoundPlayer("Ten.wav");
            ten.Play();
        }
    }
}
        
   

