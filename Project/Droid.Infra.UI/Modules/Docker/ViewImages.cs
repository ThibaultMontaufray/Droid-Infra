using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utilities;
using Droid.Infra.Modules.Docker.Controler;
using Docker.DotNet.Models;
using Droid.Infra.Modules.Docker.Model;

namespace Droid.Infra.UI.Modules.Docker.View
{
    public partial class ViewImages : UserControlCustom
    {
        #region Attributes
        private DockerAdapter _adapter;
        #endregion

        #region Properties
        public DockerAdapter Adapter
        {
            get { return _adapter; }
            set
            {
                _adapter = value;
                RefreshData();
            }
        }
        #endregion

        #region Constructor
        public ViewImages()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_adapter != null && _adapter.Engine != null)
            {
                _adapter.Engine.RefreshDataAsync();

                if (_adapter.Engine.CurrentMachine != null)
                {
                    List<Model.Image> images = _adapter.Engine.CurrentMachine.Images;
                    if (images != null)
                    {
                        LoadImages(images);
                    }
                }
                else
                {
                    CleanImages();
                }
            }
            else
            {
                CleanImages();
            }
        }
        #endregion

        #region Methods private
        private void LoadImages(List<Model.Image> images)
        {
            System.Drawing.Image icon;
            this.SuspendLayout();
            dataGridViewImages.Rows.Clear();

            foreach (Model.Image img in images)
            {
                icon = Droid.Image.Interface_image.ACTION_135_research_icon("icon " + img.Repository.Split('/')[img.Repository.Split('/').Length - 1].Replace("-oss", string.Empty));
                dataGridViewImages.Rows.Add();
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Cells[ColumnIcon.Index].Value = icon == null ? Properties.Resources.docker_image : icon;
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Cells[ColumnId.Index].Value = img.Id.Substring(7, 12);
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Cells[ColumnRepository.Index].Value = img.Repository;
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Cells[ColumnSize.Index].Value = img.Size;
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Cells[ColumnTag.Index].Value = img.Tag;
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Cells[ColumnCreated.Index].Value = img.Created;
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Cells[ColumnDelete.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.cross;
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Cells[ColumnInspect.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.zoom;
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Height = 48;
                dataGridViewImages.Rows[dataGridViewImages.Rows.Count - 1].Tag = img;
            }
            this.ResumeLayout();

        }
        private void CleanImages()
        {
            this.SuspendLayout();
            dataGridViewImages.Rows.Clear();
            this.ResumeLayout();
        }
        private void Delete(int rowIndex)
        {
            if (_adapter != null && _adapter.Engine != null && _adapter.Engine.CurrentMachine != null)
            {
                _adapter.Engine.CurrentMachine.Images.Where(i => i.Id == dataGridViewImages.Rows[rowIndex].Cells[ColumnId.Index].Value?.ToString()).First()?.Delete();
                RefreshData();
            }
        }
        private void Inspect(int rowIndex)
        {
        }
        #endregion

        #region Event
        private void dataGridViewImages_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnDelete.Index)
            {
                Delete(e.RowIndex);
            }
            else if (e.ColumnIndex == ColumnInspect.Index)
            {
                _adapter.CurrentImage = dataGridViewImages.Rows[e.RowIndex].Tag as Model.Image;
                _adapter.GoAction("inspectImage");
                //Inspect(e.RowIndex);
            }
        }
        #endregion
    }
}
