using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_Du_Devin_inverser
{

    public partial class Jeu_Du_Devin_inverser : Form
    {
        //Déclaration des attributs
        private int NbEssais;
        private int BorneInf;
        private int BorneSup;
        private int NbTentative;
        private int Nombre;


        public Jeu_Du_Devin_inverser()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();    // Bouton Quitter
        }

        private void Jeu_Du_Devin_inverser_Load(object sender, EventArgs e)
        {
            // Désactivation des boutons
            ButtonGrand.Enabled = false;
            ButtonExact.Enabled = false;
            ButtonPetit.Enabled = false;
        
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            // Assigne une valeurs aux attributs, génére nombre Random
            NbEssais = 20;
            NbTentative = 0;
            BorneInf = 0;
            BorneSup = 10000;
            Nombre = (BorneSup - BorneInf)/2;

            // Réactive les boutons
            ButtonExact.Enabled = true;
            ButtonGrand.Enabled = true;
            ButtonPetit.Enabled = true;
            TextBoxMessage.Clear();
            TextBoxMessage.AppendText("Votre chiffre est " + Nombre + "  ?");
        }

        private void ButtonExact_Click(object sender, EventArgs e)
        {
            // Si il trouve le bon nombre.
            TextBoxMessage.Clear(); // Efface le texte 
            TextBoxMessage.AppendText("J'ai trouvé le nombre en " + NbTentative + " tentative(s)");
            ButtonGrand.Enabled = false; // Désactive les boutons
            ButtonPetit.Enabled = false;
        }

        private void ButtonGrand_Click(object sender, EventArgs e)
        {

            BorneSup = Nombre;
            Nombre = (BorneSup - BorneInf) / 2;
            Nombre = Nombre + BorneInf;
            TextBoxMessage.Clear(); // Efface le texte
            TextBoxMessage.AppendText("Votre chiffre est " + Nombre + "  ?");
            NbTentative++; // Incrémentation nombre de tentative
            NbEssais--; // Décrémentation nombre d'essai

            // Si le nombre d'essai atteint 0
            if (NbEssais == 0)
            {
                TextBoxMessage.Clear();
                TextBoxMessage.AppendText("Oups j'ai perdu ! Vous êtes vraiment fort ");
            }
        }

        private void ButtonPetit_Click(object sender, EventArgs e)
        {
            BorneInf = Nombre;
            Nombre = (BorneSup - BorneInf) / 2;
            Nombre = Nombre + BorneInf;
            TextBoxMessage.Clear();
            TextBoxMessage.AppendText("Votre chiffre est " + Nombre + "  ?");
            NbTentative++; // Incrémentation nombre de tentative
            NbEssais--; // Décrémentation nombre d'essai

            // Si le nombre d'essai atteint 0
            if (NbEssais == 0)
            {
                TextBoxMessage.Clear();
                TextBoxMessage.AppendText("Oups j'ai perdu ! Vous êtes vraiment fort ");
            }
        }
    }
}
