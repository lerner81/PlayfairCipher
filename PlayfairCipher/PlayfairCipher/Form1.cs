using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayfairCipher
{
    public partial class Translator : Form
    {

        public Translator()//constructor
        {
        InitializeComponent(); 
        }

        private void arrayConstructor()
        {
        String alpha = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        char[,] encrypt = new char[5, 5];
        var chars = alpha.ToCharArray();
        string secret = secretWordBox.Text.ToUpper();

            // appends secret word to alpha string
        string alpha2 = secret + alpha;

            //removes duplicates
        alpha2 = RemoveDuplicates(alpha2);

        chars = alpha2.ToCharArray();

            int j = 0;
            int row1 = 0;
            int col1 = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'J')
                    continue;
                j++;

                if (j == 5)
                {
                    j = 0;
                }
                if (col1 == 5)
                {
                    col1 = 0;
                    row1++;
                }
                encrypt[row1, col1] = chars[i];
                col1++;              
            }//end of for 

            //get the input message
            string inputText = inputTextBox.Text.ToUpper();
            string outputText = "";
            inputText.ToCharArray();


            // take the input text and find the spot in the new array where the letters go.
            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == ' ')
                {
                    outputText += ' ';
                    continue;
                }
                for (int m = 0; m < 5; m++)
                {
                    for (int n = 0; n < 5; n++)
                    {
                        //How to account for the spaces in the input text?
                        if (inputText[i] == encrypt[m, n])
                        {
                            outputText += encrypt[n, m];
                        }                    
             
                        
                    }
                }
            }


            ouputTextBox.Text = outputText;
            inputTextBox.Text = inputText;
            secretWordBox.Text = secret;
        }//end of arrayConstructor
        
        static string RemoveDuplicates(string key)
        {
            string result = ""; //initialize result
            foreach (char value in key)
            {
                if (result.IndexOf(value) == -1)
                {
                    result += value;
                }
            }
            return result;

        } 

        private void translateBtn_Click(object sender, EventArgs e)
        {
            arrayConstructor();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            secretWordBox.Clear();
            inputTextBox.Clear();
            ouputTextBox.Clear();
            secretWordBox.Focus();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
