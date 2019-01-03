using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calcul : Form
    {
        int resultat;
        int a;
        int b;

        public Calcul()
        {
            InitializeComponent();
        }

        private void calculer_Click(object sender, EventArgs e)
        {
            if ((entier1.Text != null) && (entier2.Text != null))
            {
                calculer.Enabled = true;
                a = int.Parse(entier1.Text);
                b = int.Parse(entier2.Text);
                if (produit.Checked)
                {
                    resultat = a * b;
                    valeur.Text = resultat.ToString();
                }
                else if (pgcd.Checked)
                {
                    resultat = 1;
                    while ((resultat != 0) && (a != 0) && (b != 0))
                    {
                        if (a > b)
                        {
                            resultat = a % b;
                            a = resultat;
                        }
                        else
                        {
                            resultat = b % a;
                            b = resultat;
                        }
                    }
                    if ((b == 0) && (a == 0))
                    {
                        MessageBox.Show("Valeur impossible à calculer. Veuillez saisir de nouvelles valeurs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        entier1.Clear();
                        entier2.Clear();
                        entier1.Focus();
                        valeur.Text = "Impossible";
                    }
                    else if (a == 0)
                    {
                        valeur.Text = b.ToString();
                    }
                    else if (b == 0)
                    {
                        valeur.Text = a.ToString();
                    }

                }
                else if (reste.Checked)
                {
                    if (b != 0)
                    {
                        resultat = a % b;
                        valeur.Text = resultat.ToString();
                    }
                    else
                    {
                        if (a != 0)
                        {
                            MessageBox.Show("Valeur impossible à calculer. Veuillez saisir une nouvelle valleur de l'entier 2.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            entier2.Clear();
                            entier2.Focus();
                            valeur.Text = "Division impossible";
                        }
                        else
                        {
                            MessageBox.Show("Le résultat est indéfini. Veuillez saisir de nouvelles valeurs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            entier1.Clear();
                            entier2.Clear();
                            entier1.Focus();
                            valeur.Text = "Resultat indéfini";
                        }
                    }

                }
                else if (addition.Checked)
                {
                    resultat = a + b;
                    valeur.Text = resultat.ToString();
                }
                else if (soustraction.Checked)
                {
                    resultat = a - b;
                    valeur.Text = resultat.ToString();
                }
                else if (division.Checked)
                {
                    if (b != 0)
                    {
                        resultat = a / b;
                        valeur.Text = resultat.ToString();
                    }
                    else
                    {
                        if (a != 0)
                        {
                            MessageBox.Show("Valeur impossible à calculer. Veuillez saisir une nouvelle valleur de l'entier 2.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            entier2.Clear();
                            entier2.Focus();
                            valeur.Text = "Division impossible";
                        }
                        else
                        {
                            MessageBox.Show("Le résultat est indéfini. Veuillez saisir de nouvelles valeurs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            entier1.Clear();
                            entier2.Clear();
                            entier1.Focus();
                            valeur.Text = "Resultat indéfini";
                        }
                    }

                }
            } 
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            entier1.Clear();
            entier2.Clear();
            calculer.Enabled = false;
            entier1.Focus();
            valeur.Text = "Valeur";
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entier1_TextChanged(object sender, EventArgs e)
        {
            if (entier1.Text != "")
            {
                if (entier2_TextChanged())
                {
                    calculer.Enabled = true;
                };
                
            }
            else
            {
                calculer.Enabled = false;
            }
            
        }

        private bool entier2_TextChanged()
        {
            if (entier2.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool entier1_TextChanged()
        {
            if (entier1.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Calcul_Load(object sender, EventArgs e)
        {
            calculer.Enabled = false;
            pgcd.Checked = true;
        }

        private void entier2_TextChanged(object sender, EventArgs e)
        {
            if (entier2.Text != "")
            {
                if (entier1_TextChanged())
                {
                    calculer.Enabled = true;
                };

            }
            else
            {
                calculer.Enabled = false;
            }
        }

        private void entier2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int test = 0;
            char[] entiers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < entiers.Length; i++)
            {
                if (e.KeyChar == entiers[i])
                {
                    test++;
                    break;
                }
                else if (e.KeyChar == (char)Keys.Enter)
                {
                    test++;
                    if (entier1.Text != "")
                    {
                        calculer.Select();
                    }
                    else
                    {
                        entier1.Focus();
                    }
                    break;
                }
                else if (e.KeyChar == (char)Keys.Back)
                {
                    test++;
                    break;
                }
            }
            if (test == 0)
            {
                e.KeyChar = '\0';
            }
        }

        private void entier1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int test = 0;
            char[] entiers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < entiers.Length; i++)
            {
                if (e.KeyChar == entiers[i])
                {
                    test++;
                    break;
                }
                else if (e.KeyChar == (char)Keys.Back)
                {
                    test++;
                    break;
                }
                else if (e.KeyChar == (char)Keys.Enter)
                {
                    test++;
                    if (entier2.Text != "")
                    {
                        calculer.Select();
                    }
                    else
                    {
                        entier2.Focus();
                    }
                    break;
                }
            }
            if (test == 0)
            {
                e.KeyChar = '\0';
            }
        }


    }
}
