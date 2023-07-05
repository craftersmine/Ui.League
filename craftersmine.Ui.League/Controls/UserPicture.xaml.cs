using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace craftersmine.Ui.League.Controls
{
    /// <summary>
    /// Represents a static control for user profile picture
    /// </summary>
    public partial class UserPicture : Border
    {
        /// <summary>
        /// Gets or sets image source
        /// </summary>
        public ImageSource? ImageSource { get; set; }

        /// <summary>
        /// Instantiates a new instance of <see cref="UserPicture"/>
        /// </summary>
        public UserPicture()
        {
            InitializeComponent();
        }
    }
}
