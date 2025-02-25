using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia_AAY_2023_24
{
    public partial class C1: Form
    {
        public C1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new Size(225, 130);
           // button1.Location = new Point(30, 60);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(210, 115);
            //button1.Location = new Point(25, 75);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Size = new Size(225, 130);
           // button2.Location = new Point(277, 61);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(210, 115);
            //button2.Location = new Point(298, 75);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Size = new Size(225, 130);
            //button3.Location = new Point(548, 61);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(210, 115);
            //button3.Location = new Point(566, 75);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Size = new Size(225, 130);
           // button4.Location = new Point(160, 217);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new Size(210, 115);
            //button4.Location = new Point(181, 246);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Size = new Size(225, 130);
           // button5.Location = new Point(445, 217);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Size = new Size(210, 115);
            //button5.Location = new Point(451, 246);
        }

        public static int parentX, parentY;

        private void button2_Click(object sender, EventArgs e)
        {

           OpenC1Modal("Παίζει τώρα : \"Vincent\" by Don McLean\n \n" + 
               "Η σύνδεση μεταξύ του έργου ζωγραφικής του Van Gogh και του τραγουδιού του\n" +
               "Don McLean είναι ότι το τραγούδι είναι έμπνευσμένο από το έργο τέχνης. Ο McLean\n" +
               "γράφοντας το τραγούδι αντλεί έμπνευση από την εικόνα που δημιούργησε ο Van\n" +
               "Gogh με τον ίδιο τίτλο. Στους στίχους του τραγουδιού αναφέρεται η ζωγραφική\n" +
               "τεχνική του Van Gogh και περιγράφεται η εικόνα που παρουσιάζει ο πίνακας\n" +
               "του Van Gogh,καθιστώντας την ένα σημαντικό στοιχείο της εμπνευστικής\n" +
               "διαδικασίας του τραγουδιού.");
            Form modalBackground = new Form();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenC1Modal("Παίζει τώρα : \"Scream\" by Michael Jackson\n \n " +
                "Η σύνδεση μεταξύ του έργου ζωγραφικής  του Edvard Munch και του τραγουδιού\n" +
                "του Michael Jackson είναι περισσότερο θεματολογική παρά αισθητική. Το έργο\n" +
                "ζωγραφικής του Munch απεικονίζει ένα ανθρώπινο πρόσωπο που φαίνεται να\n" +
                "βρίσκεται σε κατάσταση έντονου πόνου και αγωνίας, με τα χαρακτηριστικά\n" +
                "του να εκφράζονται με έντονα χρώματα και ακατάστατες γραμμές. Το τραγούδι\n" +
                "του Michael Jackson, από το άλμπουμ του \"HIStory: Past, Present and\n" +
                "Future, Book I\", είναι ένα τραγούδι που αναφέρεται στην αντίδραση του\n" +
                "καλλιτέχνη σε διάφορα θέματα, συμπεριλαμβανομένης της ειδησεογραφικής\n" +
                "κάλυψης της προσωπικής του ζωής και της ενοχλητικήςπαρακολούθησης από τα\n" +
                "μέσα μαζικής ενημέρωσης. Και τα δύο έργα αντικατοπτρίζουν την έντονη\n" +
                "ανθρώπινη αναζήτηση έκφρασης και απελευθέρωσης από πόνο και αγωνία,\n" +
                "καταλήγοντας σε καλλιτεχνική έκφραση του εσωτερικού κόσμου του καλλιτέχνη.");
            Form modalBackground = new Form();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenC1Modal("Παίζει τώρα : \"Carmen\" by George Bizet\n \n " +
                "Η σύνδεση μεταξύ του έργου ζωγραφικής  του John Singer Sargent και της όπερας\n" +
                "του George Bizet είναι ότι και τα δύο έργα αναδεικνύουν και αναδεικνύονται από την\n" +
                "ισπανική κουλτούρα. Ο πίνακας απεικονίζει μια σκηνή φλαμένκο, μιας είδους\n" +
                "ισπανικής παράδοσης χορού και μουσικής. Η εικόνα αυτή αποτελεί ένα έργο που\n" +
                "είναι εμπνευσμένο απότην ισπανική κουλτούρα και παραδοσιακούς χορούς. Από την\n" +
                "άλλη πλευρά, η όπερα του George Bizet είναι μια από τις πιο γνωστές και\n" +
                "αγαπημένες όπερες, η οποία διαδραματίζεται στην Ισπανία. Το έργο αυτό επίσης\n" +
                "αντλεί έμπνευση από την ισπανική κουλτούρα, με τουςχαρακτήρες και τη μουσική\n" +
                "της όπερας να αντικατοπτρίζουν το πάθος και τον ρυθμό της ισπανικής μουσικής\n" +
                "και χορού. Και τα δύο έργα, λοιπόν, μας μεταφέρουν σε έναν κόσμο γεμάτο ένταση,\n" +
                "πάθος και έντονες συναισθηματικές εκφάνσεις, βυθίζοντας μας στην πλούσια και\n" +
                "εκρηκτική ισπανική κουλτούρα.");
            Form modalBackground = new Form();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            OpenC1Modal("Παίζει τώρα : \"All Night Long\" by Lionel Richie\n \n " +
                "Η σύνδεση μεταξύ του έργου ζωγραφικής του Edward Hopper και του τραγουδιού\n " +
                "του Lionel Richie δεν είναι προφανής, καθώς ανήκουν σε διαφορετικά είδη τέχνης\n " +
                "και δημιουργήθηκαν σε διαφορετικές εποχές. Το έργο ζωγραφικής  του Edward\n" +
                "Hopper παρουσιάζει μια σκηνή σε ένα καφενείο τη νύχτα, όπου μια ομάδα\n" +
                "ανθρώπων καθίστανται ήρωες της μοναξιάς στη μεγάλη πόλη. Η εικόνα αυτή\n" +
                "απεικονίζει την απομόνωση και τη μοναξιά των ανθρώπων σε μια αστική περιοχή.\n" +
                "Από την άλλη πλευρά, το τραγούδι του Lionel Richie είναι ένα ενθαρρυντικό\n" +
                "τραγούδι με χορευτικό ρυθμό που καλεί τους ανθρώπους να διασκεδάσουν και να\n" +
                "χορέψουν όλη νύχτα. Μπορεί να υπάρχει μια αδόμητη σύνδεση στο γεγονός ότι και\n" +
                "τα δύο έργα αναφέρονται σε μια κατάσταση της νύχτας, αλλά οι αισθητικές και\n" +
                "θεματικές διαφορές τους είναι σημαντικές και δεν υπάρχει συγκεκριμένη\n" +
                "σύνδεση μεταξύ τους.");
            Form modalBackground = new Form();
           
        }

        private void button1_Click(object sender, EventArgs e)

        {

            OpenC1Modal("Παίζει τώρα :\"Morning Has Broken\" by Cat Stevens\n \n  " +
                "Η σύνδεση μεταξύ του έργου ζωγραφικής  του  Monet και του τραγουδιού  του Cat\n" +
                "Stevens έχει να κάνει με το θέμα της φύσης και της αναγέννησης που τα δύο έργα \n" +
                "αντιπροσωπεύουν. Το έργο του Monet  απεικονίζει μια αυγή στο λιμάνι του Λε \n " +
                "Χαβρ  της Γαλλίας, με την ατμόσφαιρα και τις αποχρώσεις του χρώματος να \n" +
                " δημιουργούν μια  εικόνα αισθητικής αναγέννησης και ομορφιάς. Το τραγούδι \n" +
                "του Cat Stevens αντιπροσωπεύει την ίδια  δέα αναγέννησης και αισιοδοξίας,\n" +
                "καθώς αναφέρεται στην ομορφιά της νέας μέρας και στη χαρά που φέρνει η φύση. \n" +
                "Έτσι, και τα δύο έργα αναδεικνύουν την ομορφιά και την ανανέωση της \n" +
                "φύσης, με τον Monet να το αποτυπώνει με τις μπογιές του στην καμβά και \n" +
                "τον Cat Stevens με τους στίχους του και τη μουσική του.");
            Form modalBackground = new Form();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainCustomer mainCustomer = new MainCustomer();
            mainCustomer.Show();
            Visible = false;
        }

        private void C1_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(900, 400);


        }

        private void OpenC1Modal(string content)
        {
            c1modal modalForm = new c1modal(content);
            modalForm.ShowDialog();
        }

    }
}
