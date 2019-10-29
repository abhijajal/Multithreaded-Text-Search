/* Written by Abhishek Jajal for CS6326.001, assignment 4, starting October 11, 2019.
 * This class interacts with the UI, manages background worker and also does function calls to FileIO class.
    NetID: apj180001 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apj180001Asg4
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            //When the browse button is clicked.
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {  // Opening a dialog box, which only allows to open .txt files.
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {  // Once, the file has been opened..
                TxtfilePath.Text = openFileDialog.FileName;
                FileIO.setFilePath(openFileDialog.FileName);
                // To make sure, the end path is being displayed.
                TxtfilePath.SelectionStart = TxtfilePath.TextLength;
                TxtfilePath.ScrollToCaret();
                //Enabling the searchBox
                txtSearchTerm.Enabled = true;
                toolStripLabel.Text = "Type the search term in search box, and then press enter";
            }
        }

        public void addToResultView(int lineNo,String line)
        {
            // Adds the results to the list view
            ListViewItem li = resultView.Items.Add(lineNo.ToString()); 
            li.SubItems.Add(line);            
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Enabling the result View
            resultView.Enabled = true;
            if (btnSearch.Text=="Search")
            {
                //If the text button says "Search", start searching an disable some buttons.
                resultView.Items.Clear();
                btnSearch.Text = "Cancel";
                
                if(!backgroundWorker1.IsBusy) // if the background worker is not running, run it.
                {
                    matchCase.Enabled = false;
                    txtSearchTerm.Enabled = false;
                    btnBrowse.Enabled = false;
                    toolStripLabel.Text = "Searching for '" + txtSearchTerm.Text + "'...";
                    backgroundWorker1.RunWorkerAsync();
                    
                }
            }
            else if(btnSearch.Text=="Cancel") 
            {
                //If button says "Cancel", cancel the search and re-enable buttons.
                btnSearch.Text = "Search";
                if(backgroundWorker1.IsBusy) // if the background worker is running, cancel it.
                {
                    backgroundWorker1.CancelAsync();
                    matchCase.Enabled = true;
                    txtSearchTerm.Enabled = true;
                    btnBrowse.Enabled = true;
                }
            }
        }

        private void TxtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            // When, something is typed in the search box, enable and disable search button accordingly.
            if(txtSearchTerm.TextLength>0)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }

        public void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          //Calls the searchFile function of FileIO class, and returns true if it was canceled, before the execution was completed.
            e.Cancel=FileIO.searchFile(txtSearchTerm.Text, this);
        }

        public void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Sets the percentage in the progress bar & label, also adding results to the list view.
            progressBar1.Value = e.ProgressPercentage;
            progressPer.Text = e.ProgressPercentage.ToString() + "%";
            //Reads from the queue, and removes the results from it.
            while(FileIO.resultQueue.Count()>0)
            {
                resultSet rs = FileIO.resultQueue.Dequeue();
                addToResultView(rs.lineNo, rs.line);
            }
        }

        public void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            { 
                // If it was cancelled 
                toolStripLabel.Text = "Search Cancelled, "+resultView.Items.Count + " matches found !";
            }
            else if (e.Error != null)
            {   
                //If there was some error
                toolStripLabel.Text = e.Error.Message;
            }
            else
            {
                // If it was successful, change the cancel button to Search.
                btnSearch.Text = "Search";
                // If nothing was found 
                if (resultView.Items.Count == 0)
                {
                    toolStripLabel.Text = "Search Completed, but No match found !";
                }
                else 
                { // If something was found
                    toolStripLabel.Text = "Search Completed, " + resultView.Items.Count + " matches found !";
                }

            }
            //Re-enabling the buttons.
            matchCase.Enabled = true;
            txtSearchTerm.Enabled = true;
            btnBrowse.Enabled = true;


        }

        private void ResultView_DoubleClick(object sender, EventArgs e)
        {
            //Used to provide the Double Click to Copy functionality.
            // Gets the selected item from the list, and checks whether the feature is enabled.
            ListViewItem li= resultView.SelectedItems[0];
            if(li.Selected == true && (FileIO.click2CopyEnabled == true))
            {
                //Copy the result into the clipboard.
                Clipboard.SetText(li.Text+","+li.SubItems[1].Text);
                toolStripLabel.Text = "Line copied to clipboard ! You can now paste it anywhere you want.";
            }
            else if(FileIO.click2CopyEnabled==false)
            {
                toolStripLabel.Text = "Double-click to copy feature not enabled.";
            }
        }

        private void ClickToCopy_CheckedChanged(object sender, EventArgs e)
        {
            //Manages the clickToCopyEnabled boolean variable.
            if(clickToCopy.Checked==true)
            {
                FileIO.click2CopyEnabled = true;
            }
            else
            {
                FileIO.click2CopyEnabled = false;
            }

        }

        private void MatchCase_CheckedChanged(object sender, EventArgs e)
        {
            //Manages the matchCaseEnabled boolean variable.
            if (matchCase.Checked== true)
            {
                FileIO.matchCaseEnabled = true;
            }
            else
            {
                FileIO.matchCaseEnabled = false;
            }
        }
    }
}
