using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blog;

namespace Trvel
{
    
    public partial class Blog : Form
    {
        TravelRepository repository;
        public Blog()
        {
            InitializeComponent();
        }

        private void Blog_Load(object sender, EventArgs e)
        {
            groupBoxBlog.Visible = true;
            panelBlog.Visible = false;
            repository = new TravelRepository();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {

            try
            {
                var newBlog = new BlogInfo();
                newBlog.Title = txtTitle.Text;
                newBlog.Article = txtBlog.Text;
                newBlog.ImagePath = txtPath.Text;

                groupBoxBlog.Visible = false;
                panelBlog.Visible = true;
                txtTitleShow.Text = newBlog.Title;
                txtTitleShow.ReadOnly = true;
                txtBlogShow.Text = newBlog.Article;
                txtBlogShow.ReadOnly = true;
                pictureBoxImage.ImageLocation = newBlog.ImagePath;

                repository.AddBlog(newBlog);                        // Add new Blog to database.
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2 f2 = new form2();
            f2.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }
    }
}
