using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPL
{
    public partial class frmTPL : Form
    {
        public frmTPL()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Thread comandas;
        private void cmdCheck_Click(object sender, EventArgs e)
        {
            lstData0.Items.Clear();
            lstData0.BackColor = Color.White;
            lstData1.Items.Clear();
            lstData1.BackColor = Color.White;
            lstData2.Items.Clear();
            lstData2.BackColor = Color.White;

            comandas = new Thread(StartProcess);
            comandas.Start();

           
        }

        private void StartProcess()
        {
            string[] nomFitxer = { "1.txt", "2.txt", "3.txt" };

            Parallel.For(0, 3, i =>
            {
                string filepath = Application.StartupPath + "\\" + nomFitxer[i];
                string readText = File.ReadAllText(filepath);
                string[] Text = readText.Split(' ', '.', ',', '\n', '\r');

                ListBox[] lst = { lstData0, lstData1, lstData2 };
                DoChecks(Text, lst[i]);
            });
            comandas.Abort();
        }


        private void DoChecks(string[] words, ListBox lst)
        {

            string[] Searchwords = { "white", "time", "that", "the", "empty", "door", "table" };
            string[] SearchLetter = { "A", "C", "W", "Z", "L", "S", "E" };

            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);
            var randomIntegrer = BitConverter.ToInt32(byteArray, 0);
            Random rng = new Random(randomIntegrer);
            int random = rng.Next(4, 10);


            Parallel.Invoke(() =>
            {
                lst.Items.Add(GetLongestWord(words));
            },  

                 () =>
                 {
                     lst.Items.Add(GetMostCommonWords(words, random, 5));
                 }, 

                 () =>
                 {
                     lst.Items.Add(GetMostCommonWordsByLength(words, random, 5));
                 }, 

                 () =>
                 {
                     Parallel.ForEach(Searchwords, s =>
                     {
                         lst.Items.Add(GetCountForWord(words, s));
                     });
                 }, 

                 () =>
                 {
                     Parallel.ForEach(SearchLetter, s =>
                     {
                         lst.Items.Add(GetCountForLetter(words, s));
                     });
                 }, 

                 () =>
                 {
                     lst.Items.Add(GetLessCommonWords(words, random, 5));
                 } 
             ); 
            lst.BackColor = Color.Green;
        }


        #region HelperMethods


        private string  GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();

            longestWord = ($"Task 1 -- The longest word is {longestWord}.");
            return longestWord;

        }


        private string GetMostCommonWords(string[] words, int len,  int quants)
        {
            string resultat = "";
            var frequencyOrder = from word in words
                                 where word.Length > len
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(10);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 2 -- The most common words are:");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v);
            }
            resultat = (sb.ToString());
            return resultat;
        }


        private string GetMostCommonWordsByLength(string[] words, int len, int quants)
        {

            string resultat = "";
            var frequencyOrder = from word in words
                                 where word.Length == len
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 3 -- The most common words by length are:");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v.ToUpper());
            }
            resultat = (sb.ToString());
            return resultat;

        }

        private string GetCountForWord(string[] words, string term)
        {
            string resultat = "";
            var findWord = from word in words
                           where word.ToUpper().Contains(term.ToUpper())
                           select word;

            resultat = ($@"Task 4 -- The word ""{term}"" occurs {findWord.Count()} times.");
            return resultat;

        }

        private string GetCountForLetter(string[] words, string letter)
        {
            string resultat = "";
            var findLetter = from word in words
                           where word.ToUpper().Contains(letter.ToUpper())
                           select word;

            resultat = ($@"Task 5 -- The letter ""{letter}"" occurs {findLetter.Count()} times.");
            return resultat;

        }



        private string  GetLessCommonWords(string[] words, int len, int quants)
        {

            string resultat = "";
            var frequencyOrder = from word in words
                                 where word.Length == len
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 6 -- The less words by length are:");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v.ToUpper());
            }
            resultat = (sb.ToString());
            return resultat;

        }








        ///Falten les funcions que llegeixen el fitxer i en darrer cas el transformen en un array de strings amb les paraules. 
        ///Podeu utilitzar la funció de l'exemple com a base (CreateWordArray), però penseu que ara els fitxers són locals i no  una URL,
        ///i que potser caldrà fer-ho d'una forma una mica diferent per afavorir automatitzar el programa.



        #endregion

        private void lstData0_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prova
            //brancanova
        }
    }
}
