using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CSharp
{
    public partial class HW_03 : Form
    {
        private List<Dish> orderItems;
        private decimal totalPrice;


        public HW_03()
        {
            InitializeComponent();
            // 初始化菜單
            orderItems = new List<Dish>();
        }

        
        public void btnMeun1_Click(object sender, EventArgs e)
        {
            UpdateOrder("大魔術熊貓麻婆豆腐", 999.0m);
        }

        private void btnMeun2_Click(object sender, EventArgs e)
        {
            UpdateOrder("真鯛大陸圖", 666.0m);
        }

        private void btnMeun3_Click(object sender, EventArgs e)
        {
            UpdateOrder("國士無雙的面", 777.0m);

        }

        private void btnMeun4_Click(object sender, EventArgs e)
        {
            UpdateOrder("奇蹟彗星炒飯", 55.0m);
        }
        private void UpdateOrder(string dishName, decimal dishPrice)
        {
            Dish existingDish = orderItems.Find(dish => dish.Name == dishName);

            if (existingDish != null)
            {
                existingDish.Quantity++;
            }
            else
            {
                Dish newDish = new Dish
                {
                    Name = dishName,
                    Price = dishPrice,
                    Quantity = 1
                };
                orderItems.Add(newDish);
            }

            UpdateOrderList();
        }
        public class Dish
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }


        private void UpdateOrderList()
        {
            listOrder.Items.Clear();

            foreach (Dish dish in orderItems)
            {
                ListViewItem item = new ListViewItem(dish.Name);
                item.SubItems.Add(dish.Price.ToString());
                item.SubItems.Add(dish.Quantity.ToString());
                item.SubItems.Add((dish.Price * dish.Quantity).ToString());
                listOrder.Items.Add(item);
                UpdateTotalPrice();

            }
        }
    
    private void HW_03_Load(object sender, EventArgs e)
        {
           
        }
        private void UpdateTotalPrice()
        {
            totalPrice = 0;

            foreach (Dish dish in orderItems)
            {
                totalPrice += dish.Price * dish.Quantity;
            }

            // 更新標籤顯示金額總計
            labTPrice.Text = totalPrice.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("一共是" + labTPrice.Text + "元");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 將總計金額轉換為數字
            if (decimal.TryParse(labTPrice.Text, out decimal totalPrice))
            {
                // 計算加上 5% 的服務費
                decimal totalAmount = totalPrice * 1.05m;

                // 彈出訊息框顯示總計金額
                MessageBox.Show("一共是" + totalAmount.ToString() + "元");
            }

        }

  
    }
}
