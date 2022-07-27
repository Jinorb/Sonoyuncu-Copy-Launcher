using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonOyuncu_Launcher
{
    public partial class FulScreen : Component
    {
        public FulScreen()
        {
            InitializeComponent();
        }

        public FulScreen(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
