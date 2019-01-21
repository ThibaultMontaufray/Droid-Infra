using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpBucket.V1.Pocos;

namespace Droid.Infra.UI
{
    public partial class ViewBitBucketIssue : UserControl
    {
        #region Attributes
        private Issue _issue = null;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ViewBitBucketIssue()
        {
            InitializeComponent();
        }
        public ViewBitBucketIssue(Issue issue)
        {
            _issue = issue;
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public void LoadIssue(Issue issue)
        {
            _issue = issue;
            LoadData();
        }
        #endregion

        #region Methods private
        private void LoadData()
        {
            if (_issue != null)
            { 
                labelTitle.Text = _issue.title;
                labelCreateDate.Text = _issue.created_on;
                labelContent.Text = _issue.content;
                labelKind.Text = _issue.kind;
                labelReported.Text = _issue.reported_by.display_name;
                labelResponsible.Text = _issue.responsible.display_name;
                labelStatus.Text = _issue.status;
                labelUpdate.Text = _issue.utc_last_updated;
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
