using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatWhat
{
    public partial class EatWhat : Form
    {
        public EatWhat()
        {
            InitializeComponent();
        }

        private void disableAll()
        {
            this.comboBox2.Enabled = false;
            this.comboBox3.Enabled = false;
            this.btnRandomSuburb.Enabled = false;
            this.btnChoose.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hardcoded
            this.comboBox1.Items.AddRange(
                new object[] {
                    "<Please Select>",
                    "Brisbane",
                    "Gold Coast"
                }
            );

            // Index starts from 0 to (number of items -1)
            this.comboBox1.SelectedIndex = 0;
            this.disableAll();
        }

        /// <summary>
        /// I'm just too lazy to do a return, lets hardcode all the way to the end :))
        /// </summary>
        private void load_Suburb(int index)
        {
            // Clear all items inside combox2
            this.comboBox2.Items.Clear();
            if (index == 0)
                return;
            else
            {
                switch (index)
                {
                    case 1:
                        {
                            this.comboBox2.Items.AddRange(
                                new object[] {
                            "<Please Select>",
                            "Brisbane City",
                            "Toowong",
                            "Sunnybank",
                            "Runcorn",
                            "Garden City",
                            "Underwood"
                                }
                            );
                            break;
                        }
                    case 2:
                        {
                            this.comboBox2.Items.AddRange(
                                new object[] {
                            "<Please Select>",
                            "404 - List to be updated before 2087."
                                }
                            );
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                this.comboBox2.SelectedIndex = 0;
                this.comboBox2.Enabled = true;
                this.btnRandomSuburb.Enabled = true;
            }
        }

        private void load_Restaurant(string suburb)
        {
            // Make it lower case
            suburb = suburb.ToLower();

            // Clear all items inside combox3
            this.comboBox3.Items.Clear();
            if (suburb == "<please select>")
                return;

            switch (suburb)
            {
                case "brisbane city":
                    {
                        this.comboBox3.Items.AddRange(
                                new object[] {
                                    "<Please Select>",
                                    "Yakiniku Hachi",
                                    "Sushi Edo",
                                    "Shabuhouse",
                                    "Kadoya Japanese",
                                    "Nando's",
                                    "PappaRich",
                                    "Oshin Japanese Restaurant",
                                    "Ichiban Sushi",
                                    "Sushi on Roma",
                                    "Korilla BBQ",
                                    "AJ Vietnamese Noodle House",
                                    "Walter's Steakhouse and Wine Bar",
                                    "Ramen Danbo Birsbane City East"
                                }
                            );
                        break;
                    }
                case "toowong":
                    {
                        this.comboBox3.Items.AddRange(
                                new object[] {
                                    "<Please Select>",
                                    "Regatta Hotel - Steak House",
                                    "Nando's Toowong",
                                    "Jackpot Dining",
                                    "Genkotsu Ramen Toowong",
                                    "Miko's Bento",
                                    "Tokyo On Express (Not Tokyo Express lmao)",
                                    "Bird's Nest",
                                    "A Night in India Restaurant",
                                    "Motto Motto Indooroopilly"
                                }
                            );
                        break;
                    }
                case "sunnybank":
                    {
                        this.comboBox3.Items.AddRange(
                                new object[] {
                                    "<Please Select>",
                                    "Ramen Champion",
                                    "Impressive Dumplings",
                                    "Sunnybank Oriental Licensed Restaurant (東方)",
                                    "Love Malatang Sunnybank (夾麵)",
                                    "Udonya Tokoton (日本烏冬)",
                                    "Pepper Lunch Sunnybank",
                                    "Southside Bistro",
                                    "Hana Zushi",
                                    "Woofissimo Macgregor",
                                    "Kingsfood Sunnybank",
                                    "Fry Chicken Master (炸翻天)",
                                    "Golden Dumpling",
                                    "Yakiniku Ren",
                                    "Golden Kingdom",
                                    "Mui G Kitchen (妹記)",
                                    "Woka Woka Sunnybank",
                                    "Ramen Danbo Sunnybank Hills",
                                    "Sri Mahkota (馬拉)",
                                    "Soba Shimbashi",
                                    "Yangmama Taiwanese Restaurant",
                                    "Oishii Sushi Bar",
                                    "B Happy Sushi Bar",
                                    "Vietnam Corner BBQ Restaurant (東記)",
                                    "The Little Cube (千里香私房菜)",
                                    "The Cube Hot Pot (千里香火鍋)"
                                }
                            );
                        break;
                    }
                case "runcorn":
                    {
                        this.comboBox3.Items.AddRange(
                                new object[] {
                                    "<Please Select>",
                                    "Thr Fried Hub",
                                    "The Charcoal BBQ House",
                                    "Genkotsu Ramen Runcorn",
                                    "Momo Chicken And Beer",
                                    "The Vietnamese Hut",
                                    "Mien Korean Style Chinese Restaurant (??? Are you korean or chinese style?)",
                                    "Salt & Lemon Runcorn",
                                    "Paninaro Cafe",
                                    "Love Malatang Runcorn (夾麵)"
                                }
                            );
                        break;
                    }
                case "garden city":
                    {
                        this.comboBox3.Items.AddRange(
                                new object[] {
                                    "<Please Select>",
                                    "8 Street (八號胡同)",
                                    "Zambrero Garden City",
                                    "Lanzhou Beef Noodle (蘭州牛肉麵)",
                                    "Motto Motto Garden City",
                                    "PappaRich Garden City",
                                    "Mad Mex Fresh Mexican",
                                    "Kinn Thai",
                                    "Vapiano Garden City",
                                    "Sushi Edo",
                                    "Ph by Pho Hung",
                                    "Hakataya Ramen",
                                    "Grill'd Garden City"
                                }
                            );
                        break;
                    }
                case "underwood":
                    {
                        this.comboBox3.Items.AddRange(
                                new object[] {
                                    "<Please Select>",
                                    "Woka Woka Underwood",
                                    "Akai Ushi (赤牛)",
                                    "Malay House",
                                    "Eat Sushi",
                                    "Getta Burger",
                                    "Afanti Uyghur Cuisine",
                                    "Shinbashi Yakiniku",
                                    "Japanese Bento",
                                    "Mangal Char Grill",
                                    "Ikkairo Ramen",
                                    "Manok Park",
                                    "Mocky's Burgers & Mocktails",
                                    "Ispa Kehabs"
                                }
                            );
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            this.comboBox3.Enabled = true;
            this.btnChoose.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.disableAll();
                return;
            }
            this.load_Suburb(this.comboBox1.SelectedIndex);
        }

        private void btnRandomSuburb_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedIndex == 0)
            {
                return;
            }
            int numberCount = this.comboBox2.Items.Count;
            int randomSelect = 1 + new Random().Next(numberCount - 1);
            this.comboBox2.SelectedIndex = randomSelect;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox2.SelectedIndex == 0)
            {
                this.comboBox3.Enabled = false;
                this.btnChoose.Enabled = false;
                return;
            }
            this.load_Restaurant(this.comboBox2.SelectedItem as string);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedIndex == 0)
            {
                return;
            }
            int numberCount = this.comboBox3.Items.Count;
            int randomSelect = 1 + new Random().Next(numberCount - 1);
            this.comboBox3.SelectedIndex = randomSelect;
        }
    }
}
