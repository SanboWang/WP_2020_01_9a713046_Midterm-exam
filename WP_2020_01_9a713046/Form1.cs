using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_9a713046
{
    public partial class Formgame : Form
    {

        string[] d = new string[54];  //紙牌路徑
        static int[] a = new int[52];        //紙牌編碼

        int point, bigsmall;
        //判斷大還還是小牌

        //猜大小
        public enum guessCard {  big, samll };//0:大 1,小
        bool gameover; //判斷是否還有籌碼，沒籌碼則遊戲結束      
        public Formgame()
        {
            InitializeComponent();
        }
        #region 讀取資料夾圖檔
        
        private void Form1_Load(object sender, EventArgs e)
        {
            EnableButton(false);
            //撲克牌圖案建置
            string picPath = GetDirectory("pic");
            for (int i = 0; i <= 52; i++)
                d[i] = picPath + @"\g" + i.ToString() + ".jpg";
        }

        //取得撲克牌檔案路徑
        private string GetDirectory(string name)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Application.StartupPath);
            string path = (dir.Parent).Parent.FullName;
            return path + string.Format(@"\{0}\", name);
        }
        #endregion

        #region 按下發牌的預設值


        private void btnDeal_Click(object sender, EventArgs e)//發牌事件
        {
            int i, rnum, temp;
            EnableButton(true);
            pictureBox1.Image = Image.FromFile(@d[52]);//按第一下蓋底牌蓋牌

            //隨機產出一張牌
            Random ran = new Random();
            for (i = 0; i < 52; i++)
            {
                a[i] = i;
            }
            for (i = 0; i < 52; i++)
            {
                rnum = ran.Next(51);
                temp = a[i];
                a[i] = a[rnum];
                a[rnum] = temp;
            }

            //重新開始後初始值
            if (gameover)
            {
                
                btnDeal.Text = "發牌";
                tbmoney.Text = "10";
                lbmoney.Text = "100";
                gameover = false;
            }
        }
        #endregion

        #region 遊戲進行中的條件


        //下注完成開牌 
        public void opencard(guessCard guess)
        {
            bool bingo = false;
            int playerguess = (int)guess;
            int playermoney;
            if (!Int32.TryParse(lbmoney.Text, out playermoney))
            {
                playermoney = 0;
            }
            int betMoney;
            if (!Int32.TryParse(tbmoney.Text, out betMoney))
            {
                betMoney = 0;
                MessageBox.Show("下注金額請輸入整數數字");
                return;
            }
            
            if (betMoney > 0 && betMoney <= playermoney)  //押注金額>0並且<=剩下籌碼
            {
                EnableButton(false); //隱藏按鈕

                pictureBox1.Image = Image.FromFile(@d[a[0]]);
                int cardRate = -1;               
                infolabel.Text = "";  //回復判定大小為空白             
                point = a[0] / 4;     //點數
              
                if (point < 7 && point != 0)
                {
                    bigsmall = 1;
                    infolabel.Text += "此排為小";
                    if (playerguess == 1)
                        bingo = true;
                }
                else
                {
                    bigsmall = 2;
                    infolabel.Text += "此排為大";
                    if (playerguess == 0)
                        bingo = true;
                }

                bwinlose.Text = bingo ? "你贏了" : "你輸了";
                //贏或輸改變籌碼數量
                if (bingo)
                {
                    cardRate = 1;
                }
                playermoney += betMoney * cardRate;
                lbmoney.Text = playermoney.ToString();

                //籌碼輸光
                if (playermoney <= 0)
                {
                    btnDeal.Text = "重新開始";
                    lbtoptext.Text = "你破產了，請按重新開始";
                    gameover = true;
                }
            }

            else
            {
                MessageBox.Show("請輸入大於0並且小於等於剩餘籌碼的金額。");
            }
        }
        #endregion

        #region 按鈕事件
       
        private void btnbig_Click_1(object sender, EventArgs e)
        {
            opencard(guessCard.big);
        }
        
        private void btnsmall_Click_1(object sender, EventArgs e)
        {
            opencard(guessCard.samll);
        }

        private void EnableButton(bool isEnable)
        {
            btnbig.Enabled = isEnable;
            btnsmall.Enabled = isEnable;
            btnDeal.Enabled = !isEnable;
        }
        //按下結束遊戲按鈕事件
        private void btnend_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("你確定要結束遊戲嗎?", "結束遊戲", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

       


    } 
}    


    

