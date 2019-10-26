using BecodingDesktop.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Models
{
    public class MenuOptionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Bitmap Selected { get; set; }
        public Bitmap UnSelected { get; set; }
        public Color SelectedColor { get; set; }
        public Color UnSelectedColor { get; set; }
        public List<MenuOptionModel> SubItems { get; set; }
        public EventHandler ClickEvent { get; set; }
        public bool SelectedState { get; set; }
        public MenuOptionName FormAssigned { get; set; } 
        public Bitmap Banner { get; set; }

    }
}
