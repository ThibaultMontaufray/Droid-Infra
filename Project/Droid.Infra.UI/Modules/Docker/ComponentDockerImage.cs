using Droid.Infra.Modules.Docker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid.Infra.UI.Modules.Docker.View
{
    public partial class ComponentDockerImage : Component
    {
        #region Attributes
        private Model.Image _image;
        private delegate void RefreshDataDelegate();
        #endregion

        #region Properties
        public Model.Image Image
        {
            get { return _image; }
            set
            {
                if (_image != null)
                {
                    _image.ImageUpdated -= _image_ImageUpdated;
                    this.Name = _image.Id;
                }
                _image = value; RefreshData();
                _image.ImageUpdated += _image_ImageUpdated;
            }
        }
        #endregion

        #region Constructor
        public ComponentDockerImage()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
        }

        public ComponentDockerImage(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_image != null)
            {
                //labelImageName.Text = _image.Repository.Length > 6 ? ".." + _image.Repository.Substring(_image.Repository.Length - 6, 6) : _image.Repository;
                labelImageName.Text =  _image.Repository;
                labelTag.Text = _image.Tag;
                labelSize.Text = _image.Size;
                if (_image.Repository.ToLower().Contains("kibana")) { pictureBoxIcon.BackgroundImage = Properties.Resources.kibana; }
                else if (_image.Repository.ToLower().Contains("elasticsearch")) { pictureBoxIcon.BackgroundImage = Properties.Resources.elasticsearch; }
                else if (_image.Repository.ToLower().Contains("postgres")) { pictureBoxIcon.BackgroundImage = Properties.Resources.postgresql; }
                else if (_image.Repository.ToLower().Contains("syncany")) { pictureBoxIcon.BackgroundImage = Properties.Resources.syncany; }
                else if (_image.Repository.ToLower().Contains("sonar")) { pictureBoxIcon.BackgroundImage = Properties.Resources.sonar; }
                else if (_image.Repository.ToLower().Contains("vpn")) { pictureBoxIcon.BackgroundImage = Properties.Resources.VPN; }
                else if (_image.Repository.ToLower().Contains("winscp")) { pictureBoxIcon.BackgroundImage = Properties.Resources.winscp; }
                else if (_image.Repository.ToLower().Contains("bimandco")) { pictureBoxIcon.BackgroundImage = Properties.Resources.bimandco; }
                else if (_image.Repository.ToLower().Contains("ncover")) { pictureBoxIcon.BackgroundImage = Properties.Resources.NCover; }
                else if (_image.Repository.ToLower().Contains("teamcity")) { pictureBoxIcon.BackgroundImage = Properties.Resources.teamcity; }
                else if (_image.Repository.ToLower().Contains("jenkins")) { pictureBoxIcon.BackgroundImage = Properties.Resources.jenkins; }
                else if (_image.Repository.ToLower().Contains("redis")) { pictureBoxIcon.BackgroundImage = Properties.Resources.redis; }
                else if (_image.Repository.ToLower().Contains("service")) { pictureBoxIcon.BackgroundImage = Properties.Resources.service; }
                else if (_image.Repository.ToLower().Contains("portainer")) { pictureBoxIcon.BackgroundImage = Properties.Resources.portainer; }
                else if (_image.Repository.ToLower().Contains("servodroid")) { pictureBoxIcon.BackgroundImage = Properties.Resources.servodroid; }
                else if (_image.Repository.ToLower().Contains("mono")) { pictureBoxIcon.BackgroundImage = Properties.Resources.mono; }
                else if (_image.Repository.ToLower().Contains("db")) { pictureBoxIcon.BackgroundImage = Properties.Resources.database; }
                else if (_image.Repository.ToLower().Contains("docker")) { pictureBoxIcon.BackgroundImage = Properties.Resources.docker; }
                else pictureBoxIcon.BackgroundImage = null;// Droid.Image.Interface_image.ACTION_135_research_web("software icon " + _image.Repository.Replace("-oss", string.Empty) + " data");
                pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            }
            else
            {
                labelImageName.Text = string.Empty;
                pictureBoxIcon.Image = null;
            }
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        private void _image_ImageUpdated()
        {
            this.Invoke(new RefreshDataDelegate(RefreshData));
        }
        #endregion
    }
}
