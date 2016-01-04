using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassResource;

namespace GrindAgesGame
{
    public partial class GrindAges : Form
    {
        private BasicResources _design; 

        public GrindAges()
        {
            InitializeComponent();
            _design = new BasicResources();

            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(2, "mięso", 2, 0));
            _design.basic_resources.Add(new Resource(3, "ryby", 2, 0));
            _design.basic_resources.Add(new Resource(4, "bulwy", 1, 0));
            _design.basic_resources.Add(new Resource(5, "chrust", 5, 0));
            _design.basic_resources.Add(new Resource(6, "gałęzie", 3, 0));
            _design.basic_resources.Add(new Resource(7, "pniaki", 2, 0));
            _design.basic_resources.Add(new Resource(8, "glina", 10, 0));
            _design.basic_resources.Add(new Resource(9, "krzemień", 5, 0));
            _design.basic_resources.Add(new Resource(10, "futro", 0, 0));
            _design.basic_resources.Add(new Resource(11, "skóra", 5, 0));
            _design.basic_resources.Add(new Resource(12, "rzemień", 2, 0));
            _design.basic_resources.Add(new Resource(13, "kości", 5, 0));
            _design.basic_resources.Add(new Resource(14, "rogi", 2, 0));
            _design.basic_resources.Add(new Resource(15, "muszle", 0, 0));
            _design.basic_resources.Add(new Resource(16, "drewno", 0, 0));
            _design.basic_resources.Add(new Resource(17, "żywność", 0, 0));
            _design.basic_resources.Add(new Resource(18, "kamień", 0, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));
            _design.basic_resources.Add(new Resource(1, "jagody", 5, 0));


        }

        private void GrindAges_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResourcesForm FormResources = new ResourcesForm();
            FormResources.Location = this.Location;
            FormResources.Show(this);
            
        }
    }
}
