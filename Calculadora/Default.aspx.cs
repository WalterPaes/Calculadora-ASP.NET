using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        private string[] display;
        private double result;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region EventsNumbers

        protected void btnZero_Click(object sender, EventArgs e)
        {
            this.setDisplay( btnZero.Text );
        }

        protected void btnOne_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnOne.Text);
        }

        protected void btnTwo_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnTwo.Text);
        }

        protected void btnThree_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnThree.Text);
        }

        protected void btnFour_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnFour.Text);
        }

        protected void btnFive_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnFive.Text);
        }

        protected void btnSix_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnSix.Text);
        }

        protected void btnSeven_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnSeven.Text);
        }

        protected void btnEight_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnEight.Text);
        }

        protected void btnNine_Click(object sender, EventArgs e)
        {
            this.setDisplay(btnNine.Text);
        }

        #endregion EventsNumbers

        #region EventsOp

        protected void btnDot_Click(object sender, EventArgs e)
        {
            string[] dots;
            string[] value;
            string expression = string.Empty;
            dots = txtDisplay.Text.Split(',');
            txtDisplay.Text = string.Empty;

            for (int i = 0; i < dots.Length; i++)
            {
                value = dots[i].Split(' ');
                foreach (string el in value)
                {
                    if (!(this.IsOperator(el)))
                    {
                        if (expression.Contains(",") == false)
                        {
                            expression = el + ",";
                        }
                        else
                        {
                            expression = el;
                        }
                        txtDisplay.Text += expression;
                    }
                    else
                    {
                        expression = " " + el + " ";
                        txtDisplay.Text += expression;
                        expression = string.Empty;
                    }
                }
            }
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            if (this.HasOperation())
            {
                this.Calcular();
            }

            if (txtDisplay.Text != string.Empty)
            {
                this.setDisplay(btnDividir.Text);
            }
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (this.HasOperation())
            {
                this.Calcular();
            }

            if (txtDisplay.Text != string.Empty)
            {
                this.setDisplay(btnMultiplicar.Text);
            }
        }

        protected void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (this.HasOperation())
            {
                this.Calcular();
            }

            if (txtDisplay.Text != string.Empty)
            {
                this.setDisplay(btnSubtracao.Text);
            }
        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            if (this.HasOperation())
            {
                this.Calcular();
            }

            if (txtDisplay.Text != string.Empty)
            {
                this.setDisplay(btnSoma.Text);
            }
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            this.Calcular();
        }

        #endregion EventsOp

        #region EventsFunctions

        protected void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        protected void btnCe_Click(object sender, EventArgs e)
        {
            string[] values;
            values = txtDisplay.Text.Split(' ');
            if (values.Length == 3)
            {
                if (values[2] == string.Empty)
                {
                    txtDisplay.Text = values[0];
                }
                else
                {
                    txtDisplay.Text = values[0] + " " + values[1] + " ";
                }
                
            }
            else if (values.Length < 2)
            {
                txtDisplay.Text = values[0];
            }
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            string display = txtDisplay.Text;
            int length = display.Length;

            if (!(display == string.Empty))
            {
                if (Convert.ToString(display[length - 1]) == " ")
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(length - 3);
                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(length - 1);
                }
            }
        }

        #endregion EventsFunctions

        #region Methods

        protected void Calcular()
        {
            try
            {
                this.display = txtDisplay.Text.Split(' ');
                
                if (this.display.Length == 3)
                {
                    if (this.display[0] != null && this.display[1] != null && this.display[2] != null)
                    {
                        if (this.IsOperator(this.display[0]) == false)
                        {
                            if (this.IsOperator(this.display[1]) == true)
                            {
                                if (this.IsOperator(this.display[2]) == false)
                                {
                                    if (this.display[2] != string.Empty)
                                    {
                                        this.SetResult(this.display[1], Convert.ToDouble(this.display[0]), Convert.ToDouble(this.display[2]));
                                        txtDisplay.Text = Convert.ToString(this.result);
                                    }
                                    else
                                    {
                                        txtDisplay.Text = this.display[0];
                                    }
                                }
                                else
                                {
                                    txtDisplay.Text = this.display[0];
                                }
                            }
                            else
                            {
                                txtDisplay.Text = this.display[0];
                            }
                        }
                        else
                        {
                            txtDisplay.Text = string.Empty;
                        }
                    }
                }
                else if (this.display.Length < 2)
                {
                    if (this.IsOperator(this.display[0]) == true)
                    {
                        txtDisplay.Text = string.Empty;
                    }
                }
            }
            catch (Exception e)
            {
                Label1.Text = e.Message;
            }
            
        }

        private bool HasOperation()
        {
            if (txtDisplay.Text.Contains('/') || txtDisplay.Text.Contains('x') || txtDisplay.Text.Contains('+') || txtDisplay.Text.Contains('-'))
            {
                return true;
            }
            return false;
        }

        private bool IsOperator(string op)
        {
            if (op == "/" || op == "x" || op == "+" || op == "-")
            {
                return true;
            }
            return false;
        }

        #endregion Methods

        #region Getters And Setter

        public void setDisplay(string param)
        {
            if (param == "/" || param == "x" || param == "+" || param == "-")
            {
                param = " " + param + " ";
            }
            txtDisplay.Text += param;
        }

        public void SetResult(string op, double n1, double n2)
        {
            switch (op)
            {
                case "/":
                    if (n1 != 0 && n2 != 0)
                    {
                        this.result = n1 / n2;
                    }
                    else if (n1 == 0 && n2 == 0)
                    {
                        this.result = 0;
                    }
                    else if (n1 == 0)
                    {
                        this.result = n2;
                    }
                    else if (n2 == 0)
                    {
                        this.result = n1;
                    }
                    break;
                case "-":
                    this.result = n1 - n2;
                    break;
                case "+":
                    this.result = n1 + n2;
                    break;
                case "x":
                    this.result = n1 * n2;
                    break;
            }
        }

        #endregion Getters And Setter
    }
}