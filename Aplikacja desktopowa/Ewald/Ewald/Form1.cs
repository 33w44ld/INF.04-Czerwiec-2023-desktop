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
         parametry wej�ciowe: <sender, e> - <obiekt, arguementy wydarzenia>
         warto�� zwracana: <brak>
         informacje: <funckja sprawdz, kt�ry radioButton jest zaznaczony i zale�nie od tego 
         zmienia obraz dla pictureBox1 oraz zmienia tekst label1 >
         autor: <12312312312>
        ****************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                pictureBox1.Image = Ewald.Properties.Resources.pocztowka;
                label1.Text = "Cena: 1 z�";
            }
            if(radioButton2.Checked)
            {
                pictureBox1.Image = Ewald.Properties.Resources.list;
                label1.Text = "Cena: 1.5 z�";
            }
            if(radioButton3.Checked)
            {
                pictureBox1.Image = Ewald.Properties.Resources.paczka;
                label1.Text = "Cena: 10 z�";
            }

        }

        /*******************************************************
         nazwa funkcji: <button2_Click>
         parametry wej�ciowe: <sender, e> - <obiekt, arguementy wydarzenia>
         warto�� zwracana: <brak>
         informacje: <funkcja przeprowadza walidacje kod pocztowego 
         na pocz�tku sprawdza czy kod pocztowy sk�ada si� z samych cyfr 
         (je�li nie wy�wietla komunikat), a nast�pnie sprawdza czy kod 
         pocztowy posiada 5 cyfr (je�li nie wy�wietla komunikat), 
         po poprawnej walidacja wy�wietla komunikat>
         autor: <12312312312>
        ****************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            string kod = textBox2.Text;
            if (!kod.All(char.IsDigit)) MessageBox.Show("Kod pocztowy powinien si� sk�ada� z samych cyfr");
            else
            {
                if (kod.Length != 5) MessageBox.Show("Nieprawid�owa liczba cyfr w kodzie pocztowym");
                else MessageBox.Show("Dane przesy�ki zosta�y wprowadzone");
            }
        }
    }
}