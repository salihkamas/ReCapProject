using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
            _brandService = new BrandManager(new EfBrandDal());
            _colorService = new ColorManager(new EfColorDal());
            _custormerService = new CustomerManager(new EfCustomerDal());
            _rentalService = new RentalManager(new EfRentalDal());
            _userService = new UserManager(new EfUserDal());
        }
        ICarService _carService;
        IColorService _colorService;
        IBrandService _brandService;
        IUserService _userService;
        ICustomerService _custormerService;
        IRentalService _rentalService;

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    string[] row = { car.CarName, car.BrandName,car.ColorName,car.DailyPrice.ToString() };
                    var satir = new ListViewItem(row);
                    listView1.Items.Add(satir);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Car", 100);
            listView1.Columns.Add("Brand", 70);
            listView1.Columns.Add("Color", 70);
            listView1.Columns.Add("DailyPrice", 70);

            var result = _brandService.GetAll();
            var result1 = _colorService.GetAll();
            foreach (var brand in result.Data)
            {
                comboBox1.Items.Add(brand.BrandName);
            }
            foreach (var color in result1.Data)
            {
                comboBox2.Items.Add(color.ColorName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Car car = new Car
            {
                BrandId = int.Parse((comboBox1.SelectedIndex + 1).ToString()),
                CarName = textBox1.Text,
                ColorId = int.Parse((comboBox2.SelectedIndex + 1).ToString()),
                DailyPrice = Convert.ToDecimal(textBox2.Text),
                Description = textBox3.Text,
                ModelYear = textBox4.Text
            };
            var result = _carService.Add(car);
            if (result.Success)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
