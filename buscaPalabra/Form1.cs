using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;


namespace buscaPalabra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string caracter1 = letra1.Text;
        //    string caracter2 = letra2.Text;
        //    string caracter3 = letra3.Text;
        //    string caracter4 = letra4.Text;
        //    string caracter5 = letra5.Text;
        //    string caracter6 = letra6.Text;
        //    ControlPermutaciones cp = new ControlPermutaciones();
        //    SQLiteController SQLController = new SQLiteController();

        //    //SQLController.accesoBD("Select", "adfasdfe");

        //    List<String> wordsInTextBox = new List<string>() { caracter1, caracter2, caracter3, caracter4, caracter5, caracter6 };

        //    List<String> nuevaList = new List<string>();

        //    Random random = new Random();
        //    string wordsCombination = "";
        //    try
        //    {


        //        for (int i = 0; i < 100; i++)
        //        {
        //            int count = cp.combinationList.Count;
        //            label2.Text = "";
        //            //isFoundedInRepeatWords = false;
        //            if (wordsCombination.Length >= 6)
        //            {
        //                wordsCombination = "";
        //            }

        //            int wordTextBoxPosition = random.Next(0, wordsInTextBox.Count);
        //            string lettersCombination = wordsInTextBox[wordTextBoxPosition];
        //            nuevaList.Add(wordsInTextBox[wordTextBoxPosition]);
        //            wordsCombination += lettersCombination;

        //            if (cp.foundWord(wordsCombination) == false)
        //            {

        //                if (SQLController.accesoBD("Select", wordsCombination))
        //                {
        //                    cp.wordsInsideDictionary.Add(wordsCombination);
        //                }
        //            }
        //            else
        //            {
        //                i--;
        //            }

        //            wordsInTextBox.RemoveAt(wordTextBoxPosition);
        //            if (wordsInTextBox.Count == 0)
        //            {
        //                wordsInTextBox.Add(nuevaList[0]);
        //                wordsInTextBox.Add(nuevaList[1]);
        //                wordsInTextBox.Add(nuevaList[2]);
        //            }


        //        }

        //        foreach (string palabras in cp.wordsInsideDictionary)
        //        {
        //            label2.Text += palabras + "\n";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }


        //}

        private void button2_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ThreadStart delegado = new ThreadStart(mySearch);
            Thread hilo = new Thread(delegado);
            hilo.Start();
            
        }

        public void mySearch()
        {

            label3.Text = "Buscando...";
            string caracter1 = letra1.Text;
            string caracter2 = letra2.Text;
            string caracter3 = letra3.Text;
            string caracter4 = letra4.Text;
            string caracter5 = letra5.Text;
            string caracter6 = letra6.Text;
            label2.Text = "";
            SQLiteController SQLController = new SQLiteController();
            string wordsCombination = "";
            List<String> wordsInTextBox = new List<string>() { caracter1, caracter2, caracter3, caracter4, caracter5, caracter6 };
            List<String> lista = new List<string>();
            List<String> listaDeSeis = new List<string>();
            List<String> wordsInsideDictionary = new List<string>();
            Random random = new Random();
            for (int i = 0; i < 1630; i++)//1956; i++)
            {
                if (wordsCombination.Length >= 6)
                {
                    wordsCombination = "";
                }
                
                if (wordsInTextBox.Count == 0)
                {
                    wordsInTextBox.Add(listaDeSeis[0]);
                    wordsInTextBox.Add(listaDeSeis[1]);
                    wordsInTextBox.Add(listaDeSeis[2]);
                    wordsInTextBox.Add(listaDeSeis[3]);
                    wordsInTextBox.Add(listaDeSeis[4]);
                    wordsInTextBox.Add(listaDeSeis[5]);
                }
                int wordTextBoxPosition = random.Next(0, wordsInTextBox.Count);
                string lettersCombination = wordsInTextBox[wordTextBoxPosition];
                listaDeSeis.Add(wordsInTextBox[wordTextBoxPosition]);
                wordsCombination += lettersCombination;
                wordsInTextBox.RemoveAt(wordTextBoxPosition);
                bool inside = false;
                foreach (string palabra in lista)
                {

                    if (palabra == wordsCombination)
                    {
                        inside = true;
                        break;
                    }
                }

                if (inside == false)
                {
                    lista.Add(wordsCombination);
                }
                else
                {
                    i--;
                }


            }
            foreach (string palabra in lista)
            {
                if (SQLController.accesoBD("Select", palabra))
                {
                    if (palabra.Length >= 3)
                    {
                        wordsInsideDictionary.Add(palabra);
                        label2.Text += palabra + "\n";
                    }
                    
                }
            }

            int count = wordsInsideDictionary.Count;
            label3.Text = "Búsqueda finalizada";
        }

       
    }
}


