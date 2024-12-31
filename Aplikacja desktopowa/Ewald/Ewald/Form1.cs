using System.Reflection.Metadata;

namespace Ewald
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*******************************************************
         nazwa funkcji: <button1_Click>
         parametry wejœciowe: <sender, e> - <obiekt, arguementy wydarzenia>
         wartoœæ zwracana: <brak>
         informacje: <funckja sprawdz, który radioButton jest zaznaczony i zale¿nie od tego 
         zmienia obraz dla pictureBox1 oraz zmienia tekst label1 >
         autor: <12312312312>
        ****************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                pictureBox1.Image = Ewald.Properties.Resources.pocztowka;
                label1.Text = "Cena: 1 z³";
            }
            if(radioButton2.Checked)
            {
                pictureBox1.Image = Ewald.Properties.Resources.list;
                label1.Text = "Cena: 1.5 z³";
            }
            if(radioButton3.Checked)
            {
                pictureBox1.Image = Ewald.Properties.Resources.paczka;
                label1.Text = "Cena: 10 z³";
            }

        }

        /*******************************************************
         nazwa funkcji: <button2_Click>
         parametry wejœciowe: <sender, e> - <obiekt, arguementy wydarzenia>
         wartoœæ zwracana: <brak>
         informacje: <funkcja przeprowadza walidacje kod pocztowego 
         na pocz¹tku sprawdza czy kod pocztowy sk³ada siê z samych cyfr 
         (jeœli nie wyœwietla komunikat), a nastêpnie sprawdza czy kod 
         pocztowy posiada 5 cyfr (jeœli nie wyœwietla komunikat), 
         po poprawnej walidacja wyœwietla komunikat>
         autor: <12312312312>
        ****************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            string kod = textBox2.Text;
            if (!kod.All(char.IsDigit)) MessageBox.Show("Kod pocztowy powinien siê sk³adaæ z samych cyfr");
            else
            {
                if (kod.Length != 5) MessageBox.Show("Nieprawid³owa liczba cyfr w kodzie pocztowym");
                else MessageBox.Show("Dane przesy³ki zosta³y wprowadzone");
            }
        }
    }
}